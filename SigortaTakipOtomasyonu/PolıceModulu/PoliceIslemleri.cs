using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SigortaTakipOtomasyonu.PoliceModulu
{
    public class PoliceIslemleri : BaseIslemler<Police>, IPoliceIslemleri
    {
        private readonly string _cs =
            "Data Source=AHMET-CAN\\SQLEXPRESS;Initial Catalog=SigortaDB;Integrated Security=True";

        // STATİC ALAN
        private static int _sayac;
        public static int Sayac => _sayac;
        public static void SifirlaSayac() => _sayac = 0;

        public override void Ekle(Police p)
        {
            using (var conn = new SqlConnection(_cs))
            using (var cmd = conn.CreateCommand())
            {

                cmd.CommandText = @"
                    INSERT INTO Policeler
                      (MusteriID, PoliseNo, BaslangicTarihi, BitisTarihi, Tutar)
                    VALUES
                      (@mID, @no, @bas, @bit, @tutar)";
                cmd.Parameters.AddWithValue("@mID", p.MusteriID);
                cmd.Parameters.AddWithValue("@no", p.PoliseNo);
                cmd.Parameters.AddWithValue("@bas", p.BaslangicTarihi);
                cmd.Parameters.AddWithValue("@bit", p.BitisTarihi);
                cmd.Parameters.AddWithValue("@tutar", p.Tutar);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            _sayac++;
        }

        public override void Guncelle(Police p)
        {
            using (var conn = new SqlConnection(_cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    UPDATE Policeler
                    SET MusteriID       = @mID,
                        PoliseNo        = @no,
                        BaslangicTarihi = @bas,
                        BitisTarihi     = @bit,
                        Tutar           = @tutar
                    WHERE PoliseID = @Id";
                cmd.Parameters.AddWithValue("@mID", p.MusteriID);
                cmd.Parameters.AddWithValue("@no", p.PoliseNo);
                cmd.Parameters.AddWithValue("@bas", p.BaslangicTarihi);
                cmd.Parameters.AddWithValue("@bit", p.BitisTarihi);
                cmd.Parameters.AddWithValue("@tutar", p.Tutar);
                cmd.Parameters.AddWithValue("@Id", p.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public override void Sil(int id)
        {
            using (var conn = new SqlConnection(_cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Policeler WHERE PoliseID = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public override List<Police> Listele()
        {
            var liste = new List<Police>();
            using (var conn = new SqlConnection(_cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT PoliseID       AS Id,
                           MusteriID,
                           PoliseNo,
                           BaslangicTarihi,
                           BitisTarihi,
                           Tutar
                    FROM Policeler";
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        liste.Add(new Police(
                            Convert.ToInt32(rdr["Id"]),
                            Convert.ToInt32(rdr["MusteriID"]),
                            rdr["PoliseNo"].ToString(),
                            Convert.ToDateTime(rdr["BaslangicTarihi"]),
                            Convert.ToDateTime(rdr["BitisTarihi"]),
                            Convert.ToDecimal(rdr["Tutar"])
                        ));
                    }
                }
            }
            return liste;
        }
        //OVERLOADİNG 
        public override List<Police> Ara(string filter)
        {
            var sonuc = new List<Police>();
            using (var conn = new SqlConnection(_cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT PoliseID AS Id,
                           MusteriID,
                           PoliseNo,
                           BaslangicTarihi,
                           BitisTarihi,
                           Tutar
                    FROM Policeler
                    WHERE PoliseNo LIKE @no";
                cmd.Parameters.AddWithValue("@no", "%" + filter + "%");
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        sonuc.Add(new Police(
                            Convert.ToInt32(rdr["Id"]),
                            Convert.ToInt32(rdr["MusteriID"]),
                            rdr["PoliseNo"].ToString(),
                            Convert.ToDateTime(rdr["BaslangicTarihi"]),
                            Convert.ToDateTime(rdr["BitisTarihi"]),
                            Convert.ToDecimal(rdr["Tutar"])
                        ));
                    }
                }
            }
            return sonuc;
        }

        // Overload: müşteri ID'ye göre arama
        public List<Police> Ara(int musteriID)
        {
            var sonuc = new List<Police>();
            using (var conn = new SqlConnection(_cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT PoliseID AS Id,
                           MusteriID,
                           PoliseNo,
                           BaslangicTarihi,
                           BitisTarihi,
                           Tutar
                    FROM Policeler
                    WHERE MusteriID = @mid";
                cmd.Parameters.AddWithValue("@mid", musteriID);
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        sonuc.Add(new Police(
                            Convert.ToInt32(rdr["Id"]),
                            Convert.ToInt32(rdr["MusteriID"]),
                            rdr["PoliseNo"].ToString(),
                            Convert.ToDateTime(rdr["BaslangicTarihi"]),
                            Convert.ToDateTime(rdr["BitisTarihi"]),
                            Convert.ToDecimal(rdr["Tutar"])
                        ));
                    }
                }
            }
            return sonuc;
        }
    }
}

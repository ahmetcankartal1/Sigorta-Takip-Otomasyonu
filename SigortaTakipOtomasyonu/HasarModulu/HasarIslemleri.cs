using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SigortaTakipOtomasyonu.HasarModulu
{
    public class HasarIslemleri : BaseIslemler<Hasar>, IHasarIslemleri
    {
        // vt Bağlantı 
        private readonly string cs =
            "Data Source=AHMET-CAN\\SQLEXPRESS;Initial Catalog=SigortaDB;Integrated Security=True";

        // Static sayaç
        private static int _sayac;
        public static int Sayac => _sayac;
        public static void SifirlaSayac() => _sayac = 0;

        // Ekle (override)
        public override void Ekle(Hasar h)
        {
            using (var conn = new SqlConnection(cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    INSERT INTO HasarKayitlari
                      (PoliseID, HasarTarihi, HasarMiktari, Aciklama)
                    VALUES
                      (@pid,      @tarih,      @tutar,       @acik)";
                cmd.Parameters.AddWithValue("@pid", h.PoliceId);
                cmd.Parameters.AddWithValue("@tarih", h.HasarTarihi);
                cmd.Parameters.AddWithValue("@tutar", h.Tutar);
                cmd.Parameters.AddWithValue("@acik", h.Aciklama);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            _sayac++;
        }

        // Güncelle (override)
        public override void Guncelle(Hasar h)
        {
            using (var conn = new SqlConnection(cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    UPDATE HasarKayitlari
                    SET
                      PoliseID     = @pid,
                      HasarTarihi  = @tarih,
                      HasarMiktari = @tutar,
                      Aciklama     = @acik
                    WHERE HasarID = @Id";
                cmd.Parameters.AddWithValue("@pid", h.PoliceId);
                cmd.Parameters.AddWithValue("@tarih", h.HasarTarihi);
                cmd.Parameters.AddWithValue("@tutar", h.Tutar);
                cmd.Parameters.AddWithValue("@acik", h.Aciklama);
                cmd.Parameters.AddWithValue("@Id", h.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Sil (override)
        public override void Sil(int id)
        {
            using (var conn = new SqlConnection(cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM HasarKayitlari WHERE HasarID = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //  Listele (override)
        public override List<Hasar> Listele()
        {
            var liste = new List<Hasar>();
            using (var conn = new SqlConnection(cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT
                      HasarID       AS Id,
                      PoliceID      AS PoliceId,
                      HasarTarihi,
                      Aciklama,
                      HasarMiktari  AS Tutar
                    FROM HasarKayitlari";
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        liste.Add(new Hasar(
                            Convert.ToInt32(rdr["Id"]),
                            Convert.ToInt32(rdr["PoliceId"]),
                            Convert.ToDateTime(rdr["HasarTarihi"]),
                            rdr["Aciklama"].ToString(),
                            Convert.ToDecimal(rdr["Tutar"])
                        ));
                    }
                }
            }
            return liste;
        }

        // Ara(string) – açıklamaya göre arama (override)
        public override List<Hasar> Ara(string filter)
        {
            var sonuc = new List<Hasar>();
            using (var conn = new SqlConnection(cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT
                      HasarID       AS Id,
                      PoliseID      AS PoliceId,
                      HasarTarihi,
                      Aciklama,
                      HasarMiktari  AS Tutar
                    FROM HasarKayitlari
                    WHERE Aciklama LIKE @f";
                cmd.Parameters.AddWithValue("@f", "%" + filter + "%");

                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        sonuc.Add(new Hasar(
                            Convert.ToInt32(rdr["Id"]),
                            Convert.ToInt32(rdr["PoliceId"]),
                            Convert.ToDateTime(rdr["HasarTarihi"]),
                            rdr["Aciklama"].ToString(),
                            Convert.ToDecimal(rdr["Tutar"])
                        ));
                    }
                }
            }
            return sonuc;
        }

        // Ara(int) – poliçe ID’ye göre arama (overload)
        public List<Hasar> Ara(int policeId)
        {
            var sonuc = new List<Hasar>();
            using (var conn = new SqlConnection(cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT
                      HasarID       AS Id,
                      PoliseID      AS PoliceId,
                      HasarTarihi,
                      Aciklama,
                      HasarMiktari  AS Tutar
                    FROM HasarKayitlari
                    WHERE PoliseID = @pid";
                cmd.Parameters.AddWithValue("@pid", policeId);

                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        sonuc.Add(new Hasar(
                            Convert.ToInt32(rdr["Id"]),
                            Convert.ToInt32(rdr["PoliseId"]),
                            Convert.ToDateTime(rdr["HasarTarihi"]),
                            rdr["Aciklama"].ToString(),
                            Convert.ToDecimal(rdr["Tutar"])
                        ));
                    }
                }
            }
            return sonuc;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SigortaTakipOtomasyonu.MusteriModulu
{
    public class MusteriIslemleri : IMusteriIslemleri
    {
        string connectionString = "Data Source=AHMET-CAN\\SQLEXPRESS;Initial Catalog=SigortaDB;Integrated Security=True";

        // Müşteri ekleme işlemi
        public void Ekle(Musteri m)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Musteriler (Ad, Soyad, Telefon) VALUES (@Ad, @Soyad, @Telefon)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ad", m.Ad);
                cmd.Parameters.AddWithValue("@Soyad", m.Soyad);
                cmd.Parameters.AddWithValue("@Telefon", m.Telefon);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Müşteri silme işlemi
        public void Sil(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                string sql = "DELETE FROM Musteriler WHERE MusteriID = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Müşteri güncelleme işlemi
        public void Guncelle(Musteri m)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
          
                string sql = "UPDATE Musteriler SET Ad=@Ad, Soyad=@Soyad, Telefon=@Telefon WHERE MusteriID = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ad", m.Ad);
                cmd.Parameters.AddWithValue("@Soyad", m.Soyad);
                cmd.Parameters.AddWithValue("@Telefon", m.Telefon);
                cmd.Parameters.AddWithValue("@Id", m.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Tüm müşterileri listeleme işlemi
        public List<Musteri> Listele()
        {
            var liste = new List<Musteri>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
          
                string sql = @"
                    SELECT 
                      MusteriID AS Id,
                      Ad,
                      Soyad,
                      Telefon
                    FROM Musteriler";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        liste.Add(new Musteri(
                            Convert.ToInt32(reader["Id"]),
                            reader["Ad"].ToString(),
                            reader["Soyad"].ToString(),
                            reader["Telefon"].ToString()
                        ));
                    }
                }
            }
            return liste;
        }

        // Ada göre müşteri arama işlemi
        public List<Musteri> Ara(string ad)
        {
            var sonuc = new List<Musteri>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    SELECT 
                      MusteriID AS Id,
                      Ad,
                      Soyad,
                      Telefon
                    FROM Musteriler
                    WHERE Ad LIKE @Ad";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ad", "%" + ad + "%");
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sonuc.Add(new Musteri(
                            Convert.ToInt32(reader["Id"]),
                            reader["Ad"].ToString(),
                            reader["Soyad"].ToString(),
                            reader["Telefon"].ToString()
                        ));
                    }
                }
            }
            return sonuc;
        }

        // Telefon numarasının geçerli olup olmadığını kontrol etme
        public bool TelefonGecerliMi(string telefon)
        {
            return telefon.Length == 10 && long.TryParse(telefon, out _);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SigortaTakipOtomasyonu.MusteriModulu;


namespace SigortaTakipOtomasyonu.MusteriModulu
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public Musteri(int id, string ad, string soyad, string telefon)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
        }

        public Musteri() { } // Parametresiz constructoR
    }
}






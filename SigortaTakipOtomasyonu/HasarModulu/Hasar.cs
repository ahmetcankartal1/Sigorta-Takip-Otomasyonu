using System;

namespace SigortaTakipOtomasyonu.HasarModulu
{
    public class Hasar
    {
        // KAPSÜLLEME
        private int _id;
        private int _poliseId;
        private DateTime _tarih;
        private string _aciklama;
        private decimal _tutar;

        public int Id { get => _id; private set => _id = value; }
        public int PoliceId { get => _poliseId; set => _poliseId = value; }
        public DateTime HasarTarihi { get => _tarih; set => _tarih = value; }
        public string Aciklama { get => _aciklama; set => _aciklama = value; }
        public decimal Tutar { get => _tutar; set => _tutar = value; }

        //  YAPICI METOT 
        public Hasar(int id, int poliseId, DateTime hasarTarihi, string aciklama, decimal tutar)
        {
            _id = id;
            _poliseId = poliseId;
            _tarih = hasarTarihi;
            _aciklama = aciklama;
            _tutar = tutar;
        }
    }
}

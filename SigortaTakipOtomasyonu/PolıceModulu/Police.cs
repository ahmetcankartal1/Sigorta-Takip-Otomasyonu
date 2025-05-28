using System;

namespace SigortaTakipOtomasyonu.PoliceModulu
{
    public class Police
    {
        //KAPSÜLLEME
        private int _id;
        private int _musteriID;
        private string _poliseNo;
        private DateTime _bas;
        private DateTime _bit;
        private decimal _tutar;

        public int Id { get => _id; private set => _id = value; }
        public int MusteriID { get => _musteriID; set => _musteriID = value; }
        public string PoliseNo { get => _poliseNo; set => _poliseNo = value; }
        public DateTime BaslangicTarihi { get => _bas; set => _bas = value; }
        public DateTime BitisTarihi { get => _bit; set => _bit = value; }
        public decimal Tutar { get => _tutar; set => _tutar = value; }
        //YAPICI METOT
        public Police(int id, int musteriID, string poliseNo,
                      DateTime bas, DateTime bit, decimal tutar)
        {
            _id = id;
            _musteriID = musteriID;
            _poliseNo = poliseNo;
            _bas = bas;
            _bit = bit;
            _tutar = tutar;
        }
    }
}

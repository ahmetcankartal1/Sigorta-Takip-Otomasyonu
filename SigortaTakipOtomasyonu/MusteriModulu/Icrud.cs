using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using SigortaTakipOtomasyonu.PoliceModulu;



namespace SigortaTakipOtomasyonu.MusteriModulu
{
    public interface ICrud
    {
        void Ekle(Musteri m);               // Müşteri ekler
        void Sil(int id);                   // ID'ye göre müşteri siler
        void Guncelle(Musteri m);           // Müşteri bilgilerini günceller
        List<Musteri> Listele();            // Tüm müşterileri getirir
        List<Musteri> Ara(string ad);       // Ada göre müşteri arar
    }
}

using System.Collections.Generic;

namespace SigortaTakipOtomasyonu.PoliceModulu
{
    public interface ICrud<T>
    {
        void Ekle(T item);
        void Guncelle(T item);
        void Sil(int id);
        List<T> Listele();
        List<T> Ara(string filter);
    }
}

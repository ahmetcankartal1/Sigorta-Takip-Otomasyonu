using System.Collections.Generic;
using SigortaTakipOtomasyonu.PoliceModulu;

namespace SigortaTakipOtomasyonu.PoliceModulu
{
    public abstract class BaseIslemler<T> : ICrud<T>
    {
        public abstract void Ekle(T item);
        public abstract void Guncelle(T item);
        public abstract void Sil(int id);
        public abstract List<T> Listele();
        public abstract List<T> Ara(string filter);

        // virtual override edilebilir ortak metot
        public virtual void Temizle(ref T item) { }
    }
}

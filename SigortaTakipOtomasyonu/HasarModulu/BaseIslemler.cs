using System.Collections.Generic;

namespace SigortaTakipOtomasyonu.HasarModulu
{
    //  Abstraction
    public abstract class BaseIslemler<T>
    {
        public abstract void Ekle(T item);
        public abstract void Guncelle(T item);
        public abstract void Sil(int id);
        public abstract List<T> Listele();
        public abstract List<T> Ara(string filter);

        // verride edilebilecek ortak metot
        public virtual void Temizle(ref T item) { }
    }
}

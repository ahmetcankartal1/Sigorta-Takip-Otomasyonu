using System.Collections.Generic;
using System.Security.Policy;

namespace SigortaTakipOtomasyonu.HasarModulu
{
    public interface IHasarIslemleri
    {
        void Ekle(Hasar h);
        void Guncelle(Hasar h);
        void Sil(int id);
        List<Hasar> Listele();
        List<Hasar> Ara(int policeId);
    }
}

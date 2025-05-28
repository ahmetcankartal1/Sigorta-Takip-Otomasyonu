using System.Collections.Generic;

namespace SigortaTakipOtomasyonu.PoliceModulu
{
    public interface IPoliceIslemleri : ICrud<Police>
    {
        // Müşteri ID’ye göre arama overload’u
        List<Police> Ara(int musteriID);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigortaTakipOtomasyonu.MusteriModulu
{
    public interface IMusteriKontrol
    {
        bool TelefonGecerliMi(string telefon); // Telefon numarasının geçerli olup olmadığını kontrol eder
    }
}

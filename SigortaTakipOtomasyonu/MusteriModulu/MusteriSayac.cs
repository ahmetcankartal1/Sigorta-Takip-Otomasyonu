using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigortaTakipOtomasyonu.MusteriModulu
{
    public static class MusteriSayac
    {
        public static int ToplamMusteri { get; set; } = 0;

        public static void MusteriEklendi()
        {
          
           ToplamMusteri++;
        }
    }
}


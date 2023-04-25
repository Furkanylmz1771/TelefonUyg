using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakiye
{
    public class Telefon
    {

        // Parametreler

        public string isim;
        public string soyisim;
        public string tel_marka;
        public string işletim_sistemi;
        public int ram_boyutu;
        public int tel_Fiyatı;
        public int bakiye;


        // Metotlar
        public void KişiselBilgiler()
        {
            Console.WriteLine("İsminiz : " + isim);
            Console.WriteLine("Soyİsminiz: " + soyisim);
       
        }

        public void TelefonBilgiler()
        {
            Console.WriteLine("İşletim sistemi : " + işletim_sistemi);
            Console.WriteLine("Telefon markanız : " + tel_marka);
            Console.WriteLine("Ram boyutu : " + ram_boyutu);
            Console.WriteLine("Telefon fiyatı : " + tel_Fiyatı);
        }

        public void AlımGücü()
        {
            if(bakiye >= tel_Fiyatı)
            {
                Console.WriteLine("Telefonu alabilirsiniz");
            }
            else
            {
                Console.WriteLine("Telefonu alamazsınız");
            }
        }
    }
}

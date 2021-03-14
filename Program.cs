using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            *Klavyeden 2 sayi girelim
            *Önümüze bir menü çıksın
            *
            * Toplama için-> +
            *Çıkarma için-> -
            *Çarpma için-> *
            *Bölme için-> /
            *Birini seçiniz.....
            *Seçtiği işlemin sonucunu yapıp ekrana yansıtsın.
            */
            Tekrar:
            Console.WriteLine("Lütfen 2 sayi giriniz.");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen yapacağınız işlemi seçiniz \n Toplama işlemi için : + \n Çıkarma işlemi için : - \n Çarpma işlemi için : * \n Bölme işlemi için : / \n");
            string yapılacakIslem= Console.ReadLine();
            double sonuc=0.0;
            

            if (yapılacakIslem == "+" )
            {
                sonuc = sayi1 + sayi2;
            }

            if (yapılacakIslem == "-" )
            {
                sonuc = sayi1 - sayi2;
            }

            if (yapılacakIslem == "*")
            {
                sonuc = sayi1 * sayi2;
            }

            if (yapılacakIslem == "/")
            {
                sonuc = sayi1 / sayi2;
            }

            Console.WriteLine( "Yaptığınız işlemin sonucu:" + sonuc);


            goto Tekrar;


















        }
    }
}

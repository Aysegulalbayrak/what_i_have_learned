using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersBasariHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
        /* Vize, final ve odev notlarını klavyeden alalım
         * Vizenin ->%30
         * Finalin ->%40
         * Odevin -> %30  
         * ortalamaya etkilemektedir.
         *
         * Ortalama 40 dan düşükse dersten başarısız oldun seneye tekrar al.
         * Ortalama 40 ve 60 arasında Büte girebilirsiniz
         * Ortalama 60 ve üzeri ise dersten başarılı densin..
         *
         * Sonucu ortalama ile birlikte ekrana bassın.
         *
         * Örneğin : Ortalmanız 54.5  Büte girebilirsiniz...
         */

        Tekrar:
            Console.WriteLine("Vize notunuzu giriniz: ");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final notunuzu giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ödev notunuzu giriniz: ");
            int odev = Convert.ToInt32(Console.ReadLine());

            double ort;
            ort = vize * 30.0 / 100 + final * 40.0 / 100 + odev * 30.0 / 100;

            if (ort < 40)
            {
                Console.WriteLine("Dersten başarısız oldun seneye tekrar al.");

            }

            else if (ort>40 && ort <60)
            {
                Console.WriteLine("Büte girebilirsiniz.");
            }

            else
            {
                Console.WriteLine("Dersi başarıyla geçtin.");
            }

            goto Tekrar;


        }


    }
}

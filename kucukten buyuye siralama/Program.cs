using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kucukten_buyuye_siralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği 10 sayıyı küçükten büyüğe sıralayan programı yazınız.

            int[] dizi = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sayı Giriniz");
                dizi[i] = int.Parse(Console.ReadLine());
            }
            int gecici;
            for (int i = 0;i < 10;i++)
            {
                for (int j = i+1;  j < 10;j++)
                {
                    if (dizi[i] > dizi[j])
                    {
                        gecici = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadLine();
        }
    }
}

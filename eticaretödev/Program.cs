using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticaretödev
{
    internal class Program
    {
        
        
            static void yıldızla(List<int> yıldız)
            {
                while (true)
                {
                    Console.WriteLine("1-5 ARASINDA YILDIZLAYIN");
                    int yıldızver = Convert.ToInt32(Console.ReadLine());
                    if (yıldızver > 0 && yıldızver < 6)
                    {
                        yıldız.Add(yıldızver);
                        break;
                    }
            }
        }
        static void yorum_yaz(List<string> yorumlar)
        {
            string yorum = Console.ReadLine();
            yorumlar.Add(yorum);
        }
        static void yorum_oku(List<string> yorumlar)
        {
            foreach (string item in yorumlar)
            {
                Console.WriteLine(item + "\n");
            }
        }
        static string yıldızpuanı(List<int> yıldız)
        {
            int sayi = 0;
            foreach (int item in yıldız)
            {
                sayi += item;
            }
            double cevap = (double)sayi / (double)(yıldız.Count);
            cevap.ToString();
            return "ortalama puan" + cevap + "\t\t" + yıldız.Count + "adet kişi puanladı";
        }
        static void Main(string[] args)
        {
            string cizgi = new string('-', 20);
            List<int> yıldız = new List<int>();
            List<string> yorumlar = new List<string>();
            while (true)
            {
                Console.WriteLine("1-puan ver\n2-yorum yap\n3-puan göster\n4-yorum göster");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        yıldızla(yıldız);
                        break;
                    case "2":
                        yorum_yaz(yorumlar);
                        break;
                    case "3":
                        Console.WriteLine(yıldızpuanı(yıldız));
                        break;
                    case "4":
                        yorum_oku(yorumlar);
                        break;

                    default:
                        Console.WriteLine("Hatalı Tuşlama");
                        break;
                }
                Console.WriteLine(cizgi);
            }
        }
    }
}

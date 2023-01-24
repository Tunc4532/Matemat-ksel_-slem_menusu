using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematiksel_işlem_menusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            char s='e';
            do
            {

                Console.WriteLine("********** Matematiksel işlem menüsü **********");
                Console.WriteLine(" MENÜ ");
                Console.WriteLine("1-Aritmrtik dört  işlem");
                Console.WriteLine("2-Üs alma");
                Console.WriteLine("3-Kök alma");
                Console.WriteLine("4-Karenin çevre ve alan hesabı");
                Console.WriteLine("5-Dikdörtkende Alan ve Çevre Hesabı");
                Console.WriteLine("6-Eşkanar üçkende çevre\n");

                Console.WriteLine("************************************************\n");

                Console.Write("İşlem yapmak istediğiniz alan: ");
                sayı = Convert.ToInt16(Console.ReadLine());
                if (sayı == 1)
                {
                    int a, b, toplam, fark, bölüm, çarp;
                    Console.Write("Birinci sayııyı giriniz: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("İkinci sayıyı giriniz: ");
                    b = Convert.ToInt16(Console.ReadLine());

                    toplam = a + b;
                    çarp = a * b;
                    fark = a - b;
                    bölüm = a / b;

                    Console.WriteLine("Toplam: " + toplam);
                    Console.WriteLine("Çarpımı: " + çarp);
                    Console.WriteLine("Farkı: " + fark);
                    Console.WriteLine("Bölümü: " + bölüm);
                }
                if (sayı == 2)
                {
                    double a, üs, sonuç;
                    Console.Write("Sayıyı giriniz: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Üs girin: ");
                    üs = Convert.ToDouble(Console.ReadLine());

                    sonuç = Math.Pow(sayı, a);

                    Console.WriteLine("sonuç=" + sonuç);

                }
                if (sayı == 3)
                {
                    double b, kök;
                    Console.Write("Kökü Alınacak sayıyı giriniz: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    kök = Math.Sqrt(b);
                    Console.Write("sonuç: " + kök);
                }
                if (sayı == 4)
                {
                    int kenar, alan, çevre;
                    Console.Write("Kenar değeri: ");
                    kenar = Convert.ToInt16(Console.ReadLine());

                    alan = kenar * kenar;
                    çevre = kenar * 4;
                    Console.WriteLine("Alanı: " + alan);
                    Console.WriteLine("Çevresi: " + çevre);
                }
                if (sayı == 5)
                {
                    int kısakenar, uzunkenar, çevredik, alandik;
                    Console.Write("kısa kenarı giriniz: ");
                    kısakenar = Convert.ToInt16(Console.ReadLine());
                    Console.Write("uzun kenarı giriniz: ");
                    uzunkenar = Convert.ToInt16(Console.ReadLine());


                    çevredik = (kısakenar * 2) + (uzunkenar * 2);
                    alandik = kısakenar * uzunkenar;

                    Console.WriteLine("Çevresi: " + çevredik);
                    Console.WriteLine("Alanı: " + alandik);
                }
                if (sayı == 6)
                {
                    double kenar, cevre;
                    Console.Write("Kenar değerini giriniz: ");
                    kenar = Convert.ToDouble(Console.ReadLine());
                    cevre = kenar * 3;
                    Console.WriteLine("sonuç: " + cevre);
                }
                else if (sayı > 6)
                {
                    Console.WriteLine("Hatalı işlem seçimi lütfen tekrar dneyiniz!");
                }
                else if (sayı < 1)
                {
                    Console.WriteLine("Hatalı işlem seçimi lütfen tekrar dneyiniz!");
                }

                Console.WriteLine("Başka bir işlem yapmak istiyosanız e programı kapatmak için x basınız");
                s = Convert.ToChar(Console.ReadLine());

            } while (s == 'e' || s == 'E');
            Console.Read();
        }
    }
}

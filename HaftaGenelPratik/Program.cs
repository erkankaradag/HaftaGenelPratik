
//------------------------------------------------------------ ÇIKTI YAZAN PROGRAM-----------------------------------------------------------------------------------------

/*
using System;
namespace Pratik1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello How Are You?");
            Console.WriteLine("I am good how are you?");
        }
    }
}

*/


//-------------------2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız. -------------------------

/*
 using System;
namespace Pratik2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Ahmet Ali CENGİZ";
            int age = 18;
            Console.WriteLine($"Hello I am {fullName}. {age} years old.");
        }
    }
}

*/


//-----------------------------------------------------------------3 - Rastgele bir sayı üretip , ekrana yazdırınız.---------------------------------------------------------------------------


/*
using System;
namespace Pratik3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 11);
            Console.WriteLine(number);
        }
    }
}
*/

//---------------------------------4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.---------------------------------------------------------------------------

/*
using System;
namespace Pratik4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double Random = rnd.Next(1,50);
            double kalan = (Random % 3);
            Console.WriteLine($"Random Number: {Random}");
            Console.WriteLine($"Remainder of division by 3: {kalan}");
        }
    }
}
*/

//---------------------------------5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.---------------------------------------------------------------------

/*
using System;
namespace Pratik5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            byte age = Convert.ToByte(Console.ReadLine());
            if (age >= 18 )
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
*/

//------------------------6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.---------------------------------------------


/*
using System;
namespace Pratik6
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
                counter++;
            }
        }
    }
}
*/

//-------------------------------7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.-----------------------------------------

/*
using System;
namespace Pratik7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci değeri girin: ");
            string firstString = Console.ReadLine();
            Console.WriteLine($"Birinci değer: {firstString}");

            Console.WriteLine("Lütfen ikinci değeri girin: ");
            string secondString = Console.ReadLine();
            Console.WriteLine($"İkinci değer: {secondString}");

            Console.WriteLine($"Girinlen değerler ve sırası: {firstString} , {secondString} ");
            (firstString, secondString) = (secondString, firstString);
            Console.WriteLine($"Değiştirme sonrası: {firstString}, {secondString} ");
        }
    }
}
*/


//---------------------------------------------8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. --------------------------------------------------------------


/*
 
using System;
namespace Pratik8

class Program
{
    // Değer döndürmeyen bir metot
    static void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma!");
    }

    static void Main(string[] args)
    {
        // Metodu çağırıyoruz
        BenDegerDondurmem();
    }
}
*/

//-------------------------------------------------9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.-----------------------------------------------------


/*
using System;
namespace Pratik9

 class Program
{
    static int Topla(int num1, int num2)
    {
        return num1 + num2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen birinci sayıyı girin: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Lütfen ikinci sayıyı girin: ");
        int num2 = int.Parse(Console.ReadLine());   

        int Toplam = Topla(num1, num2);
        Console.WriteLine($"Girilen sayıların toplamı: {Toplam}");
    }
}
*/



//-------------------------------------------10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.-----------------------------------------------


/*
using System;

namespace Pratik10
{
    class Program
    {
        // Kullanıcıdan true/false alıp string mesaj döndüren metot
        static string DurumNe(bool durum)
        {
            if (durum)
            {
                return "Durum: Doğru";
            }
            else
            {
                return "Durum: Yanlış";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 'true' ya da 'false' yazınız: ");
            string input = Console.ReadLine(); // Kullanıcıdan girdi alınır

            bool durum;
            if (bool.TryParse(input, out durum)) // Girdi true/false'a dönüştürülür
            {
                // Durum mesajını al
                string mesaj = DurumNe(durum);
                Console.WriteLine(mesaj); // Mesajı ekrana yazdır
            }
            else
            {
                Console.WriteLine("Geçersiz bir giriş yaptınız. Lütfen 'true' ya da 'false' giriniz.");
            }
        }
    }
}

*/


//------------------------------------------ 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.-----------------------------------------------


/*

using System;
namespace Pratik11
{
    class Program
    {
        // En yaşlı kişiyi döndüren metot
        static int EnYasli(int yas1, int yas2, int yas3)
        {
            // En büyük yaşı döndürüyoruz
            return Math.Max(yas1, Math.Max(yas2, yas3));
        }
        static void Main(string[] args)
        {
            // Kullanıcıdan yaş bilgilerini alıyoruz
            Console.Write("Birinci kişinin yaşını girin: ");
            int yas1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci kişinin yaşını girin: ");
            int yas2 = int.Parse(Console.ReadLine());

            Console.Write("Üçüncü kişinin yaşını girin: ");
            int yas3 = int.Parse(Console.ReadLine());

            // En yaşlıyı buluyoruz
            int enYasli = EnYasli(yas1, yas2, yas3);

            // Sonucu ekrana yazdırıyoruz
            Console.WriteLine("En yaşlı kişi: " + enYasli);
        }
    }
}

*/

//------------------12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.-------------------------------


/*
  
 
using System;

namespace Pratik12
{
    class Program
    {
        // En büyük sayıyı döndüren metot
        static int EnBuyukSayiyiBul()
        {
            int enBuyuk = int.MinValue;  // Başlangıçta en büyük sayıyı çok küçük bir değerle başlatıyoruz.

            while (true)
            {
                Console.Write("Bir sayı girin (Çıkmak için 'q' tuşuna basın): ");
                string input = Console.ReadLine();

                // Kullanıcı çıkmak isterse döngüyü sonlandırıyoruz.
                if (input.ToLower() == "q")
                    break;

                // Kullanıcı geçerli bir sayı girerse işleme devam ediyoruz.
                if (int.TryParse(input, out int sayi))
                {
                    // En büyük sayıyı buluyoruz.
                    if (sayi > enBuyuk)
                    {
                        enBuyuk = sayi;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
                }
            }

            return enBuyuk;  // En büyük sayıyı geri döndürüyoruz.
        }

        static void Main()
        {
            int enBuyukSayi = EnBuyukSayiyiBul();  // En büyük sayıyı buluyoruz.
            Console.WriteLine("Girdiğiniz en büyük sayı: " + enBuyukSayi);
        }
    }
}

*/


//------------------------------------13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.----------------------------------------------

/* 
 
 
using System;

namespace Pratik13
{
    class Program
    {
        // İki ismin yerlerini değiştiren metot
        static void IsimleriDegistir(ref string isim1, ref string isim2)
        {
            string temp = isim1;  // isim1'i geçici bir değişkende saklıyoruz.
            isim1 = isim2;        // isim1'i isim2'nin değeriyle değiştiriyoruz.
            isim2 = temp;         // isim2'yi geçici değişkenin değeriyle değiştiriyoruz.
        }

        static void Main()
        {
            // Kullanıcıdan iki isim alıyoruz
            Console.Write("Birinci ismi girin: ");
            string isim1 = Console.ReadLine();

            Console.Write("İkinci ismi girin: ");
            string isim2 = Console.ReadLine();

            // İsimlerin yerlerini değiştiriyoruz
            IsimleriDegistir(ref isim1, ref isim2);

            // Sonuçları ekrana yazdırıyoruz
            Console.WriteLine("Yer değiştiren isimler:");
            Console.WriteLine("Birinci isim: " + isim1);
            Console.WriteLine("İkinci isim: " + isim2);
        }
    }
}

*/


//------------------------------------14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.----------------------------------------------

/*
  
 
 using System;

class Program
{
    // Sayının tek mi çift mi olduğunu kontrol eden metot
    static bool TekMiCiftMi(int sayi)
    {
        return sayi % 2 == 0;  // Sayı çiftse true, tekse false döner
    }

    static void Main()
    {
        // Kullanıcıdan bir sayı alıyoruz
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        // Sayının tek mi çift mi olduğunu kontrol ediyoruz
        bool sonuc = TekMiCiftMi(sayi);

        // Sonucu ekrana yazdırıyoruz
        if (sonuc)
        {
            Console.WriteLine("Girilen sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tektir.");
        }
    }
}


*/

//----------------------------------------15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.---------------------------------------------

/*

using System;

class Program
{
    // Hız ve zaman bilgileriyle gidilen yolu hesaplayan metot
    static double YolHesapla(double hiz, double zaman)
    {
        return hiz * zaman;  // Yol = Hız * Zaman
    }

    static void Main()
    {
        // Kullanıcıdan hız ve zaman bilgilerini alıyoruz
        Console.Write("Hızı (km/saat cinsinden) girin: ");
        double hiz = double.Parse(Console.ReadLine());

        Console.Write("Zamanı (saat cinsinden) girin: ");
        double zaman = double.Parse(Console.ReadLine());

        // Gidilen yolu hesaplıyoruz
        double yol = YolHesapla(hiz, zaman);

        // Sonucu ekrana yazdırıyoruz
        Console.WriteLine("Gidilen yol: " + yol + " kilometre");
    }
}

*/


//----------------------------------------------16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.----------------------------------------------------

/*
 
using System;

class Program
{
    // Yarıçap ile dairenin alanını hesaplayan metot
    static double AlanHesapla(double yaricap)
    {
        return Math.PI * yaricap * yaricap;  // Alan = π * r^2
    }

    static void Main()
    {
        // Kullanıcıdan yarıçap bilgisini alıyoruz
        Console.Write("Dairenin yarıçapını girin: ");
        double yaricap = double.Parse(Console.ReadLine());

        // Dairenin alanını hesaplıyoruz
        double alan = AlanHesapla(yaricap);

        // Sonucu ekrana yazdırıyoruz
        Console.WriteLine("Dairenin alanı: " + alan);
    }
}

*/

//------------------------------------------17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.--------------------------------------------

/*
 

 using System;

class Program
{
    static void Main()
    {
        // Cümleyi tanımlıyoruz
        string cumle = "Zaman bir GeRi SayIm";
        
        // Cümleyi hepsi büyük harf ile yazdırıyoruz
        Console.WriteLine("Hepsi Büyük Harf: " + cumle.ToUpper());

        // Cümleyi hepsi küçük harf ile yazdırıyoruz
        Console.WriteLine("Hepsi Küçük Harf: " + cumle.ToLower());
    }
}

*/


//-------------------------------18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.-------------------------------------------

/*
 
 
  using System;

class Program
{
    static void Main()
    {
        // Başında ve sonunda boşluk olan metni bir değişkene atıyoruz
        string metin = "    Selamlar   ";

        // Başındaki ve sonundaki boşlukları siliyoruz
        metin = metin.Trim();

        // Sonucu ekrana yazdırıyoruz
        Console.WriteLine("Temizlenmiş metin: '" + metin + "'");
    }
}

*/

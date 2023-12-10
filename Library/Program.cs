

using System.Security.Cryptography.X509Certificates;

namespace Library;
using System;
using System.Xml.Linq;



public class Program
{
    private static Kutuphane _kutuphane = new Kutuphane();

    public static void Main(String[] args)
    {

        AnaMenu();
    }

    public static void AnaMenu()
    {
        Console.WriteLine("Kutuphanemize hosgeldiniz");
        Console.WriteLine("Ne yapmak istiyorsunuz? (Cikmak icin -1'e basin)");
        Console.WriteLine("1. Kitap Ekleme");
        Console.WriteLine("2. Kitap Silme");
        Console.WriteLine("3. Kullanici Uye Yapma");
        Console.WriteLine("4. Tum Kitaplari Listeleme");
        Console.WriteLine("5. Kitap Odunc Verme");

        int secenek = int.Parse(Console.ReadLine());

        while (secenek != -1)
        {
            while (secenek < 1 || secenek > 5)
            {
                Console.WriteLine("\nGecersiz Secenek");
                Console.WriteLine("1. Kitap Ekleme");
                Console.WriteLine("2. Kitap Silme");
                Console.WriteLine("3. Kullanici Uye Yapma");
                Console.WriteLine("4. Tum Kitaplari Listeleme");
                Console.WriteLine("5. Kitap Odunc Verme");

                secenek = int.Parse(Console.ReadLine());

                if (secenek == -1)
                    break;
            }

            if (secenek == -1)
                break;

            switch (secenek)
            {
                case 1:
                    KitapEklemeMenusu();
                    break;

                case 2:
                    KitapSilmeMenusu();
                    break;

                case 3:
                    KullaniciUyeYapmaMenusu();
                    break;

                case 4:
                    TumKitaplariListelemeMenusu();
                    break;
                case 5:
                    OduncVermeMenusu();
                    break;
            }

            Console.WriteLine("\nKutuphanemize hosgeldiniz");
            Console.WriteLine("Ne yapmak istiyorsunuz? (Cikmak icin -1'e basin)");
            Console.WriteLine("1. Kitap Ekleme");
            Console.WriteLine("2. Kitap Silme");
            Console.WriteLine("3. Kullanici Uye Yapma");
            Console.WriteLine("4. Tum Kitaplari Listeleme");
            Console.WriteLine("5. Kitap Odunc Verme");

            secenek = int.Parse(Console.ReadLine());
        }
    }

    private static void OduncVermeMenusu()
    {
        Console.WriteLine("\nKitap Odunc Verme");
        Console.WriteLine("Uyenin Indeksi. ");
        int uye = int.Parse(Console.ReadLine());
        Console.WriteLine("Kitabin Indeksi: ");
        int kitap = int.Parse(Console.ReadLine());

        if(uye > _kutuphane.Uyeler.Count || uye < 0 || kitap >= _kutuphane.Kitaplar.Count || kitap < 0 || _kutuphane.Kitaplar[kitap].OduncMu == true )
        {
            Console.WriteLine("Gecersiz islem");
            return;
        }

        if (_kutuphane.Kitaplar[kitap].OduncMu == true)
        {
            Console.WriteLine("\nKitap zaten odunc verilmis durumda.");
            return;
        }

        _kutuphane.Oduncler.Add(new Odunc(_kutuphane.Uyeler[uye], _kutuphane.Kitaplar[kitap], DateTime.Now));
        _kutuphane.Kitaplar[kitap].OduncMu = true;

    }

    private static void TumKitaplariListelemeMenusu()
    {
        Console.WriteLine("\nKitaplar");

        for (int i = 0; i < _kutuphane.Kitaplar.Count; i++)
        {
            Console.Write((i + 1) + ":");
            _kutuphane.Kitaplar[i].Yazdir();
        }
    }

    private static void KitapSilmeMenusu()
    {
        Console.WriteLine("\nKitap Silme");
    }

    private static void KullaniciUyeYapmaMenusu()
    {
        Console.WriteLine("\nKullanici Uye Yapma");
        Console.WriteLine("Kullanici ismi: ");
        string isim = Console.ReadLine();
        Console.WriteLine("TC Kimlik No: ");
        int tc = int.Parse(Console.ReadLine());

        _kutuphane.Uyeler.Add(new Uye(isim, tc));
    }

    public static void KitapEklemeMenusu()
    {
        Console.WriteLine("\nKitap Ekleme");
        Console.Write("Kitabin ismi: \n");
        string isim = Console.ReadLine();
        Console.Write("Kitabin yazari: \n");
        string yazar = Console.ReadLine();
        Console.Write("Kitabin basim yili: \n");
        int basimYili = int.Parse(Console.ReadLine());

        _kutuphane.Kitaplar.Add(new Kitap(isim, yazar, basimYili));
    }
}
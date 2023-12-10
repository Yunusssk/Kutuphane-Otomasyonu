using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Kutuphane
{
    public List<Kitap> Kitaplar { get; }
    public List<Uye> Uyeler { get; }
    public List<Odunc> Oduncler { get; }

    public Kutuphane()
    {
        Kitaplar = new List<Kitap>();
        Uyeler = new List<Uye>();
        Oduncler = new List<Odunc>();

        KitapEkle();
        UyeEkle();
    }
    
    public void KitapEkle()
    {
        Kitaplar.Add(new Kitap("ABC", "Murat", 1987));
        Kitaplar.Add(new Kitap("DEF", "Mehmet", 1988));
        Kitaplar.Add(new Kitap("GHJ", "Mustafa", 1989));
        Kitaplar.Add(new Kitap("KLM", "Ayse", 1990));
        Kitaplar.Add(new Kitap("PRS", "Yunus", 2005));

    }

    public void UyeEkle()
    {
        Uyeler.Add(new Uye("Maradona", 12345678));
        Uyeler.Add(new Uye("Yunus", 11223344));
        Uyeler.Add(new Uye("Yusuf", 45363880));
    }


}

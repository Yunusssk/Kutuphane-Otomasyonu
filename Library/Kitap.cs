using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Kitap
{
    public string Isim { get; } = "Isimsiz";
    public string Yazar { get; } = "Isimsiz";
    public int BasimYili { get; } = 2023;
    public bool OduncMu { get; set; } 

    public Kitap(string isim, string yazar, int basimYili)
    {
        Isim = isim;
        Yazar = yazar;
        BasimYili = basimYili;
        OduncMu = false;
    }
    public void Yazdir()
    {
        Console.WriteLine(Isim + "," + Yazar + "," + BasimYili + ".");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Uye
{
    public string Isim { get; }
    public int TC { get; }

    public Uye (string ısim, int tC)
    {
        Isim = ısim;
        TC = tC;
    }

    public void Yazdir()
    {
        Console.WriteLine(Isim + "," + TC + ".");
    }
}

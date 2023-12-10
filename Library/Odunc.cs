using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Odunc
{
    public Uye OduncUye { get; }
    public Kitap OduncKitap { get; }
    public DateTime Baslangic { get; }
    public DateTime Bitis {  get; }

    private const int ODUNC_SURESİ = 15;
    public Odunc(Uye oduncUye, Kitap oduncKitap, DateTime baslangic)
    {
        OduncUye = oduncUye;
        OduncKitap = oduncKitap;
        Baslangic = baslangic;
        Bitis = baslangic.AddDays(ODUNC_SURESİ); //Odunc verme suresi 15 gunc.
    }
}

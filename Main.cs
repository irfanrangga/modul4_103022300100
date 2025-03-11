using System.Xml.Serialization;
using modul4_103022300100;

public class MainClass
{
    public static void Main(string[] args)
    {
        //kodeProduk kp = new kodeProduk();
        //Console.WriteLine("Kode produk laptop: " + kp.getKodeProduk(kodeProduk.Produk.Laptop));
        //Console.WriteLine("Kode produk kamera: " + kp.getKodeProduk(kodeProduk.Produk.Kamera));

        FanLaptop fl = new FanLaptop();

        fl.activateTrigger(FanLaptop.Trigger.ModeUp);
        fl.activateTrigger(FanLaptop.Trigger.ModeDown);
        fl.activateTrigger(FanLaptop.Trigger.TurboShortcut);
    }
}
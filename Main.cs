using System.Xml.Serialization;
using modul4_103022300100;

public class MainClass
{
    public static void Main(string[] args)
    {
        string produk = kodeProduk.getKodeProduk(kodeProduk.Produk.Smartphone);
        Console.WriteLine("Kode Produk adalah: " + produk);
    }
}
using SayiTahminEtme.Models;
using SayiTahminEtme.Services;

namespace SayiTahminEtme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu = new Oyuncu();
            Console.Write("Kullanıcı Adı: ");
            oyuncu.Kullanici = Console.ReadLine();





            SayiTahminEtmeServices servis = new SayiTahminEtmeServices();
            Console.Write("Sayı Giriniz  Çıkış(ç):  ");
            string giris = Console.ReadLine();
            string sonuc;

            while (giris != "ç" )
            {
                Console.WriteLine($"Oyuncu: {oyuncu.Kullanici}");
                Console.WriteLine(servis.Oyna(Convert.ToInt32(giris), oyuncu.Kullanici));
                Console.Write("Sayı Giriniz:  ,  Çıkış(ç):  ");
                giris = Console.ReadLine();
            }
        }
    }
}
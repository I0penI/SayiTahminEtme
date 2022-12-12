namespace SayiTahminEtme.Services
{
    class SayiTahminEtmeServices
    {
        int[] _sayilar = new int[11]
        {
            0, 1, 2 , 3, 4, 5, 6, 7, 8, 9, 10
        };
        Random _rastgele = new Random();
        public int SayiSec()
        {

            int rastgeleIndex = _rastgele.Next(0, 11);
            return rastgeleIndex;

        }
        public string Oyna(int kullaniciSayiIndex, string kullanici = "Kullanıcı")
        {
            int bilgisayarSayiIndex = SayiSec();
            return $"{kullanici} : {_sayilar[kullaniciSayiIndex]}\n" +
                 //  $"Bilgisayar: {_sayilar[bilgisayarSayiIndex]} \n" +
                   $"Sonuç: {SonucBul(bilgisayarSayiIndex, kullaniciSayiIndex, kullanici)} ";
                   
        }

        public string SonucBul (int bilgisayarSayiIndex, int kullaniciSayiIndex, string rumuz)
        {
            string sonuc = "";
            
            if (kullaniciSayiIndex == bilgisayarSayiIndex)
                sonuc = "Bildiniz!!";
            if ((kullaniciSayiIndex < bilgisayarSayiIndex) || (kullaniciSayiIndex > bilgisayarSayiIndex))
                sonuc = "Uzaksınız";
            return sonuc;



        }
    }


}


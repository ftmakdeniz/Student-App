using System.Net.Http.Headers;

namespace studentApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool kontrol=true;
            student ogr = new student("Fatma", "AKDENİZ",18,0451120116,45,60,10, "Istanbul Universitesi");
            Console.WriteLine("Programımıza Hoş Geldiniz Bir seçim Yapınız.");
            islemlerigöster();
            while (kontrol)
            { 
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        ogr.OgrenciBilgileriGöster(); 
                        break;
                        case "2":
                        double OgrenciOrtalama = ogr.NotHesabi();
                        if (OgrenciOrtalama<50)
                        {
                            Console.WriteLine( "Kaldınız");
                        }
                        else
                        {
                            Console.WriteLine("Geçtiniz");
                        }
                        break;
                        case "3":
                        ogr.OkulGetir();
                        break;
                        case "4":
                        kontrol = false;
                        break;
                }
            }


        }
        static void islemlerigöster()
        {
            Console.WriteLine("1-Ogrenci Bilgilerini Göster");
            Console.WriteLine("2-Ogrenci Ortalamasi");
            Console.WriteLine("3-Ogrencinin Okul");
            Console.WriteLine("4-Programdan Çık");
        }
    }

}
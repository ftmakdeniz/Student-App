using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace studentApp
{
    public class student
    {
        private string Adi { get; set; }
        private string Soyadi { get; set; }
        private string OkulIsmi { get; set; }
        private int Yasi { get; set; }
        private int OgrenciNumarasi { get; set; }
        private double Vize1 { get; set; }  //20
        private double Vize2 { get; set; }   //20
        private double Final { get; set; }   //60

        public student(string _adi, string _soyadi, int _yasi, int _ogrencinumarasi, double _vize1, double _vize2, double _final ,string _okulismi)
        {
            Adi = _adi;
            Soyadi = _soyadi;
            Yasi = _yasi;
            OgrenciNumarasi = _ogrencinumarasi;
            Vize1 = _vize1;
            Vize2 = _vize2;
            Final = _final;
            OkulIsmi= _okulismi;
//consturucter 
        }

        public double NotHesabi()
        {
            double ortalama = Vize1 * 0.2 + Vize2 * 0.2 + Final * 0.6;
            return ortalama;
        }
        public void OkulGetir()
        {
            Console.WriteLine("student school :"+ OkulIsmi );
        }
        public void OgrenciBilgileriGöster()
        {
            Console.WriteLine("ogrenci Numarasi:" + OgrenciNumarasi);
            Console.WriteLine("ogrencinin adı:" + Adi);
            Console.WriteLine("ogrencinin Soyadı:" + Soyadi);
            Console.WriteLine("Vize1:" + Vize1);
            Console.WriteLine("Vize2:" + Vize2);
            Console.WriteLine("Final:" + Final);
        }
            
    }
}

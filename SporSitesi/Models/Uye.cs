using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SporSitesi.Models
{
    public class Uye
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumGunu { get; set; }
        public DateTime KatilmaTarihi { get; set; }
        public string Eposta { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public double VucutKitleEndeksi
        {
            get
            {
                return Kilo / (Boy * Boy);
            }
        }
        public double? YagOrani { get; set; }
        public double? KasOrani { get; set; }

    }
    public enum Cinsiyet
    {
        erkek,
        kadin,
        belirtmekIstemiyor
    }

}

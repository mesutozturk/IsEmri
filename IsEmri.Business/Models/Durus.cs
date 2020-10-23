using System;

namespace IsEmri.Business.Models
{
    public class Durus
    {
        public string Neden { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public int Sure => (Bitis - Baslangic).Minutes;
    }
}

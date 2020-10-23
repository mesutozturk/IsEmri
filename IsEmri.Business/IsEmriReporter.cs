using System;
using IsEmri.Business.Models;
using System.Collections.Generic;
using System.Linq;

namespace IsEmri.Business
{
    public class IsEmriReporter
    {
        private readonly string[] _nedenTipleri = new[] { "Mola", "Arıza", "Setup", "Arge", "X durum" }; //Burası çoğaltılabilir.
        private readonly int[] _sureler = new[] { 10, 30, 90, 570, 45 }; // yukarıdaki indexlerle eşlenen süreler. mola için 10dk. Arge süresini sabit verdim.
        public List<Emir> Emirler { get; set; } = new List<Emir>();
        public List<Durus> Duruslar { get; set; } = new List<Durus>();
        public string Text { get; set; }
        public List<PivotModel> ListPivotModel { get; set; } = new List<PivotModel>();

        public IsEmriReporter()
        {
            VeriUret();
            Hesapla();
        }
        private void Hesapla()
        {
            var raporAggs = new List<RaporAggregator>();
            foreach (var emir in Emirler)
            {
                var vm = new RaporAggregator
                {
                    Kod = emir.Kod,
                    Duruslar = Duruslar
                        .Where(x => x.Baslangic >= emir.Baslangic)
                        .ToList()
                };
                raporAggs.Add(vm);
            }

            //buraya kadar her duruş hangi iş emrinde onları ayarladık

            foreach (var item in raporAggs)
            {
                var arge = item.Duruslar.FirstOrDefault(x => x.Neden == "Arge")?.Sure;
                var mola = item.Duruslar.FirstOrDefault(x => x.Neden == "Mola")?.Sure;
                var arıza = item.Duruslar.FirstOrDefault(x => x.Neden == "Arıza")?.Sure;
                var setup = item.Duruslar.FirstOrDefault(x => x.Neden == "Setup")?.Sure;
                var xDurum = item.Duruslar.FirstOrDefault(x => x.Neden == "X durum")?.Sure;
                var lpm = new PivotModel()
                {
                    Kod = item.Kod,
                    Arge = arge.GetValueOrDefault(),
                    Arıza = arıza.GetValueOrDefault(),
                    Mola = mola.GetValueOrDefault(),
                    Setup = setup.GetValueOrDefault(),
                    XDurum = xDurum.GetValueOrDefault(),
                    Toplam = item.ToplamSure
                };
                ListPivotModel.Add(lpm);
            }
            //genel toplam hesaplama
        }

        private void VeriUret()
        {
            var tarih = new DateTime(2017, 1, 1, 8, 0, 0);
            var kod = 1001;
            for (int i = 0; i < 20; i++) //20 tane iş emri üretimi
            {
                var yeniEmir = new Emir()
                {
                    Kod = kod + i,
                    Baslangic = tarih,
                };
                tarih = tarih.AddHours(8); //örnekte 8 saatlik iş emirleri bulunmaktaydı
                yeniEmir.Bitis = tarih;
                Emirler.Add(yeniEmir);
            }

            var rnd = new Random();
            tarih = new DateTime(2017, 1, 1, 8, 0, 0);

            for (DateTime i = tarih; i.Day <= Emirler.Last().Bitis.Day; i = i.AddDays(1)) // üretilen emir günlerini tek tek dönen döngü
            {
                //her gün için 5 ile 10 arası random duruş nedenleri eklenecek.
                var adet = rnd.Next(5, 10);
                for (int j = 0; j < adet; j++)
                {
                    var index = rnd.Next(_nedenTipleri.Length); //hangi neden seçildi

                    var gunIciRandomSaat = rnd.Next(0, 24);
                    var gunIciRandomDakika = rnd.Next(0, 60);

                    var durusTarihi = new DateTime(i.Year, i.Month, i.Day, gunIciRandomSaat, gunIciRandomDakika, 0);

                    var durus = new Durus()
                    {
                        Neden = _nedenTipleri[index],
                        Baslangic = durusTarihi,
                        Bitis = durusTarihi.AddMinutes(_sureler[index])
                    };

                    if (durus.Baslangic < Emirler.First().Baslangic || durus.Bitis > Emirler.Last().Bitis)
                        continue; //eğer random eklenen durus bitiş tarihinden ileri veya geri ise eklenmesin

                    Duruslar.Add(durus);
                }
            }

            Duruslar = Duruslar.OrderBy(x => x.Baslangic).ToList();//baslangic tarihlerine göre sıralandı

            this.Text = $"Toplam: {Emirler.Count} iş emri, {Duruslar.Count} duruş listelenmiştir.";
        }
    }
}

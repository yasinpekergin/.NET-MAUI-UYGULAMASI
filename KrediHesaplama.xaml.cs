using Microsoft.Maui.Controls;

namespace Odev1
{
    public partial class KrediHesaplamaPage : ContentPage
    {
        public KrediHesaplamaPage()
        {
            InitializeComponent();
        }

        private void Button_Hesapla_Clicked(object sender, EventArgs e)
        {
            double krediTutari = double.Parse(KrediTutariEntry.Text);
            double faizOrani = double.Parse(FaizOraniEntry.Text);
            double vadeSuresi = double.Parse(VadeSuresiEntry.Text);

            double aylikFaizOrani = faizOrani / 1200; // % cinsinden faiz oranýný aylýk faiz oranýna çevirir
            double aylikOdeme = (krediTutari * aylikFaizOrani) / (1 - Math.Pow(1 + aylikFaizOrani, -vadeSuresi));
            double toplamOdeme = aylikOdeme * vadeSuresi;

            AylikOdemeLabel.Text = aylikOdeme.ToString("C2");
            ToplamOdemeLabel.Text = toplamOdeme.ToString("C2");
        }
    }
}

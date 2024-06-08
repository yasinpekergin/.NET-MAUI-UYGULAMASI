using Microsoft.Maui.Controls;

namespace Odev1
{
    public partial class VucutKitleIndeksiPage : ContentPage
    {
        public VucutKitleIndeksiPage()
        {
            InitializeComponent();
        }

        private void Button_Hesapla_Clicked(object sender, EventArgs e)
        {
            double boy = double.Parse(BoyEntry.Text);
            double kilo = double.Parse(KiloEntry.Text);

            double boyMetre = boy / 100; // cm cinsinden boyu metre cinsine çevirir
            double vki = kilo / (boyMetre * boyMetre);

            VKILabel.Text = vki.ToString("F2");
        }
    }
}

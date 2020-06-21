using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AmicusBread
{
    public partial class MainPage : ContentPage
    {
        public Xamarin.Forms.Color BorderColor { get; set; }
        public MainPage()
        {
            InitializeComponent();

            slider1.Value = 12;
            slider2.Value = 1;
            slider3.Value = 1;
            slider4.Value = 1;
            slider5.Value = 1;
            slider6.Value = 1;
            slider7.Value = 1;
            slider8.Value = 1;
            slider9.Value = 1;
            slider10.Value = 12;
        }

        double total;

        double price1 = 0.75;
        double dozenCost1 = 6;
        double price2 = 3.50;
        double price3 = 3.50;
        double price4 = 3;
        double price5 = 3;
        double price6 = 7;
        double price7 = 7;
        double price8 = 3.50;
        double price9 = 3.50;
        double price10 = 1.25;
        double dozenCost2 = 10;

        double[] order = new double[10];
        List<double> orderRaw = new List<double>();

        void updateTotal()
        {
            orderRaw.Add(slider1.Value);
            orderRaw.Add(slider2.Value);
            orderRaw.Add(slider3.Value);
            orderRaw.Add(slider4.Value);
            orderRaw.Add(slider5.Value);
            orderRaw.Add(slider6.Value);
            orderRaw.Add(slider7.Value);
            orderRaw.Add(slider8.Value);
            orderRaw.Add(slider9.Value);
            orderRaw.Add(slider10.Value);

            for (int i = 0; i < 10; i++)
            {
                order[i] = Math.Floor(orderRaw[i]);
            }

            double numberCookies = Math.Round(slider1.Value);
            double cookieDozens = Math.Floor(numberCookies / 12);
            numberCookies = numberCookies - cookieDozens * 12;

            double numberMacaroons = Math.Round(slider10.Value);
            double macaroonDozens = Math.Floor(numberMacaroons / 12);
            numberMacaroons = numberMacaroons - macaroonDozens * 12;

            total = cookieDozens * dozenCost1 + numberCookies * price1 + Math.Round(slider2.Value) * price2
                + Math.Round(slider3.Value) * price3 + Math.Round(slider4.Value) * price4
                + Math.Round(slider5.Value) * price5 + Math.Round(slider6.Value) * price6
                + Math.Round(slider7.Value) * price7 + Math.Round(slider8.Value) * price8
                + Math.Round(slider9.Value) * price9 + macaroonDozens * dozenCost2 + numberMacaroons * price10;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            updateTotal();
            
            ((Button)sender).Text = $"Total: ${total}";
        }

        private void Reset(object sender, EventArgs e)
        {
            
            slider1.Value = 12;
            slider2.Value = 1;
            slider3.Value = 1;
            slider4.Value = 1;
            slider5.Value = 1;
            slider6.Value = 1;
            slider7.Value = 1;
            slider8.Value = 1;
            slider9.Value = 1;
            slider10.Value = 12;

            updateTotal();

        }
    }
}

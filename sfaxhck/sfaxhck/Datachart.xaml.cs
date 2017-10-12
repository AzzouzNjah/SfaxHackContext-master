using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Entry=Microcharts.Entry;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sfaxhck
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Datachart : ContentPage
    {
        public Datachart()
        {
            InitializeComponent();
            var entries = new[]
            {
                new Entry(212)
                {
                    Label = "Azzouz",
                    ValueLabel = "212",
                    Color = SKColor.Parse("#2c3e50")
                },
                new Entry(248)
                {
                    Label = "Achraf",
                    ValueLabel = "248",
                    Color = SKColor.Parse("#77d065")
                },
               
                new Entry(514)
                {
                    Label = "Daly",
                    ValueLabel = "514",
                    Color = SKColor.Parse("#3498db")
                } };
            var chart1 = new BarChart() { Entries = entries };
            this.chart.Chart = chart1;

            //this.chartView.Chart = chart;

            var chart12 = new RadialGaugeChart() { Entries = entries };
            this.chart1.Chart = chart12;

            var chart13 = new DonutChart() { Entries = entries };
            this.chart2.Chart = chart13;
        }
    }
}
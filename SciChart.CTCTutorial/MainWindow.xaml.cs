using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SciChart.Charting.Model.DataSeries;

namespace SciChart.CTCTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += OnLoaded;
        }
        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            // Create XyDataSeries to host data for our charts
            var scatterData = new XyDataSeries<double, double>();
            var lineData = new XyDataSeries<double, double>();

            for (int i = 0; i < 1000; i++)
            {
                lineData.Append(i, Math.Sin(i * 0.1));
                scatterData.Append(i, Math.Cos(i * 0.1));
            }
            // Assign dataseries to RenderSeries
            LineSeries.DataSeries = lineData;
            ScatterSeries.DataSeries = scatterData;
        }
    }
}

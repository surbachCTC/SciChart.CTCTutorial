using System.Collections.ObjectModel;
using System.Windows.Media;
using SciChart.Charting.Model.ChartSeries;
using SciChart.Charting.Model.DataSeries;
using SciChart.Data.Model;


namespace SciChart.CTCTutorial
{
    // Create the MainViewModel. BindableObject is our own viewmodel base class in scichart. You can use your own!
    public class MainViewModel : BindableObject
    {
        private string _chartTitle = "Hello SciChart World!";
        private string _xAxisTitle = "XAxis";
        private string _yAxisTitle = "YAxis";

        public string ChartTitle
        {
            get { return _chartTitle; }
            set
            {
                _chartTitle = value;
                OnPropertyChanged("ChartTitle");
            }
        }
        public string XAxisTitle
        {
            get { return _xAxisTitle; }
            set
            {
                _xAxisTitle = value;
                OnPropertyChanged("XAxisTitle");
            }
        }
        public string YAxisTitle
        {
            get { return _yAxisTitle; }
            set
            {
                _yAxisTitle = value;
                OnPropertyChanged("YAxisTitle");
            }
        }
    }
}



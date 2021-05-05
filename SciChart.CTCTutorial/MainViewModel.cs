using SciChart.Data.Model;
namespace SciChart.CTCTutorial
{
    // Create the MainViewModel. BindableObject is our own viewmodel base class in scichart. You can use your own!
    public class MainViewModel : BindableObject
    {
        private string _test;
        public MainViewModel()
        {
            TestString = "Hello MVVM World!";
        }
        public string TestString
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropertyChanged("TestString");
            }
        }
    }
}



using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Diagnostics;
using System.Windows.Input;
using MVVM_Test.Model;

namespace MVVM_Test.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private DataStuff currenModel;
        public int Points {
            get { return currenModel.Points; }
            set { currenModel.Points = value; }
        }
        public ICommand HelloCommand { get; private set; }
        public string Navn { get; set; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            HelloCommand = new RelayCommand(Hello,true);
            currenModel = new DataStuff();
        }

        private void Hello()
        {
            ++Points;
            RaisePropertyChanged("");
        }
    }
}
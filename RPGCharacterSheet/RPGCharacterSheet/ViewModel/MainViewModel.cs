using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace RPGCharacterSheet.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand buttonCharacterCreation;
        public MainViewModel()
        {
            buttonCharacterCreation = new RelayCommand(ViewCharacterCreator, true);
        }
        private void ViewCharacterCreator()
        {
            
        }
    }
}
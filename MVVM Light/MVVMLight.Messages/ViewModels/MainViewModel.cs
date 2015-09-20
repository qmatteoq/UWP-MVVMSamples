using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MVVMLight.Messages.Messages;

namespace MVVMLight.Messages.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private RelayCommand _startAnimationCommand;

        public RelayCommand StartAnimationCommand
        {
            get
            {
                if (_startAnimationCommand == null)
                {
                    _startAnimationCommand = new RelayCommand(() =>
                    {
                        Messenger.Default.Send<StartAnimationMessage>(new StartAnimationMessage());
                    });
                }

                return _startAnimationCommand;
            }
        }
    }
}

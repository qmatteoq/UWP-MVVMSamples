using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVMLight.Services.Shared.Services;

namespace MVVMLight.Services.Shared.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IDialogService _dialogService;

        public MainViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { Set(ref _message, value); }
        }

        private RelayCommand _showDialogCommand;

        public RelayCommand ShowDialogCommand
        {
            get
            {
                if (_showDialogCommand == null)
                {
                    _showDialogCommand = new RelayCommand(async () =>
                    {
                        Message = "The button has been clicked";
                        await _dialogService.ShowDialogAsync("Hello world");
                    });
                }

                return _showDialogCommand;
            }
        }
    }
}

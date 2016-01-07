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

        private RelayCommand _showDialogCommand;

        public RelayCommand ShowDialogCommand
        {
            get
            {
                if (_showDialogCommand == null)
                {
                    _showDialogCommand = new RelayCommand(async () =>
                    {
                        await _dialogService.ShowDialogAsync("Hello world");
                    });
                }

                return _showDialogCommand;
            }
        }
    }
}

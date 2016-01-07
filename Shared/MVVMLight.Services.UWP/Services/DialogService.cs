using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using MVVMLight.Services.Shared.Services;

namespace MVVMLight.Services.UWP.Services
{
    public class DialogService : IDialogService
    {
        public async Task ShowDialogAsync(string message)
        {
            MessageDialog dialog = new MessageDialog(message);
            await dialog.ShowAsync();
        }
    }
}

using System.Threading.Tasks;
using Android.App;
using GalaSoft.MvvmLight.Views;
using IDialogService = MVVMLight.Services.Shared.Services.IDialogService;

namespace MVVMLight.Services.Android.Services
{
    public class DialogService : IDialogService
    {
        public async Task ShowDialogAsync(string message)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(ActivityBase.CurrentActivity);

            alert.SetTitle(message);

            alert.SetPositiveButton("Ok", (senderAlert, args) =>
            {

            });

            alert.SetNegativeButton("Cancel", (senderAlert, args) =>
            {
            });
            alert.Show();

            await Task.Yield();
        }
    }
}
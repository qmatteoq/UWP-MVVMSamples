using Android.App;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using MVVMLight.Services.Shared.ViewModels;
using DialogService = MVVMLight.Services.Android.Services.DialogService;
using IDialogService = MVVMLight.Services.Shared.Services.IDialogService;

namespace MVVMLight.Services.Android
{
    [Activity(Label = "MVVMLight.Services.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity: ActivityBase
    {
        public MainViewModel ViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        protected override void OnCreate(Bundle bundle)
        {
            if (!SimpleIoc.Default.IsRegistered<IDialogService>())
            {
                ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
                SimpleIoc.Default.Register<IDialogService, DialogService>();
                SimpleIoc.Default.Register<MainViewModel>();
            }

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
           
            button.SetCommand("Click", ViewModel.ShowDialogCommand);
        }
    }
}


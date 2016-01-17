using Android.App;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;
using MVVMLight.Services.Android.ViewModels;
using MVVMLight.Services.Shared.ViewModels;

namespace MVVMLight.Services.Android
{
[Activity(Label = "MVVMLight.Services.Android", MainLauncher = true, Icon = "@drawable/icon")]
public class MainActivity : ActivityBase
{
    public MainViewModel ViewModel => ViewModelLocator.Main;

    private Button _commandButton;

    public Button CommandButton
        => _commandButton ?? (_commandButton = this.FindViewById<Button>(Resource.Id.MyButton));

    private TextView _messageView;
    public TextView MessageView
        => _messageView ?? (_messageView = this.FindViewById<TextView>(Resource.Id.MessageView));

    private Binding _messageBinding;

    protected override void OnCreate(Bundle bundle)
    {
        base.OnCreate(bundle);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.Main);

        // Get our button from the layout resource,
        // and attach an event to it

        CommandButton.SetCommand("Click", ViewModel.ShowDialogCommand);

        _messageBinding = this.SetBinding(() => ViewModel.Message, () => MessageView.Text, BindingMode.OneWay);
    }
}
}


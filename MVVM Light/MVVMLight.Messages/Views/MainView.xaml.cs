using System;
using Windows.Devices.Geolocation;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using GalaSoft.MvvmLight.Messaging;
using MVVMLight.Messages.Messages;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MVVMLight.Messages.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainView : Page
    {
        public MainView()
        {
            this.InitializeComponent();
            Messenger.Default.Register<StartAnimationMessage>(this, message =>
            {
                RectangleAnimation.Begin();
            });
        }
    }
}

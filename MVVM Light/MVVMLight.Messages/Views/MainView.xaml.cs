using Windows.UI.Xaml.Controls;
using GalaSoft.MvvmLight.Messaging;
using MVVMLight.Messages.Messages;

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

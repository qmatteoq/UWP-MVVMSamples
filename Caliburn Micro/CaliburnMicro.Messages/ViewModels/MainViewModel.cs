using Caliburn.Micro;
using CaliburnMicro.Messages.Messages;

namespace CaliburnMicro.Messages.ViewModels
{
    public class MainViewModel: Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public MainViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void StartAnimation()
        {
            _eventAggregator.PublishOnUIThread(new StartAnimationMessage());   
        }
    }
}

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Caliburn.Micro;
using CaliburnMicro.Advanced.Models;
using CaliburnMicro.Advanced.Services;

namespace CaliburnMicro.Advanced.ViewModels
{
    public class MainViewModel : Screen
    {
        private readonly IRssService _rssService;

        public MainViewModel(IRssService rssService)
        {
            _rssService = rssService;
        }

        private ObservableCollection<FeedItem> _news;

        public ObservableCollection<FeedItem> News
        {
            get { return _news; }
            set
            {
                _news = value;
                NotifyOfPropertyChange();
            }
        }

        protected override async void OnActivate()
        {
            await RefreshData();
        }

        public async Task RefreshData()
        {
            List<FeedItem> items = await _rssService.GetNews("http://wp.qmatteoq.com/rss");
            News = new ObservableCollection<FeedItem>(items);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVMLight.Advanced.Models;
using MVVMLight.Advanced.Services;

namespace MVVMLight.Advanced.ViewModels
{
    public class MainViewModel : ViewModelBase
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
            set { Set(ref _news, value); }
        }

        private RelayCommand _loadCommand;

        public RelayCommand LoadCommand
        {
            get
            {
                if (_loadCommand == null)
                {
                    _loadCommand = new RelayCommand(async () =>
                    {
                        RssService rssService = new RssService();
                        List<FeedItem> items = await rssService.GetNews("http://wp.qmatteoq.com/rss");
                        News = new ObservableCollection<FeedItem>(items);
                    });
                }

                return _loadCommand;
            }
        }
    }
}

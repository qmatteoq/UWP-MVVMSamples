using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

        private FeedItem _selectedFeedItem;

        public FeedItem SelectedFeedItem
        {
            get { return _selectedFeedItem; }
            set { Set(ref _selectedFeedItem, value); }
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
                        List<FeedItem> items = await _rssService.GetNews("http://wp.qmatteoq.com/rss");
                        News = new ObservableCollection<FeedItem>(items);
                    });
                }

                return _loadCommand;
            }
        }

        private RelayCommand _itemSelectedCommand;

        public RelayCommand ItemSelectedCommand
        {
            get
            {
                if (_itemSelectedCommand == null)
                {
                    _itemSelectedCommand = new RelayCommand(() =>
                    {
                        Debug.WriteLine(SelectedFeedItem.Title);
                    });
                }

                return _itemSelectedCommand;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CaliburnMicro.Advanced.Models;

namespace CaliburnMicro.Advanced.Services
{
    public class FakeRssService : IRssService
    {
        public Task<List<FeedItem>> GetNews(string url)
        {
            List<FeedItem> items = new List<FeedItem>
        {
            new FeedItem
            {
                PublishDate = new DateTime(2015, 9, 3),
                Title = "Sample news 1"
            },
            new FeedItem
            {
                PublishDate = new DateTime(2015, 9, 4),
                Title = "Sample news 2"
            },
            new FeedItem
            {
                PublishDate = new DateTime(2015, 9, 5),
                Title = "Sample news 3"
            },
            new FeedItem
            {
                PublishDate = new DateTime(2015, 9, 6),
                Title = "Sample news 4"
            }
        };

            return Task.FromResult(items);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using CaliburnMicro.Advanced.Models;

namespace CaliburnMicro.Advanced.Services
{
    public interface IRssService
    {
        Task<List<FeedItem>> GetNews(string url);
    }
}

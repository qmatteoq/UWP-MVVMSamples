using MVVMLight.Advanced.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVVMLight.Advanced.Services
{
    public interface IRssService
    {
        Task<List<FeedItem>> GetNews(string url);
    }
}

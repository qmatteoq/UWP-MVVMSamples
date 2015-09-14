using MVVMLight.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLight.Advanced.Services
{
    public interface IRssService
    {
        Task<List<FeedItem>> GetNews(string url);
    }
}

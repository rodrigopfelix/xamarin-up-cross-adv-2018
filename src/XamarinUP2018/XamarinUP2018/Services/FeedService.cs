using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinUP2018.Models;

namespace XamarinUP2018.Services
{
    public interface IFeedService
    {
        Task<List<FeedItem>> GetFeedItems();
    }
    class FeedService : IFeedService
    {
        public Task<List<FeedItem>> GetFeedItems()
        {
            return new List<FeedItem> {
                new FeedItem ()
            };
        }
    }
}

using Microsoft.Extensions.Caching.Memory;
using UmbracoDevTest.Services.Interface;

namespace UmbracoDevTest.Services.Implementation
{
    public class SharedService : ISharedService
    {
        private readonly IMemoryCache _cache;
        public SharedService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void Add(string key, object value)
        {
            _cache.Set(key, value);
        }

        public T Get<T>(string key)
        {
            return _cache.Get<T>(key);
        }
    }
}

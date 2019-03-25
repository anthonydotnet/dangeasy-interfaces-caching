using System;

namespace DangEasy.Interfaces.Caching
{
    public interface ICache
    {
        bool Add(string key, object value, TimeSpan ? cacheDuration = null);
        T Get<T>(string key);
        T Get<T>(string cacheKey, Func<T> hydrationFunction, TimeSpan ? cacheDuration = null) where T : class;
        bool Remove(string key);
        void RemoveByPrefix(string cachePrefix);
    }
}
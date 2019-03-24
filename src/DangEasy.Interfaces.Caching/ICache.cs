using System;

namespace DangEasy.Interfaces.Caching
{
    public interface ICache
    {
        bool Add(string key, object value, int? cacheSeconds = null);
        T Get<T>(string key);
        T Get<T>(string cacheKey, Func<T> hydrationFunction, int? cacheSeconds = null) where T : class;
        bool Remove(string key);
        void RemoveByPrefix(string cachePrefix);
    }
}
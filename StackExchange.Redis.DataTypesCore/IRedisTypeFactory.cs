using StackExchange.Redis.DataTypesCore.Collections;

namespace StackExchange.Redis.DataTypesCore
{
    public interface IRedisTypeFactory
    {
        RedisDictionary<TKey, TValue> GetDictionary<TKey, TValue>(string name);
        RedisSet<T> GetSet<T>(string name);
        RedisList<T> GetList<T>(string name);
    }
}

using ServiceStack.Redis;

namespace KB.Tool.Redis
{
    public interface IRedisProvider
    {
        IRedisClientsManager CreateRedisClientsManager();
    }
}

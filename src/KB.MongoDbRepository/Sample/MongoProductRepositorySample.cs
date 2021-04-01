
using KB.Entity.Sample;
using KB.IRepository.Sample;
using ZZH.MongoDB.StandardService.MongoDb;
using ZZH.MongoDB.StandardService.Repositories;

namespace KB.MongoDbRepository.Sample
{
    /// <summary>
    /// Mongo DB 仓储示例
    /// </summary>
    public class MongoProductRepositorySample : MongoDbRepositoryBase<MongoProduct>, IMongoProductRepositorySample
    {
        public MongoProductRepositorySample(IMongoDatabaseProvider provider) : base(provider)
        {

        }
    }
}

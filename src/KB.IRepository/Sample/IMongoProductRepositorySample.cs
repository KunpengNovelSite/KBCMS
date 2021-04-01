using KB.Entity.Sample;
using ZZH.MongoDB.StandardService.Repositories;

namespace KB.IRepository.Sample
{
    /// <summary>
    /// Mongo 仓储接口示例
    /// </summary>
    public interface IMongoProductRepositorySample : IMongoDbRepository<MongoProduct>
    {

    }
}

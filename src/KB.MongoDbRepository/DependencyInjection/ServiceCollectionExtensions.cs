using Microsoft.Extensions.DependencyInjection;
using KB.IRepository.Sample;
using KB.MongoDbRepository.Sample;

namespace KB.MongoDbRepository.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// MongoDB 仓储服务注入
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddMongoDbRepository(this IServiceCollection services)
        {
            // 示例 demo
            services.AddTransient<IMongoProductRepositorySample, MongoProductRepositorySample>();

            // add repositories

            return services;
        }
    }
}

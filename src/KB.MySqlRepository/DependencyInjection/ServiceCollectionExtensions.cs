using Microsoft.Extensions.DependencyInjection;
using KB.IRepository.Sample;
using KB.MySqlRepository.Sample;

namespace KB.MySqlRepository.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// MySql 仓储服务注入
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddMySqlRepository(this IServiceCollection services)
        {
            // 示例 demo
            services.AddTransient<IProduct2RepositorySample, Product2RepositorySample>();

            // add repositories

            return services;
        }
    }
}

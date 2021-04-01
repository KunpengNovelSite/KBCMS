using Microsoft.Extensions.DependencyInjection;
using KB.IRepository.Sample;
using KB.PostgreSqlRepository.Sample;
using System;
using System.Collections.Generic;
using System.Text;

namespace KB.PostgreSqlRepository.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// PostgreSql 仓储服务注入
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddPostgreSqlRepository(this IServiceCollection services)
        {
            // 示例 demo
            services.AddTransient<IProductRepositorySample, ProductRepositorySample>();

            // add repositories

            return services;
        }
    }
}

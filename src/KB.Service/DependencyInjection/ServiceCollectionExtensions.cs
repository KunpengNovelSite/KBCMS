using Microsoft.Extensions.DependencyInjection;
using KB.IService.Sample;
using KB.Service.Sample;
using KP.IService.UserInfo;
using KP.Service.UserInfo;

namespace KB.Service.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 注册应用层的应用服务
        /// </summary>
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            // sample
            services.AddTransient<IProductInboundServiceSample, ProductInboundServiceSample>();
            services.AddTransient<IProduct2InboundServiceSample, Product2InboundServiceSample>();
            services.AddTransient<IMongoProductServiceSample, MongoProductServiceSample>();

            services.AddTransient<ISysUserInfoService, SysUserInfoService>();

            return services;
        }
    }
}

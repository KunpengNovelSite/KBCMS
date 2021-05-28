using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

using KB.MongoDbRepository.DependencyInjection;
using KB.MySqlRepository.DependencyInjection;
using KB.PostgreSqlRepository.DependencyInjection;
using KB.Service.DependencyInjection;
using KB.SqlServerRepository.DependencyInjection;
using KB.Tool.ApplicationBuilder;
using KB.Tool.DependencyInjection;
using KB.Tool.Diagnostics;
using KB.Tool.Http;
using KB.Tool.Http.Filters;
using KB.Tool.Logger;
using ZZH.Metrics.ServiceCollection.Extensions;
using ZZH.DapperExpression.Service.DependencyInjection;
using ZZH.MongoDB.StandardService.DependencyInjection;
using ZZH.AutoMapper.Service.DependencyInjection;
using ZZH.ZipKinClient.Service.DependencyInjection;
using NLog.Web;

namespace KB.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(1, 0);
            });
            services.AddMvc().AddMvcOptions(option =>
            {
                option.Filters.Add<LogAttribute>();
            })
            .AddFluentValidation(fv =>
            {
                fv.RegisterValidatorsFromAssemblyContaining<Startup>();
                // 当前程序集 https://fluentvalidation.net/aspnet#asp-net-core
            });

            services.AddHttpContextAccessor();

            //services.AddRedisSentinelCache(Configuration);  // 哨兵模式
            //services.AddRedisCache(Configuration);//普通模式

            // add dapper MySql
            services.AddDapperMySql<MySqlRepository.Context.KBActiveDbContext>("KB_mysql");
            services.AddMySqlRepository();

            #region 数据库连接-framework-demo
            //// only for test
            //// 实际开发中只能使用 SqlServer 或 MySQL、PostgreSQL其中一个
            //if (string.Equals(Configuration["dbmodel"], "MySql", System.StringComparison.OrdinalIgnoreCase))
            //{
            //    // add dapper MySql
            //    services.AddDapperMySql<MySqlRepository.Context.KBActiveDbContext>("KB_mysql");
            //    services.AddMySqlRepository();
            //}
            //else
            //{
            //    if(string.Equals(Configuration["dbmodel"], "PostgreSQL", System.StringComparison.OrdinalIgnoreCase))
            //    {
            //        //add dapper PostgreSQL
            //        services.AddDapperPostgreSql<PostgreSqlRepository.Context.KBActiveDbContext>("KB_postgresql");
            //        services.AddPostgreSqlRepository();
            //    }
            //    else
            //    {
            //        // add dapper SqlServer
            //        services.AddDapperSqlServer<SqlServerRepository.Context.KBActiveDbContext>("KB");
            //        services.AddSqlServerRepository();
            //    }               
            //}
            #endregion

            // add MongoDB
            services.AddMongoDbRepository();
            services.AddMongoDB();

            // add automapper
            services.AddAutoMapper();
            services.AddApplicationService();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, DiagnosticListener diagnosticListener)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(ExceptionHandler.Default);  // handle exception
            }

            app.UseHttpsRedirection();

            diagnosticListener.AddToolkitDiagnositcs();  // 添加诊断

            env.ConfigureNLog("nlog.config");
            loggerFactory.AddDefaultNLog(options =>
            {
                options.HasRequestHeaders = true;
                options.HasResponseHeaders = true;
            });

            // 保证在 Mvc 之前调用
            app.UseHttpContextGlobal()
               .UseToolTrace();      
            app.UseRouting();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //app.UseMvc();

        }
    }
}

using KB.IRepository.Sample;
using KB.PostgreSqlRepository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace KB.PostgreSqlRepository.Sample
{
    /// <summary>
    /// PostgreSql 仓储示例 demo
    /// </summary>
    public class ProductRepositorySample : BaseRepository, IProductRepositorySample
    {
        /// <summary>
        /// 初始化一个<see cref="ProductRepositorySample"/>对象，同时启动事务支持
        /// </summary>
        /// <param name="context"></param>
        public ProductRepositorySample(KBActiveDbContext context) : base(context)
        {
        }
    }
}

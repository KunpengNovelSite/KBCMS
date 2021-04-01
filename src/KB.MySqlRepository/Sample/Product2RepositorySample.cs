﻿using KB.IRepository.Sample;
using KB.MySqlRepository.Context;

namespace KB.MySqlRepository.Sample
{
    /// <summary>
    /// MySql 仓储示例 demo
    /// </summary>
    public class Product2RepositorySample : BaseRepository, IProduct2RepositorySample
    {
        /// <summary>
        /// 初始化一个<see cref="Product2RepositorySample"/>对象，同时启动事务支持
        /// </summary>
        /// <param name="context"></param>
        public Product2RepositorySample(KBActiveDbContext context) : base(context)
        {

        }
    }
}

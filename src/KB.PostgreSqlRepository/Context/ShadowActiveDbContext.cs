using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using ZZH.DapperExpression.Service.Data;

namespace KB.PostgreSqlRepository.Context
{
    /// <summary>
    /// PostgreSql Db上下文对象
    /// </summary>
    public class KBActiveDbContext : ActiveDbContext
    {
        public override DbConnection CreateDbConnection(string connectionString)
        {
            return new Npgsql.NpgsqlConnection(connectionString);
        }
    }
}

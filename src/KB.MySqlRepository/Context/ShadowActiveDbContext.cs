using System.Data.Common;
using ZZH.DapperExpression.Service.Data;

namespace KB.MySqlRepository.Context
{
    /// <summary>
    /// MySql DB 上下文对象
    /// </summary>
    public class KBActiveDbContext : ActiveDbContext
    {
        public override DbConnection CreateDbConnection(string connectionString)
        {
            return new MySql.Data.MySqlClient.MySqlConnection(connectionString);
        }
    }
}

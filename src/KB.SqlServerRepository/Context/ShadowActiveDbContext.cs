using System.Data.Common;
using ZZH.DapperExpression.Service.Data;

namespace KB.SqlServerRepository.Context
{
    /// <summary>
    /// SqlServer DB 上下文对象
    /// </summary>
    public class KBActiveDbContext : ActiveDbContext
    {
        public override DbConnection CreateDbConnection(string connectionString)
        {
            return new System.Data.SqlClient.SqlConnection(connectionString);            
        }
    }
}

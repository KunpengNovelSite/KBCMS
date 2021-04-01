using KB.MySqlRepository.Context;
using ZZH.DapperExpression.Service;

namespace KB.MySqlRepository
{
    /// <summary>
    /// MySql 仓储基类
    /// </summary>
    public abstract class BaseRepository : CasualDapperRepository<KBActiveDbContext>
    {
        /// <summary>
        /// 初始化一个新的<see cref="BaseRepository"/>实例
        /// </summary>
        /// <param name="context">DB 上下文</param>
        /// <param name="useTransaction">是否启用事务处理, 默认为 false</param>
        protected BaseRepository(KBActiveDbContext context, bool useTransaction = false) : base(context, useTransaction)
        {

        }
    }
}

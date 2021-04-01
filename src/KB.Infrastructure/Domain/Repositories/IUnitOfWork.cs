using System.Threading.Tasks;

namespace KB.Infrastructure.Domain.Repositories
{
    /// <summary>
    /// 表示工作单元
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// 提交事务
        /// </summary>
        void Commit();

        /// <summary>
        /// 提交事务
        /// </summary>
        Task CommitAsync();
    }
}

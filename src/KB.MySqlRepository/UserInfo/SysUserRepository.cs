using KB.MySqlRepository;
using KB.MySqlRepository.Context;
using KP.IRepository.UserInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace KP.MySqlRepository.UserInfo
{
    public class SysUserRepository : BaseRepository, ISysUserRepository
    {
        /// <summary>
        /// 初始化一个<see cref="SysUserRepository"/>对象，同时启动事务支持
        /// </summary>
        /// <param name="context"></param>
        public SysUserRepository(KBActiveDbContext context) : base(context)
        {

        }
    }
}

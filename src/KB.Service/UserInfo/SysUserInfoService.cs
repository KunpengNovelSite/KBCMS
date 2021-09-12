using KP.Entity.UserInfo;
using KP.IRepository.UserInfo;
using KP.IService.UserInfo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace KP.Service.UserInfo
{
    public class SysUserInfoService : ISysUserInfoService
    {
        private readonly ISysUserRepository _userinfoRepository;
        public async Task<List<sys_user_info>> GetAllUserInfoAsync()
        {
            var listAsync = await _userinfoRepository.QueryAsync<sys_user_info>("SELECT * FROM sys_user_info");
            return listAsync.ToList();
        }
    }
}

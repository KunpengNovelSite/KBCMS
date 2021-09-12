using KP.IService.UserInfo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : Controller
    {
        private readonly ISysUserInfoService _userInfoService;
        public UserInfoController(ISysUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        [Route("QueryUsers")]
        [HttpGet]
        public async Task<IActionResult> QueryAll()
        {
            var products = await _userInfoService.GetAllUserInfoAsync();
            return Ok(products);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;

namespace WebApi.OnlineOrdering.Controllers
{
    public class LoginRegistController : ApiController
    {
        UserBll bll = new UserBll();
        public string  Login(User user)
        {
            int result = bll.Login(user);
            if(result>0)
            {
                return "登录成功";
            }
            else
            {
                return "登录失败";
            }
        }
        public string  Regist(User user)
        {
            int result = bll.Regist(user);
            if (result > 0)
            {
                return "注册成功";
            }
            else
            {
                return "注册失败";
            }
        }
    }
}

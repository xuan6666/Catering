using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class UserDal
    {
        MyContext my = new MyContext();
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Login(User user)
        {
            my.Users.Add(user);
            int result = my.SaveChanges();
            my.Dispose();
            return result;
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Regist(User user)
        {
            my.Users.Add(user);
            int result = my.SaveChanges();
            my.Dispose();
            return result;
        }
    }
}

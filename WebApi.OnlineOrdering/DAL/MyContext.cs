using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace DAL
{
    public class MyContext:DbContext
    {
        public MyContext ():base("BaseContext")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}

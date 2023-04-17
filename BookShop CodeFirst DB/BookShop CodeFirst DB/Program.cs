using BookShop_CodeFirst_DB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_CodeFirst_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BookShopSchoolContext();
            context.Database.EnsureCreated();
            
        }
    }
}

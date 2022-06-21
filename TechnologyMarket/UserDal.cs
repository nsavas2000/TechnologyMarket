using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyMarket
{
    public class UserDal
    {
        public List<User> GetAll()
        {
            using (ShopingContext context1 = new ShopingContext())
            {
                return context1.Users.ToList();
            }
        }
        


    }
}

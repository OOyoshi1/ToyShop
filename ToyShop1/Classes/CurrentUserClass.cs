using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop1.DB;

namespace ToyShop1.Classes
{
    public class CurrentUserClass
    {

        public static User currentUser = new User();
        public static Client client = new Client();
        public static void GetUserId(int id)
        {
            currentUser = EFClass.context.User.Where(x => x.UserId == id).FirstOrDefault();
            client = EFClass.context.Client.Where(x => x.IdClient ==currentUser.IdUser).FirstOrDefault();

        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUser.Model
{
   public  class GenerateUser
    {
        public static results GetUser()
        {
            serviceUser asd = new serviceUser("https://randomuser.me/api?results=1");
            //Console.WriteLine(asd.GetJsonUser());
            string json = asd.GetJsonUser();
            var users = JsonConvert.DeserializeObject<Users>(json);
            return users.results[0];
        }
    }
}

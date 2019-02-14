using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13._02.NewFolder1;
using Newtonsoft.Json;

namespace _13._02
{
    class Program
    {
        static void Main(string[] args)
        {
            serviceUser asd = new serviceUser("https://randomuser.me/api?results=1");
            //Console.WriteLine(asd.GetJsonUser());
            string json = asd.GetJsonUser();
            var users = JsonConvert.DeserializeObject<Users>(json);
            
        }
    }
}

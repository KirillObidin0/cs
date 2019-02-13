using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02.NewFolder1
{
    class Class2
    {
        public void CreateRequest()
        {
            Request r = new Request();

            Console.Write("Enter KUNNR: ");
            r.KUNNR = Int32.Parse(Console.ReadLine());

            Console.Write("Enter BURKS: ");
            r.BUKRS = Int32.Parse(Console.ReadLine());

            Console.Write("Enter WERKS: ");
            r.WERKS = Console.ReadLine();

            Console.Write("Enter DATA1: ");
            r.DATA1 = Convert.ToDateTime(Console.ReadLine());

            


        }
        public void GenerateReport()
        {
            
        }
    }
}

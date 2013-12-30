using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderByStringmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from m in typeof(string).GetMethods()
                        where m.IsStatic == true
                        orderby m.Name
                        
                      
                        select new { m.Name  };

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }
    }
}

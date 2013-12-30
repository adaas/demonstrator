using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderByStringmethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> query = AllMethods();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }

        public static IEnumerable<string> AllMethods()
        {
            IEnumerable<string> query = from m in typeof(string).GetMethods()
                                        where m.IsStatic == true
                                        orderby m.Name

                                       select m.Name;
            return query;
        }
    }
}

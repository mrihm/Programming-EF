using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorks.EF;

namespace AdventureWorks.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var awlt = new AWLTEntities();
            var prods = awlt.Products.Where(x => x.Name.StartsWith("F")).OrderBy(x => x.Name);

            Console.WriteLine("Selected Products:");
            Console.WriteLine("------------------");

            foreach(var prod in prods)
                Console.WriteLine("{0}, ${1}", prod.Name, prod.ListPrice.ToString("#,##0.00"));

            Console.WriteLine("\nPress <enter> to continue...");
            Console.ReadLine();
        }
    }
}

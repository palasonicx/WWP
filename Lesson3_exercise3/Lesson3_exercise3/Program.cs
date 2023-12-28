﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Query using Query Syntax");
            //Data Source
            List<int> integerList = new List<int>()
{
1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};
            //LINQ Query using Query Syntax
            var QuerySyntax = from obj in integerList
                              where obj > 5
                              select obj;
            //Execution
foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nLINQ Query using Method Syntax");
            List<int> integerList1 = new List<int>()
{
1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};
            //LINQ Query using Method Syntax
            var MethodSyntax = integerList1.Where(obj => obj > 5).ToList();
            //Execution
            foreach (var item in MethodSyntax)
            {
                Console.Write(item + " ");
            }
        }
    }
}
   

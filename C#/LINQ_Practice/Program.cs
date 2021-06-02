using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine("Hello World!");
            //  SimpleQuery();
            // ParitionOpr();
            //Sequence();
   
        }
   
        static void Sequence()
        {
            //Checkcs equlity and in  between two array
            int[] num1 = { 1,2,3};
            int[] num2 = { 1, 2, 3 };

            bool check = num1.SequenceEqual(num2);
            Console.WriteLine(check);

            //Zip 1*1 + 2*2 +3*3 = 13
            int ans = num1.Zip(num2,(a,b) => a*b).Sum();
            Console.WriteLine(ans);
        }
        static void ParitionOpr()
        {
            // Skip and Take 
            
            int[] num1 = { 2, 4, 1, 0, 3, 5 };
            //Gives First 3
            //Take allows to take 3 values from start , can also apply on query syntax
            var first3 = num1.Take(3);
            // Take while - it's with condition 
           //Goes until the condition breaks
            var first3while = num1.TakeWhile(n => n >1);

            //After 3 values it will print
            var skipp = num1.Skip(3);
            foreach (var item in skipp)
            {
                Console.WriteLine(item);
            }

        }
        static void SimpleQuery()
        {
            //Simple SQL with where
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var lnum = from num in numbers //From where to select
                      where num < 5   //Condition
                      select num;    //what to select? ,from here whatever we select it will stored

            var numwhere = numbers.Where((num) => num < 5);
            foreach (var item in numwhere)
            {
                Console.WriteLine("Hello " + item);

            }

            //Where Method 
            //Index means means position in the array
            //    var dig = numbers.Where((numbers, Index) => 6 < Index);

            int[] num1 = { 2, 4, 1, 0, 3, 5 }; 
            string[] str = {"zero","one","two","three","four","five"};
            var orderval = from x in num1
                           select str[x];

            foreach (var item in orderval)
            {
                Console.WriteLine("Hello " + item);

            }


        }


    }
}

using System;

namespace Insem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Q1();
            //  Q2();
            Q3();
        }

        public static void Q3()
        {
            try
            {
               int  a = int.Parse(Console.ReadLine());
               int b = int.Parse(Console.ReadLine());

                Console.WriteLine(a + b);
            }
            catch (OverflowException Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }


        public static void Q2()
        {
            string s = "hello world";
            s=s.Replace('o', 'i');
           s=s.Replace("r", string.Empty);
            Console.WriteLine(s); // Helli wild

        }


        public static void Q1()
        {

            {
                int a = 10, b = 20;
                int sum = Calculator.AddNums(a, b);
                string output = string.Format("The sum {0} and {1} is {2}", a, b,sum);
                Console.WriteLine(output);

            }

        }
    }

    class Calculator
    { 
            public static int AddNums(int a , int b )
              {
                return a + b;
             }

    
    }

}
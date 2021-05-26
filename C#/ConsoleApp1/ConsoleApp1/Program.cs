using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basics
            /*
             Console.WriteLine("Hello World!");
              string name = Console.ReadLine();
              Console.WriteLine(" Hello "+ name + " "  );
            */

            /*
            string num;
            Console.WriteLine("Enter 1 ");
             num = Console.ReadLine();

            string message = (num == "1") ? "1 is selected " : "Enter 1 Please ";

            Console.WriteLine(message);

            //Value Replacment 
            Console.WriteLine("Hello World , You Selcted Option {1} and result is {0}",message,num);
            //Calling Functions from Same and Different Class
            Q1();
            AnotherClass.Q2();
             */
            /*
            //Array
            int[] num = new int[5];
            int[] num1 = new int[] { 1,2,3,4,5};

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
            num[i] = rnd.Next(100);
               Console.WriteLine(num[i]);
            }
            foreach (var item in num1)
            {
                Console.WriteLine(item);
            }
            
            string Temp = "Hello World";
            //  Console.WriteLine(Temp[2]);
            char[] arr = Temp.ToCharArray();
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
          
            Console.WriteLine(String.Concat(Temp, "AAA"));
            */
            /* string ch = Q1("Hello");
               Console.WriteLine(string.Format("1 : {0}",ch));
               Console.WriteLine("2 : {0}", ch);
               Console.WriteLine("3 : " + ch);

               int num = int.Parse(Console.ReadLine());
               Console.WriteLine(num);
          
            //Working with Strings 

            string str = "   Hello World";
            // Console.WriteLine(string.Format("{0:C}",123123));
            //Console.WriteLine("2 : {0:C}", "AAA");
            //Console.WriteLine(str.Trim());

             */
            //Working with Dates
            Dates();
        }

        public static void Dates()
        {
            DateTime myValue = DateTime.Now;
            // Console.WriteLine(myValue.ToString());
            //  Console.WriteLine(myValue.ToShortDateString());
            // Console.WriteLine(myValue.AddDays(1).ToString());
            Console.WriteLine(myValue.DayOfYear.ToString());


        }
        public static string Q1(string x)
        {
            Console.WriteLine("In Q1");
            char[] message = x.ToCharArray();

            return String.Concat(message);
        }
    }
    class AnotherClass
    {
        public static void Q2()
        {
            Console.WriteLine("In Q2");

        }


    }


   
}

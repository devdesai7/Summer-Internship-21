using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

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
            //    Program PS = new Program();
            //    PS.Dates();
            //Class
            //  AnotherClass AC = new AnotherClass();
            //  AC.make = "Hello";
            //Console.WriteLine("{0}", AC.make);
            //Console.WriteLine( AC.val());

            //  AnotherClass.val();


            //Working with Collection
            // Collections();

            //LINQ
            //  LINQ();

            //Handling Exception
          //  HandleExpection();



        }
        public static void HandleExpection()
        {
            try
            {
                string content = File.ReadAllText(@"C:\Text.txt");
                Console.WriteLine(content);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void LINQ()
        {

            //LINQ QUERY
            /*
           var value = from classname in objectname
                       classname.property =="value"
                        select classname;
            */
            //LINQ  METHOD
            /*
            var value = objectname.Where
                (p => type == "Value");
            */

           }      
            public static void Collections()
        {
            /*
            ArrayList a = new ArrayList();
            a.Add("Hello");
            a.Add("World");
            foreach (var item in a)
            {
                Console.WriteLine(item);

            }
            */
            //List
            List<int> myList = new List<int>();

            //Dictonary
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(2, "Hello");
             dt.Add(1,"World");

            Console.WriteLine(dt[2]); // 2 is the key
        
        }
        public void Dates()
        {
            DateTime myValue = DateTime.Now;
            // Console.WriteLine(myValue.ToString());
            //  Console.WriteLine(myValue.ToShortDateString());
            // Console.WriteLine(myValue.AddDays(1).ToString());
            //Console.WriteLine(myValue.DayOfYear.ToString());
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
      //  public string make { get; set; }
        private string myVar;

        public string make
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public  int val ()
        {
            Console.WriteLine(myVar + "::" );
            return 100;

        }


    }


   
}

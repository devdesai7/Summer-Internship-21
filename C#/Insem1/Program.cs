using System;
using System.Collections;

namespace Insem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Q1();
            //  Q2();
            //  Q3();
            //Q4
            //  KnowVar K = new KnowVar();
            // K.MyMethod(10);
            // Q5();
            // Q6;
            /*
            point p = new point(10,20);
            Console.WriteLine(p.assgnX);
            Console.WriteLine(p.assgnY);
            Tuple<int,int> x =p.deconstruct(10,20);
            Console.WriteLine(x.Item1);
            Console.WriteLine(x.Item2);
            */
            //Q7
            Buyer B = new Buyer();
            B.Q7();

        }

        public static void Q5()
        {
            DateTime dt = DateTime.Now;
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add(true);
            al.Add(dt);
            al.Add("hello");

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }



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
    class Buyer
    {
        public  void Q7()
        {
            var shoppingCart = new shoppingCart[3]; // fill this as per your solution
            shoppingCart[0] = new Wheat5kgBag();
            shoppingCart[1] = new Wheat5kgBag();
            shoppingCart[2] = new RefinedOil5kg();
            Biller biller = new Biller();
            float totalBill = biller.CalculateTotalBill(shoppingCart);
            Console.WriteLine($"Total Bill = {totalBill}");
        }
    }
    class Biller
    {

       public int CalculateTotalBill(shoppingCart[] sc)
        {
            int total=0;

            foreach (var item in sc)
            {
                total += item.calcamount();
            }
            return total;
        }

    }
     
    class shoppingCart
    {
        private int wholesalecost { get; set; }
        private int tax { get; set; }
        private int profit { get; set; }

        public shoppingCart(int wc, int tax, int p)
        {
            this.wholesalecost = wc;
            this.tax = tax;
            this.profit = p;
        }

        public int calcamount()
        {
            return this.wholesalecost + this.tax + this.profit;
        }



    }

    class Wheat5kgBag : shoppingCart
    {
        public Wheat5kgBag() : base(150, 5, 50) { }
    }

    class RefinedOil5kg : shoppingCart
    {
        public RefinedOil5kg() : base(280, 10, 70) { }
    }

    class point
    {
         int x, y;

        public int assgnX
        {
            get { return x; }
           
        }
        public int assgnY
        {
            get { return y; }
           
        }

       public point(int x , int y)
        {

            this.x = x;
            this.y = y;
        }
        
      public Tuple<int,int> deconstruct(int x , int y)
        {
            Tuple<int, int> t = new Tuple<int, int>(x,y);
            return t;
        }

    }
    class KnowVar
    {
        int _m = 10;
        public void MyMethod(int i, int j = 10)
        {
            var k = i + j;
            var sum = "The sum";
            Console.WriteLine(k);
            var n=0;
            var mul="";
            n = i * j;
            mul = "The multiplication";
            Console.WriteLine(n);
            KnowVar ob = new KnowVar();
            KnowVar ob2 = null;
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
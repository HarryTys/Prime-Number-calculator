using System;
using System.Threading;

namespace afea
{
    class Globals
    {
        public static double number;
    }

    class Example
    {
        public void FirstThread()
        {
            double sqrNumber = 0;
            while (sqrNumber * sqrNumber != Globals.number)
            {
                sqrNumber = sqrNumber + 0.001;
                if (Globals.number - (sqrNumber * sqrNumber) < 0.0001)
                {
                    Console.WriteLine("Done");
                    Thread.Sleep(1000);
                    Console.WriteLine("Square root roughly equals " + Decimal.Round(Convert.ToDecimal(sqrNumber), 5));
                    Thread.Sleep(30000);
                    Environment.Exit(0);
                }
                else { Console.WriteLine(sqrNumber + " * " + sqrNumber + " = " + sqrNumber * sqrNumber); }
            }
        }

        public void SecondThread()
        {
            double sqrNumber = 0;
            while (sqrNumber * sqrNumber != Globals.number)
            {
                sqrNumber = sqrNumber + 0.1;
                if (Globals.number - (sqrNumber * sqrNumber) < 0.0001)
                {
                    Console.WriteLine("Done");
                    Thread.Sleep(1000);
                    Console.WriteLine("Square root roughly equals " + Decimal.Round(Convert.ToDecimal(sqrNumber), 5));
                    Thread.Sleep(30000);
                    Environment.Exit(0);
                }
                else { Console.WriteLine(sqrNumber + " * " + sqrNumber + " = " + sqrNumber * sqrNumber); }
            }
        }

        public void ThirdThread()
        {
            double sqrNumber = Globals.number / 2;
            while (sqrNumber * sqrNumber != Globals.number)
            {
                sqrNumber = sqrNumber - 0.01;
                if (Globals.number - (sqrNumber * sqrNumber) < 0.0001)
                {
                    Console.WriteLine("Done");
                    Thread.Sleep(1000);
                    Console.WriteLine("Square root roughly equals " + Decimal.Round(Convert.ToDecimal(sqrNumber), 5));
                    Thread.Sleep(30000);
                    Environment.Exit(0);
                }
                else { Console.WriteLine(sqrNumber + " * " + sqrNumber + " = " + sqrNumber * sqrNumber); }
            }
        }

        public void FourthThread()
        {
            double sqrNumber = Globals.number / 4;
            while (sqrNumber * sqrNumber != Globals.number)
            {
                sqrNumber = sqrNumber - 0.01;
                if (Globals.number - (sqrNumber * sqrNumber) < 0.0001)
                {
                    Console.WriteLine("Done");
                    Thread.Sleep(1000);
                    Console.WriteLine("Square root roughly equals " + Decimal.Round(Convert.ToDecimal(sqrNumber), 5));
                    Thread.Sleep(30000);
                    Environment.Exit(0);
                }
                else { Console.WriteLine(sqrNumber + " * " + sqrNumber + " = " + sqrNumber * sqrNumber); }
            }
        }
    }
    class sample
    {
        public static void Main()
        {
            Example e = new Example();
            Thread a = new Thread(new ThreadStart(e.FirstThread));
            Thread b = new Thread(new ThreadStart(e.SecondThread));
            Thread c = new Thread(new ThreadStart(e.ThirdThread));
            Thread d = new Thread(new ThreadStart(e.FourthThread));
            Console.WriteLine("Enter a number: "); Globals.number = double.Parse(Console.ReadLine());
            Console.WriteLine("Thread 1 initialised");
            Thread.Sleep(1000);
            Console.WriteLine("Thread 2 initialised");
            Thread.Sleep(1000);
            Console.WriteLine("Thread 3 initialised");
            Thread.Sleep(1000);
            Console.WriteLine("Thread 4 initialised");
            Thread.Sleep(1000);
            a.Start();
            b.Start();
            c.Start();
            d.Start();
        }
    }
}
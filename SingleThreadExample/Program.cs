using System;
using System.Threading;

namespace SingleThreadExample
{
    class Program
    {
        public void metho1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method1 is : {0}", i);

                if (i == 5)
                    Thread.Sleep(6000);
            }
        }

        public void metho2()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method2 is : {0}", i);
            }
        }
    }

    class DriverClass
    {


        static void Main(string[] args)
        {

            Program Geek = new Program();


            Thread thr1 = new Thread(Geek.metho1);
            Thread thr2 = new Thread(Geek.metho2);
            thr1.Start();
            thr2.Start();
            //Geek.metho1();
            //Geek.metho2();
        }
    }
}

using System;

namespace Fibonacy_series
{
    class Program
    {
        static void Main(string[] args)
        {
           int no= 10;

            int firstNo = 0, SecondNo = 1, nextNo;

            for(int i=2; i<no;i++)
            {
                nextNo = firstNo + SecondNo;
                Console.WriteLine(nextNo);
                firstNo = SecondNo;
                SecondNo = nextNo;

            }

            Console.ReadKey();


        }
    }
}

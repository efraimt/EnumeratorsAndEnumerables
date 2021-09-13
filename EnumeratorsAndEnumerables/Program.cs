using System;
using System.Collections.Generic;

namespace EnumeratorsAndEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] vs = { 1, 2, 3 };
            foreach (var item in vs)
            {

            }

            List<int> vs1 = new List<int>(new int[] { 1, 2, 3 });
            foreach (var item in vs1)
            {

            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 10);
            }

            //var myMofaOfSidra = new Sidra10To100();

            //while (myMofaOfSidra.MoveNext())
            //{
            //    var item = myMofaOfSidra.Current;
            //}


            foreach (var item in new Sidra10To100())
            {
                Console.WriteLine(item);
            }

        }



    }
}

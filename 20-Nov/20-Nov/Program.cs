using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1


            Console.WriteLine("Your Name");
            string Name = Console.ReadLine();

            Console.WriteLine(Name);

            //Task2

            int x = 10;
            double y = 2.5;
            string a = "Malek";
            char b = 'M';

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(a);
            Console.WriteLine(b);




            //Task3

            string[] Cars = { "MArcsedies", "KIA", "Mazda" };
            Console.WriteLine(Cars[0]);
            Console.WriteLine(Cars[1]);
            Console.WriteLine(Cars[2]);
            Console.WriteLine("The Length Of Array = " + Cars.Length);





            //Task4

            Console.WriteLine("fName");


            string fName = Console.ReadLine();

            Console.WriteLine("SName");


            string SName = Console.ReadLine();


            Console.WriteLine("Year");


            string Year = Console.ReadLine();







            Console.WriteLine(fName + SName + Year);




            //Task5

            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Element  = 1 : " + Num[0]);
            Console.WriteLine("Element  = 2 : " + Num[1]);
            Console.WriteLine("Element  = 4 : " + Num[2]);
            Console.WriteLine("Element  = 5 : " + Num[3]);
            Console.WriteLine("Element  = 6 : " + Num[4]);
            Console.WriteLine("Element  = 7 : " + Num[5]);
            Console.WriteLine("Element  = 8 : " + Num[6]);
            Console.WriteLine("Element  = 9 : " + Num[7]);
            Console.WriteLine("Element  = 10 : " + Num[8]);


            int Sum = Num[0] + Num[1] + Num[2] + Num[3] + Num[4] + Num[5] + Num[6] + Num[7] + Num[8] + Num[9];

            Console.WriteLine(Sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Task1

            //int[] ARR = { 1, 7, 9, 45 };
            //string[] arr2 = { "Str", "alex", "moh" };

            //string[] arr3 = { "the", "fox", "over", "lazy", "dog", };


            //Task2

            //String[] fruits ={"Tomato", "Banana", "Watermelon"};
            //for(int i =1; i<fruits.Length; i++)
            //{
            //    Console.WriteLine (i);

            //}


            //Task3
            //String[] Food ={"Tomato", "Banana", "Watermelon"};
            //String[] Sport ={"Tomato", "Banana", "Watermelon"};
            //String[] Movie ={"Tomato", "Banana", "Watermelon"};

            //foreach(string i in Food)
            //{
            //    Console.Write(i+ " ");
            //}

            //Console.WriteLine(" ");

            //foreach (string e in Sport)
            //{
            //    Console.Write(e + " ");
            //}

            //Console.WriteLine(" ");


            //foreach (string m in Movie)
            //{
            //    Console.Write(m + " ");
            //}









            //Task4

            
            string[] M=Console.ReadLine().Split(',');

            int[] P =new int[M.Length];

            for(int i =0; i< M.Length; i++)
            {
                P[i]= Convert.ToInt32(M[i]);     
                
            }

            Console.WriteLine(P[0] + P[1] + P[2]);



            //Task5.

            //int sum = 0;

            //for (int i=0; i<=100; i++)

            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //        sum += i;
            //    }



            //}

            //Console.WriteLine(sum);


            //Task6

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*" + " ");
            //    }

            //    Console.WriteLine();



            //}
            //int sum = 1;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(sum + " " );
            //        sum++;
            //    }

            //    Console.WriteLine();



            //}






























        }





    }
}


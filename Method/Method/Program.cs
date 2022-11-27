using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {

        static void Task1(int[] array)

        {

            double s = 0;
            double Avg = 0;

            foreach (int item in array) { 
            Console.WriteLine(item);
                s+=item;
            }
            Avg = s / array.Length;


            Console.WriteLine("The Sum= " + s);
            Console.WriteLine("The Avg = " +Avg);
        }






        static void Task2(int[] array2) {
           

            foreach (int x in array2)
            {
                Console.WriteLine( "The Cube OF Number = "+ x*x*x);
                
               
            }

          

        }


        static void Task3(int[] array3)
        {


            for(int i=0; i<array3.Length; i++)
            {
                if (array3[i] > 1950)
                {
                    Console.WriteLine(array3[i]);

                }
                
            }


        

        }

        static int Task4(int Age)
        {

            return Age * 365 ;




           




        }

        static int Task5(int ch,int co , int cheep) {
            int legs=ch*2 +  co*4  + cheep*4;
            return legs;
        }


        static void Task6(string UserName,int Password)
        {
            if(UserName == "Malek" && Password==2233) {
                Console.WriteLine("Sucssee");
            }

            else if(UserName=="Hassan" && Password == 4455)
            {
                Console.WriteLine("Sucsses");
            }

            else if (UserName == "omar" && Password == 6699)
            {
                Console.WriteLine("Sucsses");
            }

            else
            {
                Console.WriteLine("Fail");
            }


        }


        static int Task7 (int Number ,int Number2)
        {
            int sum = 1;


            for(int i = 0; i<=Number2; i++)
            {
                
                sum*=Number;

            }
            return sum;



        }

        static bool Task8 (int Year)
        {
            for(int i=1900;i<=2022; i += 4)
            {
                if (Year == i)
                {
                    return true;
                }

            }

            return false;

        }





        static bool Task9 (int prime)
        {

            for (int i = 2; i < prime; i++)
            {

                if (prime % i == 0)
                {
                    return  false;

                }


            }

            return true;





        }
        static int Task10(string Sentence)

        {
            int count = 1;

            string Word= Sentence.Trim();

            foreach(char i in Word)
            {
                if(i == ' ')
                    {
                        count++;

                    }
            }
            return count;











        }




        







        static void Main(string[] args)
        {
            //A method can be called multiple times:


            Console.WriteLine("Task1 ___________________________________________________");


            int[] arr = { 1, 2, 3, 4, 5,6,7,8,9,10 };


             Task1(arr);

            Console.WriteLine("Task2______________________________________________________");


            int[] arr2 = { 2,3 };
             Task2(arr2);

            Console.WriteLine("Task3 __________________________________________________________");



            int[] arr3 = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            Task3(arr3);

            Console.WriteLine("Task4 _________________________________________________________");



            int agee = Task4(21);
            Console.WriteLine(agee + " Days");

            Console.WriteLine("Task5 ____________________________________________________________");


            int legg =  Task5(2, 2, 2);
            Console.WriteLine(legg +"legs");

            Console.WriteLine("Task6 __________________________________________________________");

            Task6("Malek", 2233);

            Task6("malek", 2233);
            Task6("ahmad", 2233);

            Console.WriteLine("Task7 _____________________________________________________");


            Console.WriteLine(Task7(7,8));

            Console.WriteLine("Task8 ___________________________________________________");



            if (Task8(2001))
            {
                Console.WriteLine(" Leap ");
            }
            else
            {
                Console.WriteLine("Not Leap");
            }



            Console.WriteLine("Task9 ____________________________________________________");



            if (Task9(21))
            {
                Console.WriteLine(" Prime ");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }


            Console.WriteLine("Task10____________________________________________________");


            Console.WriteLine("Number of word is  " +Task10(" hello my name is malek")); 












            //string myString = Console.ReadLine();
            //int wCount = 0, index = 0;

            //while (index < myString.Length)
            //{
            //    while (index < myString.Length && !char.IsWhiteSpace(myString[index]))
            //        index++;

            //    wCount++;

            //    while (index < myString.Length && char.IsWhiteSpace(myString[index]))
            //        index++;
            //}
            //Console.WriteLine(wCount);
            //Console.ReadLine();




        }
    }
}

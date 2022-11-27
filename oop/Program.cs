using oop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop
{
    


    public class Personal

    {

        private int Age;



        private string Gender;
        private string Name;
        private string Email;
        private int ID;
        private string Phone;







        public Personal(int age,string gender, string name, string email ,int id ,string phone) { 

           
                if (age >= 18 && age <= 60)
                {
               
                Age = age;

                }
                else
                {

                Console.WriteLine("age isn't valid");
                }

                Gender= gender;
            
                Name= name;
           
                Email= email;
                ID= id;
                Phone = phone;

            string NumPh = phone.Substring(0, 3);
            if(NumPh !="077" || NumPh!= "079" || NumPh!= "078")
            {
                Console.WriteLine("The Number Phone is Wrong");
                Phone= phone;
                

            }

            else
            {
                Phone= phone;
            }

            
        }




        public void PersonalInfo()
        {
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Gender : " + Gender);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Phone : " + Phone);

        }
    }





}


internal class Program
    {

      





        
        static void Main(string[] args)
 {


        Personal p1 = new Personal(21, "Mail", "Malek", "Obidat68@gmail.com", 20000, "070716488");
        p1.PersonalInfo();












































        //    Console.WriteLine("Enter Your Age ");

        //    Personal p1 = new Personal(21,"AMlek","kk","ii",22,"jj");

        //    int Age=Convert.ToInt32(Console.ReadLine());





        //    Console.WriteLine("Enter Your Gender ");


        //    string Gender = Console.ReadLine();


        //    Console.WriteLine("Enter Your Name ");


        //    string Name = Console.ReadLine();





        //Car car1 = new Car(20000, "kia","cerato", 2017);



        //Console.WriteLine(car1.id);
        //Console.WriteLine(car1.name);


        //Console.WriteLine(car1.Year);

        //Console.WriteLine(car1.type);

























        //Console.WriteLine("enter Num1");
        //double n = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Operation");

        //string n1 = (Console.ReadLine());

        //Console.WriteLine("enter Num2");
        //double n2 = Convert.ToDouble(Console.ReadLine());

        //Calc(n, n1, n2);

        //Console.WriteLine("Enter NAme");

        //string massege = (Console.ReadLine());
        //Welcome(massege);



        //Console.WriteLine("Enter NAme");

        //string massege2 = (Console.ReadLine());
        //GoodBy(massege2);


    }
}


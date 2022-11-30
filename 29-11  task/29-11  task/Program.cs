using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _29_11__task
{

     interface Car 
    {


         void StartEngine();

    
        void StopEngine();



      
        void OpenDoor();


         void CloseDoor();

        void Honk();

        void IncreaseSpeed();

        void DecreaseSpeed();


        void Breaks();


        void OpenWindow();

        void CloseWindow();

        void AdjustSeat();
        void CleanGlass();
        void ChangeGear();
    }


    class driver : Car
    {
        public void AdjustSeat()
        {
            throw new NotImplementedException();
        }

        public void Breaks()
        {
            throw new NotImplementedException();
        }

        public void ChangeGear()
        {
            throw new NotImplementedException();
        }

        public void CleanGlass()
        {
            throw new NotImplementedException();
        }

        public void CloseDoor()
        {
            throw new NotImplementedException();
        }

        public void CloseWindow()
        {
            throw new NotImplementedException();
        }

        public void DecreaseSpeed()
        {
            throw new NotImplementedException();
        }

        public void Honk()
        {
            throw new NotImplementedException();
        }

        public void IncreaseSpeed()
        {
            throw new NotImplementedException();
        }

        public void OpenDoor()
        {
            throw new NotImplementedException();
        }

        public void OpenWindow()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }

    }









    class Employee



    {

        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int ID { get; set; }

        public DateTime date = DateTime.Now;
        



        public Employee(string name, DateTime birthday, int id)
        {
            
            Name = name;
            Birthday = birthday;
            ID= id;



        }

        public void Calage () {

            TimeSpan value = date - Birthday;
            Console.WriteLine(  Name + "  Age is  " + (value.TotalDays)/365);


           
        }















        public void Calage(int Birthday)
        {
            Console.WriteLine(Name + "  Age is  " + Convert.ToString(date.Year - Birthday));




        }
         




        public virtual void print() { 
            Console.WriteLine(Name+ " " + Birthday + " " + ID);
        }

    }


    class Manger : Employee
    {
        public Manger(string name, DateTime birthday, int id):base(name, birthday, id) { 


        }




        public override void print()
        {
            Console.WriteLine(" Welcome " +  Name + " " +  Birthday + " " + ID  );
        }




    }


    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime();
            d = Convert.ToDateTime(Console.ReadLine());

            Employee Obj = new Employee("Malek", d, 14);
            Manger obj2 = new Manger("Mohammad", d, 15);
            






           




            Obj.Calage();

            obj2.Calage();


            




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _29_11__task
{

    //    class Car
    //    {
    //        public void StartEngine() {
    //            Console.WriteLine("Start");
    //        }
    //        public void StopEngine() {
    //            Console.WriteLine("Stop");
    //        }
    //        public void OpenDoor() {
    //            Console.WriteLine("Open door");

    //        }

    //        public void CloseDoor() { 
    //            Console.WriteLine("Close door")
    //        }
    //        public void Honk() {
    //            Console.WriteLine("Honk");
    //        }
    //        public void IncreaseSpeed() {
    //            Console.WriteLine("Speed ");
    //        }
    //        public void DecreaseSpeed() {
    //            Console.WriteLine("Speed low");
    //        }

    //        public void Breaks() {
    //            Console.WriteLine("Break");
    //        }
    //        public void OpenWindow() {
    //            Console.WriteLine("Open Wi")
    //;        }
    //        public void CloseWindow() { }
    //        public void AdjustSeat() { }
    //        public void CleanGlass() { }
    //        public void ChangeGear() { }
    //    }


    class Employee
    {
        public string Name { get; set; }
        public int Birthday { get; set; }
        public int ID { get; set; }



        public Employee(string name, int birthday, int id)
        {
            Name = name;
            Birthday = birthday;
            ID= id;



        }

        public void Calage (int Birthday) {
            Console.WriteLine(2022 - Birthday);
            


        }



        public void print() { 
            Console.WriteLine(Name+ " " + Birthday + " " + ID);
        }

    }


    class basee : Employee
    {
        public basee(string name, int birthday, int id):base(name, birthday, id) { 


        }
        
           

        

    }

   
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee Obj = new Employee("Malek", 2001, 14);

            Obj.print();
            Obj.Calage(2001);


        }
    }
}

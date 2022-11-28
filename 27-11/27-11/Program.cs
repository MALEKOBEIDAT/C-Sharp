using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_11
{
    class Car
    {
        private int id;
        private string name;
        private string description;


        public Car( int ID ,string NAME)
        {
            
            
            id = ID;
            name = NAME;
        }

        public int ID {
            get { return id; }
            set { id =ID; }

        }

        public string NAME
        {
            get { return name;  }   
            set { name = NAME; }
        }

       
        //public Car(int idd, string namee, string descriptionee)
        //{
        //    id = idd;

        //    name = namee;
        //    description = descriptionee;


        //}
           

    
                  


           
        

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(12,"MAlek");

            Console.WriteLine(car.ID);
            Console.WriteLine(car.NAME);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _28_11
{

    class Car
    {
        private string make;
        public string Make
        {

            get { return make; }
            set { make = "Germany"; }

        }
        private int year;
        public int Year
        {
            get { return year; }
            set { year = 2018; }
        }


        private string type;

        public string Type
        {
            get { return type; }
            set { type = "C200"; }
        }

        public string Color { get; set; }
      

        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                price = 23555;
            }
        }
        private int model;
        public string Model
        {
            get { return Model; }
            set
            {
                model = 88558;
            }
        }
        private int palletNo;
        public int PalletNo
        {
            get { return palletNo; }
            set
            {
                palletNo = 64984949;
            }
        }

        private int letter;
        public int Letter
        {
            get { return letter; }
            set
            {
                letter = 120;
            }
        }



        public Car(string make,int year,string type,string color, int price,string model ,int palletNo , int letter)
        {
             Make = make;
             Year = year;
             Type = type;
             Color = color;
             Price = price;
             Model = model;
            PalletNo = palletNo;
            Letter = letter;








        }

        public void start()
        {
            Console.WriteLine("Car On");

        }
        public void stop()
        {
            Console.WriteLine("Car Off");
        }

        public void print()
        {
            Console.WriteLine(make+year+type+Color+price+model+palletNo);

        }

        public void Power()
        {
            Console.WriteLine(letter*18);

        }




    }


    class dr : Car

    {
        public dr(string make, int year, string type, string color, int price, string model, int palletNo ,int letter):base(make,year,type,color,price,model,palletNo,letter)        {


        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Car Obj = new Car("Germany",2018,"C200","Black",45000,"Classic",24-8888,120);
           
            Obj.print();
            Obj.Power();






        }
    }
}

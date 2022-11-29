using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_11
{
    //class  Dad
    //{
    //    public virtual void print()
    //    {
    //        Console.WriteLine("Class");
    //    }
    //}

    //class Son:Dad
    //{
    //    public override void print()
    //    {
    //        Console.WriteLine("Class1");
    //    }
    //}
    //class Son2:Dad
    //{
    //    public override void print()
    //    {
    //        Console.WriteLine("Class2");
    //    }
    //}


    //abstract class Son3
    //{
    //    public void p()
    //    {
    //        Console.WriteLine("Hello");
    //    }
    //}

    //abstract class  a
    //{
    //    public abstract void m();
        

        
    //}

    //class b : a
    //{
       

    //    public override void m()
    //    {
    //        Console.WriteLine("d");
    //    }
    //}

    //class Son4 : Son3
    //{
    //    public void pp()
    //    {
    //        Console.WriteLine("Hello2");
    //    }
    //}

    //interface big
    //{
    //    void mm();

    //}

    //interface big2
    //{
    //    void mmm();
    //}


    //class small : big,big2
    //{
    //    public  void mm()
    //    {
    //        Console.WriteLine("d");
    //    }

    //    public void mmm()
    //    {
    //        Console.WriteLine("dddd");
    //    }
    //}
    class calc
    {
        public void sum (int x,int y ) {
            int sum = x + y;
            Console.WriteLine($" The sum of {x} and {y} ={sum}");

        }
        public void sum(double x, double y, double z)
        {
            double sum = x + y + z;
            Console.WriteLine($" The sum of {x} and {y} and {z} ={sum}");

        }

        public virtual void print()
        {
            Console.WriteLine("");
        }

        //public virtual void print()     Type 'calc' already defines a member called 'print' with the same parameter types		

        //{
        //    Console.WriteLine("jhkjjk");
        //}
    }


    class calc2 : calc
    {
        public override void print()
        {
            Console.WriteLine("override and overload");
        }
       

       

       
    }







    abstract class class1
    {
        public void fun1()
        {
            Console.WriteLine("Fun1");
        }

        public abstract void fun2();
    }


    class class2:class1
    {

        public override void fun2()
        {
            Console.WriteLine("fun2");

        }
    }


    //_____________________________________________________________________________ Interface


    interface interface1
    {
        void fun3();

    }

    interface interface2
    {
        void fun4();
    }

    class interfacee : interface1,interface2
    {
        public void fun3()
        {
            Console.WriteLine("interface fun");

        }

        public void fun4()
        {
            Console.WriteLine("fun4");

        }
    }


    //____________________________________________________________________________________






  

    internal class Program
    {
        static void Main(string[] args)
        {


            //calass1 obj= new calass1();  cant make object in abstract class

           calc ca=new calc();
            ca.sum(1, 1);
            ca.sum(2.4, 8.0, 7.5);

            class2 obj2= new class2();
            obj2.fun1();


            interfacee obj3 = new interfacee();
            obj3.fun3();

            try
            {
               int[] myNumbers = {1, 2, 3};
               Console.WriteLine(myNumbers[10]);

            }

           
            catch (Exception x)
            {

                Console.WriteLine(x.Message );


            }


            //catch 
            //{

            //    Console.WriteLine("try again please"); 


            //}































            //Dad obj1 = new Dad();
            //Dad obj2 = new Son();
            //Dad obj3 = new Son2();
            //obj1.print();
            //obj2.print();
            //obj3.print();
            //Son4 l= new Son4();
            //l.p();
            //try
            //{

            //    int[] myNumbers = { 1, 2, 3 };
            //    Console.WriteLine(myNumbers[10]);
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}



        }
    }
}

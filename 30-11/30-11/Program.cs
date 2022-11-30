using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_11
{
    abstract class Car
    {
        public void Toyota()
        {
            Console.WriteLine("Toyota");

        }

        public abstract void sleep();
    }

    class toyotainhret:Car
    {
        public override void sleep()
        {
            Console.WriteLine("hello");
        }

    }

    interface KIA
    {
        void Toyota2();  
    }


    class KIAINHRET : KIA

    {
        public void Toyota2()
        {
            Console.WriteLine("sn;os");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            toyotainhret car1 = new toyotainhret();
            car1.Toyota();

            car1.sleep();


        }
    }
}

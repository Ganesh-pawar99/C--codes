using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Synario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.print();
            A a2 = new B();
            a2.print();
            A a3 = new C();
            a3.print();



            B b2 = new B();
            b2.print();
            //B b1 = new A();
            //b1.print();
            // it is not possible because we can not convert explitity derived class into base class
            B b3 = new C();
            b3.print();


            C c1 = new C();
            c1.print();
           // C c2 = new B();
          //  c2.print();
           // C c3 = new A();
           // c3.print();
           // in that case c is  derived class and A and C is a base class

            Console.ReadLine();

        }
    }
    public class A
    {
        public void print()
        {
            Console.WriteLine("A");
        }
    }
    public class B : A
    {
        public new void print()
        {
            Console.WriteLine("B");
        }

    }
    public class C : B
    {
        public new void print()
        {
            Console.WriteLine("C");
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_problem__Inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // multiple class inheritance problem:(Diamond Problem)
            /*
                       - multiple class inheritance is not possible in C# 
            - why ?

                   A
         (virtual print())
                   /       \
                  /         \    
                 /           \ 
               B :A         C:A
       (overide print())     (overide print())
                 \           /
                  \         / 
                   \       /
                    \     / 
                     D:B,c
        (override print())

            // isme hum yek se jyada base class inherite nahi kar sakate 
            // isi liye C# ne ise nikal dala he (it is not support )

            // multiple class inheritance is not possible 
            // but multiple class interface i possible





             */

        }
    }
}

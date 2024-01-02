using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4._1_string_type
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "ganesh";
            Console.WriteLine(name);

            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Count());
            //    Console.WriteLine(name.Replace(  "gkp"));
            // remove etra space
            string value = "         gkp";
            Console.WriteLine(value);
            Console.WriteLine(value.Trim());
            Console.WriteLine(value.TrimStart());
            // Console.ReadLine();


            // Escape sequence 

            name = "\"ganesh\"";
            Console.WriteLine(name);
            name = "\"pawar\"";
            Console.WriteLine(name);
            name = "\';.gkp\';.";
            Console.WriteLine(name);
            //  Console.ReadLine();
            Console.WriteLine("ganesh\tpawar");
            Console.WriteLine("ganesh\npawar");
            // Console.ReadLine();
            // verbatim literal  (@)

            //  string path = "C:\New folder\backup\batch6";
            string path = @"C:\New folder\backup\batch6";
            Console.WriteLine(path);


            //concatenation

            // 1 space (pluse operator);
            string firstname = "ganesh";
            string lastname = "pawar";

            string fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);
            // Console.ReadLine();

            // 2. concat operator
            fullname = string.Concat(firstname, lastname);
            Console.WriteLine(fullname);
            fullname = string.Concat(firstname, "   ", lastname);
            Console.WriteLine(fullname);
            string middlename = "Khanderao";
            fullname = string.Concat(firstname + " " + middlename + " " + lastname);
            Console.WriteLine(fullname);
            //Console.ReadLine() ;

            // 3. join 

            fullname = string.Join(" ", firstname, lastname);
            Console.WriteLine(fullname);
            //Console.ReadLine    ();

            fullname = string.Join(" ", "fullname", ":", firstname, middlename, lastname);
            Console.WriteLine(fullname);
            // Console.ReadLine();

            // ** placeholder syntax

            fullname = string.Format("fullname : {0} {1} {2}", firstname, middlename, lastname);
            Console.WriteLine(fullname);
            // Console.ReadLine();

            // ** string interpolation

            fullname = $"fullname : {firstname}  {middlename} {lastname}";
            Console.WriteLine(fullname);
            // Console.ReadLine();
            fullname = $"my name is : {firstname}";
            Console.WriteLine(fullname);
            Console.ReadLine();



            // ** datatype conversion





            //fullname = string.Format("fullmane = {0}{3}", firstname,middlename, lastname);
            //     Console.WriteLine(fullname);
        }
    }
}

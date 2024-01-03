using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    // Advantages of Inheritance :
    /*   1. reuseability:
     *   - we can reuse code from base class to derived class 
     *    2. Specialization:
     *     derived class is a special class because it contain base class property as well as its own property.
     *     3. Extensibility:
     *     - close for modification (modification is not good)
     *     -open for extension (extension is always good)
     *     whenever we need to add a new type we can easily add without modifing code in existing types.
     *     (means 1. humare pass 4 floor tower he fir hume yek floor badana he to hum naki fura girake naya 
     *     banaynge balki hum uske uper badha denge.)
     *     (2. hum kheti me tractor use karate he to uska purpose hul chalana ,transport karane keliye 
     *      use karate he tab hum uske sath extention use karate he jaise transport keliye troyee join karate 
     *      or masyagat karane ke liye hum ka use karate he vaise hi isme hum extension use karenge)
     *   (na ki hum dono ke liye alag alag use karenge)
     *   
     *   
     *   
     *   
     *   
     *   
     *   
     *   
     *   */
    internal class Program
    {
        static void Main(string[] args)
        {
            // inheritance 
            // can reuse  member from one type to another type
            // do or usse jyada real time entity me is a relationship aa raha hoga tab tab inhritace
            // use kar sakate he
            // suraj is a son of khanderao
            // ganesh is a son of khanderao
            // pruthviraj is a son of khanderao
            // in above example khanderao ia s parent/base class & s,g,p is a child/derived class
            // 
            // 
            fulltimeemployee sc = new fulltimeemployee() { firstname = "suraj" };
            sc.printfullname();
            fulltimeemployee sc1 = new fulltimeemployee() { firstname = "ganesh" };
            sc1.printfullname();
            fulltimeemployee sc2 = new fulltimeemployee() { firstname = "pruthviraj" };
            sc2.printfullname();
            parttimeemployee s = new parttimeemployee() { firstname = "akshay", lastname = "daundker"};
            s.printfullname();
            parttimeemployee s1=new parttimeemployee() { firstname="abhishek",lastname="daudker"};
            s1.printfullname();
            contractor w = new contractor() {firstname="shahaji ",lastname="vir" };
            w.printfullname();
            employee sv= new fulltimeemployee();
            sv.printfullname();
            // reference variable sv of emplyee type pointing the object type of fulltimremployee.
            // in that example of object there 
            // base class variable can point to dirived class object
            // dirived class reference object can not point to base class object

Console.ReadLine();
        }

    }
    // parent/base class
    public class employee
    {
        public int employeeid;
        public string firstname;
        public  string lastname = "pawar";
        public int age;
        public string emailid;
        public void printfullname()
        {
            Console.WriteLine("\nfullname=  {0} {1}", firstname, lastname);
        }
    }
    // child /derived class
    public class fulltimeemployee : employee
    {
        
        public int yearlysalary;
        
        // various fields
        // we impliment inheritance when we have is a relationship 
       
    }
    // child /derived class
    public class parttimeemployee :employee
    {
       
        public int hourlysalary;

        // various fields
       
    }
    public class contractor : employee
    {
     public   int percentage;
    }
}
 /*     
   types of Inheritance :
   1. single level inheritance.
   2. multi level inheritance .
   3. herarchtcal inheritance (tree  tree structure)
   4. multiple inheritance (c# does not support)
   5. hybrid inheritance (c# does not support)
  
  // modification code means agar hum contractor ki city add kare to vo hum parent class me field likhenge 
  // tab hume fulltime , parttime employee ko bhi dena pagega . that is modification
  
  
  
  
  
  
  
  */

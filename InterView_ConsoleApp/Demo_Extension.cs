using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView_ConsoleApp
{

    public class Parent
    {

        public void M1() {
            Console.WriteLine("M1() called!");
        }
        public void M2() {
            Console.WriteLine("M2() called !"); 
        }
    }
      static class Child {
       public static void M3(this Parent g) {
            Console.WriteLine( "M3() called!");
        }
    }

    internal class Demo_Extension
    {
        public static void Main(string[] args)
        {
            Parent  obj = new Parent();
            obj.M1();
            obj.M2();
            obj.M3();            
            Console.ReadLine();
        }
    }
}

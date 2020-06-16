using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingPrac
{
    class Parent
    {
        public int variable = 273;
        public void Method()
        {
            Console.WriteLine("부모의 메서드");
        }
    }
    class Child : Parent{
        public string variable = "shadowing";
        public void Method()
        {
            Console.WriteLine("자식의 메서드");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine(c.variable);
            Console.WriteLine(((Parent)c).variable);

            c.Method();
            ((Parent)c).Method();
        }
    }
}

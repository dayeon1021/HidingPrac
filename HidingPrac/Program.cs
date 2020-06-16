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
        //virtual로 선언한 뒤에 자식에서 override를 붙여서 표시한 뒤 사용
        public virtual void Method()
        {
            Console.WriteLine("부모의 메서드");
        }
    }
    class Child : Parent{

        //new 키워드를 사용하면 Hiding을 하겠다는 의미이다.
        public new string variable = "shadowing";
        public override void Method()
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

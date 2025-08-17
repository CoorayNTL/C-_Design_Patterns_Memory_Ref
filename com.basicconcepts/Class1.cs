using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.com.basicconcepts
{
    public class A
    {
        public virtual void MethodA() 
        {
            Console.WriteLine("a object from method A");
        }
    }

    public class B : A 
    {
        public override void MethodA()
        {
           Console.WriteLine("b oject call to method A");
        }

        public void MethodB()
        {
            Console.WriteLine("B object call to Method B ");
        }
    }

    class Test
    {
        static void Main()
        {
            A a = new A();
            Console.WriteLine("A class obj");
            a.MethodA();

            B b = new B();
            Console.WriteLine("B class obj");
            b.MethodB();
            a.MethodA();

            A a2 = new B();
            a2.MethodA(); // a2 only access method A but new B() this how that happend 
            /** 
            When you write A a2 = new B();, the reference type is A, but the object type is B.
            At compile time, a2 only knows the methods of class A.
            At runtime, since the object is actually of type B, the overridden version of MethodA() 
            in B is called (this is polymorphism).
            However, you cannot directly call MethodB() on a2, because the compiler only sees it as type A. 
            To call MethodB(), you need to cast it back to B.
             * **/
        }
    }
}

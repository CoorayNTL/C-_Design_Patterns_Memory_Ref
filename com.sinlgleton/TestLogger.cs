

namespace ConsoleApp1.com.sinlgleton
{
    class TestLogger
    {
       
        static void Main()
        {
            // Logger obj1 =  new Logger;
            //Logger obj2 = new Logger();

            Logger obj1 = Logger.Instance;
            Logger obj2 = Logger.Instance;

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Test obj3 = new Test();
            Test obj4 = new Test();
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());

        }

        class Test
        {

        }
       

    }
}

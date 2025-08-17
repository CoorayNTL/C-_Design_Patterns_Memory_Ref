
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

    public class WorkEmail : IEmail
    {
        public string Email { get; }

        public WorkEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email cannot be null or empty", nameof(email));

            Email = email;
        }
    }
    class Test
    {
        static void Main()
        {
            //A a = new A();
            //Console.WriteLine("A class obj");
            //a.MethodA();

            //B b = new B();
            //Console.WriteLine("B class obj");
            //b.MethodB();
            //a.MethodA();

            //A a2 = new B();
            //a2.MethodA(); 

            // a2 only access method A but new B() this how that happend 
            /** 
            When you write A a2 = new B();, the reference type is A, but the object type is B.
            At compile time, a2 only knows the methods of class A.
            At runtime, since the object is actually of type B, the overridden version of MethodA() 
            in B is called (this is polymorphism).
            However, you cannot directly call MethodB() on a2, because the compiler only sees it as type A. 
            To call MethodB(), you need to cast it back to B.
             * **/

            //var emp = new Employee(1, "Tharindu");
            //emp.Title = "Engineer";
            //emp.EmployeeName = "Lakshan";
            // emp.EmployeeID = 5  // emp.EmployeeID = 5; not allowed (read-only
            // Console.WriteLine($"ID: {emp.EmployeeID}, Name: {emp.EmployeeName}, Title: {emp.Title}, Company: {emp.CompanyName}");

            IEmail workEmail = new WorkEmail("tharindu@ibm.com");

            Employee emp = new Employee(1, "Tharindu", workEmail);

            Console.WriteLine($"ID: {emp.EmployeeID}, Name: {emp.EmployeeName}, Email: {emp.Email}");
        }
    }
}

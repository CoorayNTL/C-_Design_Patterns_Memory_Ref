using ConsoleApp1.com.basicconcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.com.basicconcepts
{
    public interface IEmail //Internal method to public solution
    {
        string Email { get; }
    }
}

//Inconsistent accessibility: parameter type 'IEmail' is
////less accessible than method 'Employee.Employee(int, string, IEmail)'
//Meaning: exposing IEmail in a public API (Employee constructor), but the compiler says:
//"Wait, someone outside this assembly cannot even see IEmail, so how can they use this constructor?"
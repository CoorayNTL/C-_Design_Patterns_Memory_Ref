using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.com.basicconcepts {
    public class Employee
    {
        public int EmployeeID { get; }          // required (set once in constructor)
        public string EmployeeName { get; set; } // editable
        public string? Title { get; set; }       // optional
        public string CompanyName { get; } = "IBM"; // hardcoded constant

        private readonly IEmail _email;  // store interface implementation

        // Constructor
        public Employee(int id, string name, IEmail email)
        {
            EmployeeID = id;
            EmployeeName = name;
            _email = email; // store implementation
        }

        // expose email property directly
        public string Email => _email.Email;

    }
}


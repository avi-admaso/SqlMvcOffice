using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlMvcOffice
{
     class Employee
    {
        public string fName;
        public string birthDate;
        public string mail;
        public int salary;
        
        public Employee(string fName, string birthDate, string mail, int salary)
        {
            this.fName = fName;
            this.birthDate = birthDate;
            this.mail = mail;
            this.salary = salary;

        }
    }
}

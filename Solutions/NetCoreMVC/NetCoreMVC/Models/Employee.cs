using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVC.Models
{
    public class Employee
    {
        public Employee()
        {

        }

        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        #region methods

        public static List<Employee> GetSampleEmployee()
        {
            Employee e1 = new Employee { EmployeeID = 1, Name = "Samad", Department = "IT" };
            Employee e2 = new Employee { EmployeeID = 2, Name = "Ah Kaw", Department = "Sales" };
            Employee e3 = new Employee { EmployeeID = 3, Name = "Muthusamy", Department = "Account" };

            List<Employee> emp = new List<Employee>();
            emp.Add(e1);
            emp.Add(e2);
            emp.Add(e3);

            return emp;
        }

        #endregion

    }
}

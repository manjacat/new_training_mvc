using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVC.Models
{
    public class Employee
    {
        public Employee()
        {

        }

        [Key]
        [Required]
        [DisplayName("ID")]
        public int EmployeeID { get; set; }

        [Required]
        [DisplayName("Name")]
        [MinLength(5, ErrorMessage = "Name must be atleast 5 characters")]
        public string Name { get; set; }

        [DisplayName("Department")]
        public string Department { get; set; }

        #region methods

        public static List<Employee> GetSampleEmployee()
        {
            Employee e1 = new Employee { EmployeeID = 1, Name = "Samad", Department = "IT" };
            Employee e2 = new Employee { EmployeeID = 2, Name = "Ah Kaw", Department = "Sales" };
            Employee e3 = new Employee { EmployeeID = 3, Name = "Muthusamy", Department = "Account" };
            Employee e4 = new Employee { EmployeeID = 3, Name = "Sarimah", Department = "Support" };
            Employee e5 = new Employee { EmployeeID = 3, Name = "Elizabeh Tan", Department = "HR" };

            List<Employee> emp = new List<Employee>();
            emp.Add(e1);
            emp.Add(e2);
            emp.Add(e3);
            emp.Add(e4);
            emp.Add(e5);

            return emp;
        }

        public static Employee GetEmployee(int id)
        {
            List<Employee> allemp = GetSampleEmployee();
            Employee emp = allemp.Where(s => s.EmployeeID == id).First();
            return emp;
        }

        #endregion

    }
}

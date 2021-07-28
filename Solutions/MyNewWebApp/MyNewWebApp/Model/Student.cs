using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNewWebApp.Model
{
    public class Student
    {
        public Student()
        {

        }

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Class { get; set; }
    }
}

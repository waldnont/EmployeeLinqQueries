using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLinqQueries
{
    public class Employee
    {
        public int ID
        {
            get { return _id; }
            set { _id = value; }

        }
        public string Name { get; set; }
        public string Language { get; set; }

        public int DepartmentID
        {
            get { return _departmentID; }
            set { _departmentID = value; }
        }

        int _id;
        int _departmentID;
    }
}

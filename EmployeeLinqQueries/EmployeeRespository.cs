using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLinqQueries
{
    public class EmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public void Add(Employee e)
        {
            _employees.Add(e);
        }

        List<Employee> _employees = new List<Employee>
        {
            new Employee() { ID=1, Name="Tony", Language="C#", DepartmentID=1},
            new Employee() { ID=2, Name="Jim", Language="JavaScript", DepartmentID=1 },
            new Employee() { ID=3, Name="Bill", Language="Java", DepartmentID=1 },
            new Employee() { ID=4, Name="Leanne", Language="C++", DepartmentID=3 },
            new Employee() { ID=5, Name="Garth", Language="C++", DepartmentID=2 },
            new Employee() { ID=6, Name="Evan", Language="Cobol", DepartmentID=2 }
        };
    }
}

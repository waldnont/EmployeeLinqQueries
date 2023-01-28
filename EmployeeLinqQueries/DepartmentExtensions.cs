using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLinqQueries;
namespace DepartmentExtensions
{
    public static class DepartmentExtensions
    {
        public static List<Department> SetProper(this List<Department> departments)
        {
            for (int i = 0; i < departments.Count; ++i)
            {
                string lowerName = departments[i].Name.ToLower();
                string char1 = lowerName[0].ToString().ToUpper();
                departments[i].Name = char1 + lowerName.Remove(0,1);
            }
            return departments;
        }
        public static void WriteDepartments(this IEnumerable<Department> departments)
        {
            foreach (Department e in departments)
            {
                Console.WriteLine($"{e.ID} - {e.Name}\n");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLinqQueries;

namespace EmployeeExtensions1
{
    public static class EmployeeExtensions
    {
        public static IEnumerable<Employee> Where(
                                           this IEnumerable<Employee> sequence,
                                           Func<Employee, bool> predicate)
        {
            List<Employee> list = new List<Employee>();
            foreach (Employee employee in sequence)
            {
                if (predicate(employee))
                {
                    list.Add(employee);
                }
            }
            return list;
        }
        static void Write(this IEnumerable<Employee> employees)
        {
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name + " " + e.Language);
            }
            Console.WriteLine();
        }
    }
}

namespace EmployeeExtensions2
{
    public static class EmployeeExtensions
    {
        public static IEnumerable<Employee> Where(
                                           this IEnumerable<Employee> sequence,
                                           Func<Employee, bool> predicate)
        {
            foreach (Employee e in sequence)
            {
                if (predicate(e))
                {
                    yield return e;
                }
            }
        }
        public static void Write(this IEnumerable<Employee> employees)
        {
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name + " " + e.Language);
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeExtensions2;
using DepartmentExtensions;
namespace EmployeeLinqQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeQueries();
            DepartmentQueries();
            Console.ReadLine();
        }

        private static void DepartmentQueries()
        {
            DepartmentRepository repository = new DepartmentRepository();
            var query1 = (from d in repository.GetAll()
                          orderby d.Name ascending
                          select d).ToList().SetProper();
            query1.WriteDepartments();
        }

        private static void EmployeeQueries()
        {
            var repository = new EmployeeRepository();

            var query = repository.GetAll()
                     .Where(e => e.DepartmentID < 4 && e.ID < 10)
                     .OrderByDescending(e => e.DepartmentID)
                     .OrderBy(e => e.Name);

            query.Write();
            repository.Add(new Employee { ID = 7, DepartmentID = 2, Name = "Mike", Language = "Java" });
            query.Write();

            var query2 = repository.GetAll()
                .Where(e => e.Language == "Java" || e.Language == "JavaScript")
                .OrderBy(e => e.Language)
                .OrderBy(e => e.Name);
                query.Write();
        }

      
    }
}

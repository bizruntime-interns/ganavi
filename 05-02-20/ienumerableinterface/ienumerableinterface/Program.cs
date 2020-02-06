using System;
using System.Collections.Generic;
using System.Linq;


namespace ienumerableinterface
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
    }
    class TestEmployee
    { 
        static void Main()
        {
            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee { Id = 1, Name = "abc", Job = "sales" });
            Employees.Add(new Employee { Id = 2, Name = "def", Job = "market" });
            Employees.Add(new Employee { Id = 3, Name = "ghi", Job = "analyst" });

            foreach (Employee Emp in Employees)
                Console.WriteLine(Emp.Id + " " + Emp.Name + " " + Emp.Job);
            Console.ReadLine();

        }
    }
}

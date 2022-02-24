using System.Collections.Generic;
using System;


namespace KG02Ex
{

    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("I Manage:");
            foreach (Employee item in Employees)
            {
                Console.WriteLine(  item.ToString()+ " with work:");
                item.Work();
            }
        }

        public Manager(int id, string fornavn, string efternavn) : base(id, fornavn, efternavn)
        {
        }
        public void AddEmployee(Employee e)
        {
            Employees.Add(e);
        }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}

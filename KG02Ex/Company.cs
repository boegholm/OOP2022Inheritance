using System;
using System.Collections.Generic;

namespace KG02Ex
{
    class Company
    {
        public List<Employee> workers = new List<Employee>();
        public void AddEmployee(Employee e)
        {
            workers.Add(e);
        }

        public void PresentWorkers()
        {
            foreach (Employee worker in workers)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("Navn: "+ worker.GetFullName());
                worker.Work();
                Console.WriteLine("*******************");
                Console.WriteLine();
            }
        }
    }
}

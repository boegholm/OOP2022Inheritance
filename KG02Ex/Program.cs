namespace KG02Ex
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            SWIng e = new SWIng(10, "Thomas","Bøgholm");
            SWIng p = new SWIng(20, "Hans", "Hansen");
            
            Manager m = new Manager(12, "Ole", "Jensen");
            m.AddEmployee(e);
            m.AddEmployee(new Dat(100, "Finn", "Jensen"));
            Manager mm = new Manager(13, "Henning", "Pohl");
            mm.AddEmployee(m);

            mm.AddEmployee(p);
            //mm.Work();

            c.AddEmployee(e);
            c.AddEmployee(p);
            c.AddEmployee(m);
            c.AddEmployee(mm);



            c.PresentWorkers();
            //Person p = new Person("Hans".ToUpper(), "Hansen");
            //Person p2 = new Person("Thomas", "Hansen");

            //Console.WriteLine(p.GetFullName());
            //Console.WriteLine(p.Fornavn);
            //Console.WriteLine(p.Efternavn);

        }
    }
}

namespace KG02Ex
{
    //class ManagerManager : Employee
    //{
    //    public List<Manager> managers;

    //    public ManagerManager(int id, string fornavn, string efternavn) : base(id, fornavn, efternavn)
    //    {
    //    }
    //}


    abstract class Employee : Person
    {
        public Employee(int id, string fornavn, string efternavn) : base(fornavn, efternavn)
        {
            Id = id;
        }

        public int Id { get; }
        public abstract void Work();
    }
}

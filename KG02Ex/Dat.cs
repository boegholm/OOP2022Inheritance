namespace KG02Ex
{
    class Dat : Employee
    {
        public Dat(int id, string fornavn, string efternavn) : base(id, fornavn, efternavn)
        {
        }

        public override void Work()
        {
            System.Console.WriteLine("I Think about software");
        }
    }
}

using System;
using System.Collections.Generic;

namespace KG02Ex
{
    class SWIng : Employee
    {
        public SWIng(int id, string fornavn, string efternavn) : base(id, fornavn, efternavn)
        {
        }

        public override void Work()
        {
            Console.WriteLine("I Write software");
        }


        public string ToString()
        {
            return $"[{Id}] {GetFullName()}";
        }
    }
}

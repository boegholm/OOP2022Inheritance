using System;

///TODO: Specialisering via override
///TODO: Hvorfor supertype


namespace KG02Ex
{
    class Person 
    {

        public string Fornavn { get; }
        public string Efternavn { get; }
        public Person Far { get; }
        public Person Mor { get; }
        public string MellemNavn { get; private set; }
        public Person(string fornavn, string efternavn)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
        }

        public Person(string fornavn, string efternavn, Person far, Person mor) 
            : this(fornavn, efternavn)
        {
            Far = far;
            Mor = mor;
        }
 
        public string ToString()
        {
            return GetFullName();
        }


        //public string Navn
        //{
        //    get { return _navn; }
        //    set
        //    {
        //        if(value == "")
        //        {
        //            throw new ArgumentException();
        //        }
        //        if (char.IsLower(value[0]))
        //        {
        //            throw new AggregateException();
        //        }
        //        if (value == null)
        //            throw new ArgumentNullException("value");
        //        _navn = value;

        //    }
        //}

        public string GetFullName()
        {
            return Fornavn + MellemNavn+ " " + Efternavn;
        }
    }
}

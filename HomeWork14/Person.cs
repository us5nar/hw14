using System;

namespace HomeWork14
{
    //represents some perosns' arguments
    public class Person
    {
        public string Name;
        public int Age;
    }
    public class PersonProperties:EventArgs
    {
        public Person person;
    }
}

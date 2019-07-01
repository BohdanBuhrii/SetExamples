using System;

namespace SetExamples
{
    public class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public int CompareTo(Person other)
        {
            return this.BirthDate.CompareTo(other.BirthDate);
        }

        public override string ToString()
        {
            return Id.ToString() + "  " + Name + "  " + BirthDate.ToString();
        }
    }
}

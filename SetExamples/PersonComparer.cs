using System.Collections.Generic;

namespace SetExamples
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.BirthDate.CompareTo(y.BirthDate);
        }
    }
}

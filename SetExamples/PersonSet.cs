using System;
using System.Collections;
using System.Collections.Generic;

namespace SetExamples
{
    public class PersonSet : ISet<Person>
    {
        private ICollection<Person> _people;

        private readonly IComparer<Person> _comparer;

        public PersonSet(IComparer<Person> comparer)
        {
            _comparer = comparer;
        }

        public int Count { get { return _people.Count; } }

        public bool IsReadOnly => throw new NotImplementedException();

        public bool Add(Person item)
        {
            if (_people.Contains(item))
            {
                return false;
            }
            else
            {
                _people.Add(item);
                return true;
            }
        }

        public void Clear()
        {
            _people.Clear();
        }

        public bool Contains(Person item)
        {
            return _people.Contains(item);
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            _people.CopyTo(array,arrayIndex);
        }

        public void ExceptWith(IEnumerable<Person> other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Person> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void IntersectWith(IEnumerable<Person> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<Person> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<Person> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<Person> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<Person> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<Person> other)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Person item)
        {
            throw new NotImplementedException();
        }

        public bool SetEquals(IEnumerable<Person> other)
        {
            throw new NotImplementedException();
        }

        public void SymmetricExceptWith(IEnumerable<Person> other)
        {
            throw new NotImplementedException();
        }

        public void UnionWith(IEnumerable<Person> other)
        {
            throw new NotImplementedException();
        }

        void ICollection<Person>.Add(Person item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

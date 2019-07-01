using System;
using System.Collections.Generic;

namespace SetExamples
{
    class Program
    {
        public static void ShowSet<T>(ISet<T> set)
        {
            foreach (T a in set)
            {
                Console.Write(a.ToString() + "  ");
            }
        }
        

        public static void IntSortedSetExample()
        {
            SortedSet<int> set = new SortedSet<int>();
            
            Console.Write("Enter set lenth : ");

            int lenth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements");

            for (int i = 0; i < lenth; i++)
            {
                Console.Write("Next element : ");

                if (!set.Add(Convert.ToInt32(Console.ReadLine())))
                {
                    Console.WriteLine("Set already contains this element");
                    i--;
                }

                Console.Write("\nSet : ");
                ShowSet<int>(set);
                Console.WriteLine("\n");
            }

        }


        public static Person ReadPerson()
        {
            Person person = new Person();
            Console.Write("Id : ");
            person.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name : ");
            person.Name = Console.ReadLine();

            Console.Write("BirthDate : ");
            person.BirthDate = Convert.ToDateTime(Console.ReadLine());

            return person;
        }


        public static void PersonSortedSetExample()
        {
            SortedSet<Person> set = new SortedSet<Person>();

            Console.Write("Enter set lenth : ");

            int lenth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter people :");

            for (int i = 0; i < lenth; i++)
            {
                Console.Write("Next person :\n");

                if (!set.Add(ReadPerson()))
                {
                    Console.WriteLine("Set already contains this element");
                    i--;
                }

                Console.Write("\nSet : ");
                ShowSet<Person>(set);
                Console.WriteLine("\n");
            }
        }


        static void Main(string[] args)
        {
            
            IntSortedSetExample();

            PersonSortedSetExample();

        }
    }
}

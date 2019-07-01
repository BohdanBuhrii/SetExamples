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

        public static void PersonSortedSetExample()
        {

        }


        static void Main(string[] args)
        {
            //SortedSet<Person> set = new SortedSet<Person>(new PersonComparer());

            //set.Add(new Person { Name = "gogo", Id = 1 });
            //set.Add(new Person { Name = "gugu", Id = 2 });


            IntSortedSetExample();

        }
    }
}

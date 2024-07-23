using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using PersonArrayList.Model;

namespace PersonArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Id = 1, Name = "Ravi" };
            Person person2 = new Person() { Id = 2, Name = "Raju" };
            List<Person> list = new List<Person>();
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(person1);
            //arrayList.Add(person2);
            //arrayList.Add(1);
            list.Add(person1);
            list.Add(person2);


            //list.Add(1);
            //foreach (Person person in arrayList)
            //{
            //    Console.WriteLine(person.Name);
            //    Console.WriteLine(person.Id);
            //}
            foreach (Person person in list)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Id);
            }
        }
    }
}

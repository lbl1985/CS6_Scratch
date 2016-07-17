using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    public class Worker
    {
        public Worker()
        {
            work_dict();
        }

        public void work()
        {
            List<Person> people = new List<Person>();
            Person John = new Person() { Name = "John" };
            people.Add(John);
            people.Add(new Person() { Name = "Paul" });
            people.Add(new Person() { Name = "George" });
            people.Add(new Person() { Name = "Ringo" });
            people.Add(new Person() { Name = "Frodo" });
            people.Add(new Person() { Name = "Merry" });
            people.Add(new Person() { Name = "Pippin" });

            foreach(Person person in people)
            {
                Console.WriteLine($"Person: {person.Name}");
            }
        }

        public void work_dict()
        {
            Dictionary<string, Person> dict = new Dictionary<string, Person>();
            Person george = new Person() { Name = "George Washington", Age = 67 };
            string key = "George";
            dict.Add(key, george);

            dict.Add("john", new Person() { Name = "John Adams", Age = 90 });
            dict.Add("thom", new Person() { Name = "Thomas Jefferson", Age = 31 });

            Person secondPresident = dict["john"];
            Console.WriteLine($"The second president was: {secondPresident.Name}");
        }
    }
}

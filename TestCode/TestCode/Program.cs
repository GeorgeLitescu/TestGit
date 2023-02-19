using System;

namespace TestCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I should really have learned git by now");

            User creator = new User("George", 21);
            Console.WriteLine("{0} is learning git at {1}yo :o", creator.getName(), creator.getAge());
           
        }

        public class User
        {
            private string name;
            private int age;

            public User(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string getName()
            {
                string copyOfName = name;
                return copyOfName;
            }

            public int getAge()
            {
                int copyOfAge = age;
                return copyOfAge;
            }

        }
    }
}

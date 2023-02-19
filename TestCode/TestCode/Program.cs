using System;

namespace TestCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I should really have learned git by now");

            User creator = new User();
            creator.setName("George");
            Console.WriteLine("{0} is learning git :o", creator.getName());
        }

        public class User
        {
            private string name;

            public void setName(string name)
            {
                this.name = name;
            }

            public string getName()
            {
                string copyOfName = name;
                return copyOfName;
            }

        }
    }
}

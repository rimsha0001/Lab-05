using System;
namespace ExQ1
{
    internal class Program
    {
        static void Main(string[] args)
        
        public enum Department
        {
            ComputerScience,
            Mathematics,
            Physics,
            Chemistry
        }

        class Person
        {
            public string Name { get; set; }

            public Person()
            {
                Name = null;
            }

            public Person(string name)
            {
                Name = name;
            }
        }
    
        class Student : Person
        {
            public string RegNo { get; set; }
            public int Age { get; set; }
            public Department Program { get; set; }

            public Student()
            {
                RegNo = null;
                Age = 0;
                Program = Department.ComputerScience;
            }
        }
    }
    }


        
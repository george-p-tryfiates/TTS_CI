using Microsoft.VisualBasic;
using System;

namespace School
{

    /// <summary>
    /// Summary description for Class1
    /// </summary>

    class Person
    {
        
        public int Age { get; internal set; }
        public Person(int age)
        {
            Age = age;

        }
        public string Greet()
        {
            Console.WriteLine("Hello");
            return "Hello";
        }
        internal void SetAge(int n)
        {
            Age = n;
        }
    }

    class Student : Person
    {
        public Student(int age) : base(age)
        {
        }

        public string GoToClasses()
        {
            Console.WriteLine("I'm going to class");
            return "I'm going to class";
        }

        public string ShowAge()
        {
            Console.WriteLine("My age is: {0} years old.", Age);
            return $"My age is: {Age} years old.";
        }
    }

    class Teacher : Person
    {
        public string Explain()
        {
            Console.WriteLine("Explanation begins");
            return "Explanation begins";
        }

        private string subject;

        public Teacher(int age) : base(age)
        {
        }
    }
}
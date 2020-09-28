using System;
using System.Diagnostics;
using Xunit;

namespace School
{
    public class UnitTest1
    {
        [Fact]
        public void PersonTest()
        {
            Person steve = new Person(20);
            Assert.Equal(20, steve.Age);

            string input = steve.Greet();
            Assert.Equal("Hello", input);
        }

        [Fact]
        public void StudentTest()
        {
            Student james = new Student(21);
            string input = james.Greet();
            Assert.Equal("Hello", input);

            james.SetAge(34);
            Assert.Equal(34, james.Age);

            
            string inp = james.ShowAge();
            Assert.Equal("My age is: 34 years old.", inp );

        }

        [Fact]
        public void TeacherTest()
        {
            Teacher teresa = new Teacher(30);
            Assert.Equal(30, teresa.Age);
            string input = teresa.Greet();
            Assert.Equal("Hello", input);
            string inn = teresa.Explain();
            
            Assert.Equal("Explanation begins", inn);
        }
    }
}

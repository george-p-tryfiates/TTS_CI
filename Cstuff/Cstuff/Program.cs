using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cstuff
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n"+"Exercise 1: ");
            Console.WriteLine("Enter three letters without a space: ");
            string input = Console.ReadLine();
            int i = input.Length - 1;
            while (i >=0)
            {
                Console.Write(input[i]+" ");
                i--;
            }
           

            Console.WriteLine("\n"+"Exercise 2: Triangle Output");
            Console.WriteLine("Enter a number to make the contents of a triangle: ");
            string num = Console.ReadLine();
            Console.WriteLine("Enter the width of the triangle: ");
            int w = Convert.ToInt32(Console.ReadLine());
            int h = w;
            while (h > 0)
            {
                for (int p = 0; p < w; p++)
                {
                    Console.Write(num);
                }
                w--;
                h--;
                Console.Write('\n');
            }
            

            Console.WriteLine("\n"+"Exercise 3: Guess your login.");
            string usr = "username";
            string pwd = "password";
            int attempts = 3;
            while (attempts > 0)
            {
                Console.WriteLine("\n"+"Enter username: ");
                string usrGuess = Console.ReadLine();
                Console.WriteLine("Enter password");
                string pwdGuess = Console.ReadLine();
                if (pwd == pwdGuess && usrGuess == usr)
                {
                    Console.WriteLine("Login Successful.");
                    attempts = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry; that is incorrect.");
                    attempts--;
                    if (attempts == 0)
                    {
                        Console.WriteLine("No more login attempts at this time. Try again later!");
                    }
                    else
                    {
                        Console.WriteLine("Please try again!");
                    }
                }   
            }
            

            Console.WriteLine("\n" + "Exercise 4: Input two numbers and perform an operation");
            bool run = true;
            while (run)
            {
                Console.WriteLine("\n" + "Enter a number: ");
                int z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n" + "Enter another: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the operation to perform (+,-,*,/,%)");
                char op = Convert.ToChar(Console.ReadLine());

                if (op == Convert.ToChar("+"))
                    Console.WriteLine("{0} + {1} = {2}", z, x, z+x);
                else if (op == '-')
                    Console.WriteLine("{0} - {1} = {2}", z,x,z-x);
                else if ((op == 'x') || (op == '*'))
                    Console.WriteLine("{0} * {1} = {2}", z,x,z*x);
                else if (op == '/')
                    Console.WriteLine("{0} / {1} = {2}", z,x,z/x);
                else if (op == Convert.ToChar("%"))
                    Console.WriteLine("{0} % {1} = {3}", z,x,z%x);
                else
                    Console.WriteLine("Wrong Character");

                Console.WriteLine("Go again? Enter true or false: ");
                run = Convert.ToBoolean(Console.ReadLine());
            }
           

            Console.WriteLine("\n" + "Exercise 5: Calculate the circumference and area of a circle");
            Console.WriteLine("\n" + "Enter the radius of the circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Specify the units: ");
            string units = Console.ReadLine();
            double pi = Math.PI;
            Console.WriteLine("The circumference of the circle is {0} {1}.", 2 * pi * r, units);
            Console.WriteLine("The area of the circle is {0} {1} squared.", pi * r * r, units);
           

            Console.WriteLine("\n" + "Exercise 6: Generate Values of x = y^2 + 2y + 1");
            Console.Write("The following are (x,y) coordinate pairs that lie along the polynomial: ");
            for (int m = 1; m < 6; m++)
            {
                int y = m;
                Console.WriteLine("({0},{1})", y * y + 2 * y + 1, y);
            }
            

            Console.WriteLine("\n" + "Exercise 7: mph to kph");
            Console.WriteLine("\n" + "Enter the distance in km: ");
            double dist = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time to complete the distance in hours");
            double time = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The velocity is {0} kph.", Math.Round(dist / time), 2);
            //Convert to Miles
            dist = dist / 1.60934;
            Console.WriteLine("The velocity is {0} mph.", Math.Round(dist / time, 2));
         

            Console.WriteLine("\n" + "Exercise 8: Surface Area and Volume of Sphere");
            Console.WriteLine("\n" + "Enter the sphere radius: ");
            double ra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the units: ");
            string u = Console.ReadLine();
            Console.WriteLine("The sphere surface area is {0} {2} squared and the volume is {1} {2} cubed.", Math.Round(4 * Math.PI * ra * ra, 2), Math.Round(4 * Math.PI * ra * ra * ra / 3, 0), u);
           

            Console.WriteLine("\n" + "Exercise 9: Pattern Search");
            Console.WriteLine("\n" + "Enter a character: ");
            string t = Console.ReadLine();
            char ch = Convert.ToChar(t.ToLower());
            if ((ch == 'a') || (ch == 'e') || (ch == 'i') ||
                (ch == 'o') || (ch == 'u'))
                Console.WriteLine("It's a vowel.");
            else if ((ch >= '0') && (ch <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");
           

            Console.WriteLine("\n" +"\n"+"Exercise 10: Are both #'s Even or Odd?");
            Console.WriteLine("\n" + "Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 && b % 2 == 0 || a % 2 != 0 && b % 2 != 0)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");
            

            Console.WriteLine("\n" + "Exercise 11: Convert a decimal to binary");
            Console.WriteLine("\n" + "Enter a number: ");
            int d = Convert.ToInt32(Console.ReadLine());
            string result = "";
            while (d > 1)
            {
                int remainder = d % 2;
                result = Convert.ToString(remainder) + result;
                d /= 2;
            }
            result = Convert.ToString(d) + result;
            Console.WriteLine("Binary: {0}", result);
        }
    }
}

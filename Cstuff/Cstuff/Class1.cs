using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Net;
using System.Data;
using System.ComponentModel;
using System.Transactions;
using System.Collections;

namespace Cstuff
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 1: Build and Print an Array");
            Console.WriteLine();
            Console.WriteLine("Enter integers separated by spaces");
            string input = Console.ReadLine();
            string[] input1 = input.Split(' ');
            Console.WriteLine("Hey, it's the numbers you typed");
            for (int i = 0; i < input1.Length; i++)
            {
                Console.Write(input1[i]+" ");
            }
            */

            /*
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Exercise 2: Reverse order of a list");
            Console.WriteLine();
            Console.WriteLine("Enter integers separated by spaces");
            string input = Console.ReadLine();
            string[] input1 = input.Split(' ');
            Console.WriteLine("Hey, it's the numbers in reverse order");
            for (int i = input1.Length - 1; i >= 0; i--)
            {
                Console.Write(input1[i] + " ");
            }
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 3: Sum the elements in of an array");
            Console.Write("Enter array elements (space-separated integers): ");
            string input = Console.ReadLine();
            string[] input1 = input.Split(' ');
            int[] list = new int[input1.Length];
            for (int i = 0; i < input1.Length; i++)
            {
                list[i] += Convert.ToInt32(input1[i]);
            }
            Console.WriteLine("The sum of the array elements is {0}.", list.Sum());
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 4: Copy elements from an array to another");
            Console.WriteLine("Enter array elements separated by a space: ");
            string input = Console.ReadLine();
            string[] input1 = input.Split(' ');
            Console.WriteLine("First Array: ");
            for (int i = 0; i < input1.Length; i++)
            {
                Console.Write(input1[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Second Array");
            string[] input2 = input1;
            for (int i = 0; i < input2.Length; i++)
            {
                Console.Write(input2[i]+" ");
            }
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 5: Count duplicate elements");
            Console.WriteLine("Enter space-separated elements: ");
            string input = Console.ReadLine();
            string[] input1 = input.Split(' ');
            MatchCollection matches;
            int count = 0;
            for (int i = 0; i < input1.Length; i++)
            {
                Regex rx = new Regex(input1[i]);
                matches = rx.Matches(input);
                if (matches.Count > 1)
                {
                    count += matches.Count - 1;
                }
                input = " ";
                for (int p = i + 1; p < input1.Length; p++)
                {
                    input += input1[p] + " ";
                }
            }
            Console.WriteLine("{0} duplicates found in the array", count);
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 6: Print Unique Elements");
            Console.WriteLine("Enter space-separated elements: ");
            string input = Console.ReadLine();
            string[] input1 = input.Split(' ');
            MatchCollection matches;
            Console.WriteLine("Unique Elements: ");
            for (int i = 0; i < input1.Length; i++)
            {
                Regex rx = new Regex(input1[i]);
                matches = rx.Matches(input);
                if (matches.Count == 1)
                {
                    Console.Write(input1[i] + " ");
                }
            }   
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 7: Merge Arrays of the same size");
            Console.WriteLine("Enter space-separated elements of the first array: ");
            string input = Console.ReadLine();
            string[] input_s1 = input.Split(' ');
            Console.WriteLine("Enter the space-separated elements of the second array: ");
            string input2 = Console.ReadLine();
            string[] input_s2 = input2.Split(' ');
            bool ctrl = true;
            if(input_s1.Length != input_s2.Length)
            {
                ctrl = false;
                Console.WriteLine("Arrays are of different length.");
            }
            string merged = "";

            for (int i = 0; i < input_s1.Length; i++)
            {
               merged += input_s1[i] + " ";
            }
            for (int p = 0; p < input_s2.Length; p++)
            {
               merged += input_s2[p] + " ";
            }

            string[] merged_s = merged.Split(' ');
            List<int> fin = new List<int>();

            for (int p = 0; p < merged_s.Length; p++)
            {
                int num;
                bool success = Int32.TryParse(merged_s[p], out num);
                if (success)
                {
                    fin.Add(num);
                }
            }

            for (int o = 0; o < fin.Count; o++)
            {
                int temp;
                for (int ii = 0; ii < fin.Count - 1; ii++)
                {
                    if (fin[ii] < fin[ii + 1])
                    {
                        temp = fin[ii + 1];
                        fin[ii + 1] = fin[ii];
                        fin[ii] = temp;
                    }
                }
            }

            foreach (var item in fin)
            {
                Console.Write(item + " ");
            }
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 8: Count the frequency of each element in an array");
            Console.WriteLine();
            Console.WriteLine("Enter space-separated array elements");
            string input = Console.ReadLine();
            string[] input_s = input.Split(" ");
            string printed = " ";
            string plural = "time";
            for (int w = 0; w < input_s.Length; w++)
            {
                Regex rx = new Regex(input_s[w]);
                MatchCollection matches = rx.Matches(input);
                
                if (!rx.IsMatch(printed))
                {
                    if (matches.Count > 1){plural = "times";}
                    Console.WriteLine("Element '{0}' occurs {1} {2}.", input_s[w], matches.Count, plural);
                    printed += input_s[w] + " ";
                }
            }
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 9: Find Max and Min.");
            Console.WriteLine();
            Console.WriteLine("Enter space-separated array elements: ");
            int num = 0;
            var input_s = new List<int>();
            string[] input = Console.ReadLine().Split(' ');
            foreach (var item in input)
            {
                int.TryParse(item, out num);
                input_s.Add(num);
            }
            Console.WriteLine("The highest value integer in the array is "+ input_s.Max()+" while the lowest value integer is " + input_s.Min());
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 10: Sort array into an even and an odd array");
            Console.WriteLine();
            Console.WriteLine("Enter space-separated array elements: ");
            int num = 0;
            var input_s = new List<int>();
            string[] input = Console.ReadLine().Split(' ');
            foreach (var item in input)
            {
                int.TryParse(item, out num);
                input_s.Add(num);
            }
            var odd = new List<int>();
            var even = new List<int>();
            foreach (var e in input_s)
            {
                if (e % 2 == 0)
                {
                    even.Add(e);
                } else {
                    odd.Add(e);
                }
            }
            Console.Write("The odd array contains: ");
            foreach (var o in odd)
            {
                Console.Write(o + " ");
            }
            Console.WriteLine();
            Console.Write("The even array contains: ");
            foreach (var el in even)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 11: Sort Ascending");
            Console.WriteLine();
            Console.WriteLine("Enter space-separated integers: ");
            int num;
            var input_s = new List<int>();
            string[] input = Console.ReadLine().Split(' ');
            foreach (var item in input)
            {
                int.TryParse(item, out num);
                input_s.Add(num);
            }
            input_s.Sort();
            foreach (var u in input_s)
            {
                Console.Write(u + " ");
            }
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 12: Sort Descending");
            Console.WriteLine();
            Console.WriteLine("Enter space-separated integers: ");
            int num;
            var input_s = new List<int>();
            string[] input = Console.ReadLine().Split(' ');
            foreach (var item in input)
            {
                int.TryParse(item, out num);
                input_s.Add(num);
            }
            
            var result = from i in input_s
                         orderby i descending
                         select i;
            Console.WriteLine("Ordered Array Descending: ");
            foreach (var val in result)
            {
                Console.Write(val + " ");

            }
            Console.WriteLine();
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 13: Insert New Value to Sorted Array");
            Console.Write("Enter space-separated integers: ");
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine();
            var list = new List<int>();
            int num;
            foreach (var item in input)
            {
                int.TryParse(item, out num);
                list.Add(num);
            }
            list.Sort();
            Console.WriteLine("Enter another integer to insert: ");
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine(num);
            list.Add(num);
            list.Sort();
            Console.WriteLine("The sorted array with integer inserted: ");
            foreach (var i in list)
            {
                Console.Write(i + " ");
            }
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Exercise 14: Add value by position to array");
            Console.WriteLine();
            Console.WriteLine("Enter space-separated elements: ");
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine();
            Console.Write("Enter the new element: ");
            string newItem = Console.ReadLine();
            Console.Write("Enter the position wherein to insert the element: ");
            string num = Console.ReadLine();
            var newb = new List<string>();
            int p = int.Parse(num);

            for (int i = 0; i < p; i++)
            {
                newb.Add(input[i]);
            }

            newb.Add(input[p]);
            
            for (int l = (int)p; l < input.Length; l++)
            {
                newb.Add(input[l]);
            }
            Console.WriteLine("Success nerd: ");
            for (int w = 0; w < newb.Count; w++)
            {
                Console.Write(newb[w] + " ");
            }
           
            Console.WriteLine();
            */

            /*
            Console.WriteLine();
            Console.WriteLine("Ex. 15: Delete element at position");
            Console.WriteLine("Enter space-separated list: ");
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter index of element to delete: ");
            string pos = Console.ReadLine();
            int x = int.Parse(pos);
            var list = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i != x)
                {
                    list.Add(input[i]);
                }
                else { continue; }

            }
            Console.WriteLine("New list: ");
            for (int o = 0; o < list.Count; o++)
            {
                Console.Write(list[o]+ " ");
            }
            */


            Console.WriteLine();
            /*
            Console.WriteLine("Ex. 16: 2nd Largest array element");
            Console.WriteLine("Enter space-separated elements: ");
            string[] input = Console.ReadLine().Split(' ');
            var list = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                list.Add(int.Parse(input[i]));
            }
            Console.WriteLine("Second Largest Element: ");
            int second = 0;
            for (int p = 0; p < list.Count; p++)
            {
                if(list[p] != list.Max())
                {
                    if (second<list[p])
                    {
                        second = list[p];
                    }
                }
            }
            Console.WriteLine(second);
            Console.WriteLine();
            */

            /*
            Console.WriteLine("Ex. 17: Second Smallest");
            Console.WriteLine("Enter space-separated elements: ");
            string[] input = Console.ReadLine().Split(' ');
            var list = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                list.Add(int.Parse(input[i]));
            }
            Console.WriteLine("Second Smallest Element: ");
            int second = list.Max();
            for (int p = 0; p < list.Count; p++)
            {
                if (list[p] != list.Min())
                {
                    if (second > list[p])
                    {
                        second = list[p];
                    }
                }
            }
            Console.WriteLine(second);
            Console.WriteLine();
            */

            /*
            Console.WriteLine("ex. 18: 2D Array");
            int[,] array = new int[3, 3];
            Console.WriteLine("Enter space separated elements with each row as a new line: ");
            string[] textarray0 = Console.ReadLine().Split(' ');
            for (int i = 0; i < 3; i++)
            {
                array[0, i] = int.Parse(textarray0[i]);
            }
            
            
            string[] textarray1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < 3; i++)
            {
                array[1, i] = int.Parse(textarray1[i]);
            }
            
            
            string[] textarray2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < 3; i++)
            {
                array[2, i] = int.Parse(textarray2[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Our matrix: "+ "\n");
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write(array[y, x] + " ");
                }
                Console.Write("\n");
            }
            */

            /*
            Console.WriteLine("ex. 19: Add Square Matrix");
            Console.WriteLine("Enter array size (i.e., Enter 2 for a 2x2 Array): ");
            int size = int.Parse(Console.ReadLine());
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }

            int[,] array1 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for second matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array1[i, p] = int.Parse(textarray[p]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Our matrix: " + "\n");
            for (int y = 0; y < (int)size; y++)
            {
                for (int x = 0; x < (int)size; x++)
                {
                    Console.Write(array0[y, x] + array1[y,x]+ " ");
                }
                Console.Write("\n");
            }
            */

            /*
            Console.WriteLine("ex. 20: Multiply Square Matrix");
            Console.WriteLine("Enter array size (i.e., Enter 2 for a 2x2 Array): ");
            int size = int.Parse(Console.ReadLine());
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }

            int[,] array1 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for second matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array1[i, p] = int.Parse(textarray[p]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Our matrix: " + "\n");
            for (int y = 0; y < (int)size; y++)
            {
                for (int x = 0; x < (int)size; x++)
                {
                    Console.Write(array0[y, x] * array1[y, x] + " ");
                }
                Console.Write("\n");
            }
            */

            /*
            Console.WriteLine("ex. 22: Transpose Square Matrix");
            Console.WriteLine("Enter array size (i.e., Enter 2 for a 2x2 Array): ");
            int size = int.Parse(Console.ReadLine());
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }


            Console.WriteLine();
            Console.WriteLine("Our matrix: " + "\n");
            for (int y = 0; y < (int)size; y++)
            {
                for (int x = 0; x < (int)size; x++)
                {
                    Console.Write(array0[x, y] + " ");
                }
                Console.Write("\n");
            }
            */

            /*
            Console.WriteLine("ex. 23: Sum of Right Diagnals");
            Console.WriteLine("Enter array size (i.e., Enter 2 for a 2x2 Matrix: ");
            int size = int.Parse(Console.ReadLine());
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sum of Right Diagnals");
            int sum = 0;
            int o = 0;
            for (int y = 0; y < (int)size; y++, o++)
            {
                sum += array0[y, o];
            }
            Console.WriteLine(sum);
            */

            /*
            Console.WriteLine("ex. 24: Sum of Left Diagnals");
            Console.WriteLine("Enter array size (i.e., Enter 2 for a 2x2 Matrix: ");
            int size = int.Parse(Console.ReadLine());
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sum of Left Diagnals");
            int sum = 0;
            int o = 0;
            for (int y = (int)size-1; o < (int)size; y--, o++)
            {
                sum += array0[y, o];
            }
            Console.WriteLine(sum);
            */

            /*
            Console.WriteLine("ex. 25: Sum of Rows & Columns");
            Console.WriteLine("Enter array size (i.e., Enter 2 for a 2x2 Matrix: ");
            int size = int.Parse(Console.ReadLine());
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sum of Rows");
        
            for (int y = 0; y < (int)size; y++)
            {
                int rsum = 0;
                for (int x = 0; x < (int)size; x++)
                {
                    rsum += array0[y, x];
                }
                
                Console.Write("Row " + y+ ": " + rsum + "\n");
            }

            Console.Write("\n");
            Console.WriteLine("Sum of Columns");
            for (int x = 0; x < (int)size; x++)
            {
                int csum = 0;
                for (int y = 0; y < (int)size; y++)
                {
                    csum += array0[y, x];
                }

                Console.Write("Column " + x + ": " + csum + "\n");
            }
            */

            /*
            Console.WriteLine("ex. 26: Lower Triangle of Square Matrix");
            Console.WriteLine("Enter array size (i.e., Enter 2 for a 2x2 Array): ");
            int size = int.Parse(Console.ReadLine());
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }


            Console.WriteLine();
            Console.WriteLine("Our matrix: " + "\n");
            for (int y = 0; y < (int)size; y++)
            {
                for (int x = 0; x < (int)size; x++)
                {
                    if (x < y)
                    {
                        array0[y, x] = 0;
                    }
                    Console.Write(array0[y, x] + " ");
                }
                Console.Write("\n");
            }
            */

            /*
            Console.WriteLine("ex. 27: Upper Triangle of Square Matrix");
            Console.WriteLine("Enter array size (i.e., Enter 2 for a 2x2 Array): ");
            int size = int.Parse(Console.ReadLine());
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }


            Console.WriteLine();
            Console.WriteLine("Our matrix: " + "\n");
            for (int y = 0; y < (int)size; y++)
            {
                for (int x = 0; x < (int)size; x++)
                {
                    if (x > y)
                    {
                        array0[y, x] = 0;
                    }
                    Console.Write(array0[y, x] + " ");
                }
                Console.Write("\n");
            }
            */

            /*
            Console.WriteLine("ex. 28: Determinate Square Matrix");
            
            int size = 3;
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }


            Console.WriteLine();
            Console.WriteLine("Determinate: " + "\n");
            
            
            int det = array0[0, 0] * (array0[1, 1] * array0[2, 2] - array0[2, 1] * array0[1, 2]) - array0[1, 0] * (array0[0, 1] * array0[2, 2] - array0[2, 1] * array0[0, 2]) + array0[2, 0] * (array0[0, 1] * array0[1, 2] - array0[1, 1] * array0[0, 2]);
            Console.WriteLine(det);
            */

            /*
            Console.WriteLine("ex. 29: Is the Matrix Sparse?");
            Console.WriteLine("Enter array size (i.e., Enter 2 for a 2x2 Matrix): ");
            int size = int.Parse(Console.ReadLine());
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }

            int count = 0;
            for (int y = 0; y < (int)size; y++)
            {
                for (int x = 0; x < (int)size; x++)
                {
                    if (array0[y,x] == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("There are: " + count + " zero(es).");
            
            if (count >= (array0.Length/2.0) )
            {
                Console.WriteLine("The matrix is sparse.");
            } else
            {
                Console.WriteLine("The matrix is dense.");
            }
            */

            /*
            Console.WriteLine("Ex. 30: Check Equality of Matrices");
            Console.WriteLine("Enter array size (i.e., Enter 2 for a 2x2 Matrix): ");
            int size = int.Parse(Console.ReadLine());
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }

            int[,] array1 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for second matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array1[i, p] = int.Parse(textarray[p]);
                }
            }

            bool test = true;
            Console.WriteLine();
            
            while (test)
            {
                for (int y = 0; y < (int)size; y++)
                {
                    for (int x = 0; x < (int)size; x++)
                    {
                        if (array0[y, x] != array1[y, x])
                        {
                            test = false;
                        }
                  
                    }

                }

                break; 
            }
            if (test)
            {
                Console.WriteLine("The matrices are equal.");
            }
            else
            {
                Console.WriteLine("The matrices are not equal.");
            }
            */

            Console.WriteLine("Ex. 30: Check Equality of Matrices");
            Console.WriteLine("Enter array size (i.e., Enter 2 for a 2x2 Matrix): ");
            int size = int.Parse(Console.ReadLine());
            int[,] array0 = new int[(int)size, (int)size];
            Console.WriteLine("Enter space separated elements with each row as a new line for first matrix: ");
            for (int i = 0; i < (int)size; i++)
            {
                string[] textarray = Console.ReadLine().Split(' ');
                for (int p = 0; p < (int)size; p++)
                {
                    array0[i, p] = int.Parse(textarray[p]);
                }
            }

            int[,] identity = new int[(int)size, (int)size];
            for (int i = 0; i < (int)size; i++)
            {
                for (int p = 0; p < (int)size; p++)
                {
                    if (i == p)
                    {
                        identity[i, p] = 1;
                    }
                    else
                    {
                        identity[i, p] = 0;
                    }
                    
                }
            }

            bool test = true;
            Console.WriteLine();

            while (test)
            {
                for (int y = 0; y < (int)size; y++)
                {
                    for (int x = 0; x < (int)size; x++)
                    {
                        if (array0[y, x] != identity[y, x])
                        {
                            test = false;
                        }

                    }

                }

                break;
            }
            if (test)
            {
                Console.WriteLine("This is an identity matrix.");
            }
            else
            {
                Console.WriteLine("This is not an identity matrix.");
            }





        }
               

            

    }
}  



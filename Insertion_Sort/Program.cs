using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            string[] students = { "Eve","Charlie","Bob","David","Alice" };

            Console.WriteLine("Original List of Students:");
            PrintStudents(students);
            //apply insertion sort
            InsertionSort(students);
          

            Console.WriteLine("Sorted List of Students:");
            PrintStudents(students);
        }

        static void InsertionSort(string[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                string key = arr[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(arr[j], key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        static void PrintStudents(string[] students)
        {
            foreach (string student in students)
            {
                Console.WriteLine(student);
                Console.ReadLine();
            }
        }
    }

}


    


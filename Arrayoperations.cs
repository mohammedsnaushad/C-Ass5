using System;
namespace CSharpProgram
{
    class ArrayProgram
    {
        static void Main(string[] args)
        {
            // Creating an array  
            int[] numbers= new int[6] { 9, 10, 32, 1, 11, 4 };
            // Creating an empty array  
            int[] sample = new int[6];
            // Displaying length of array  
            Console.WriteLine("Length of the first array= " + numbers.Length);
            // Sorting array  
            Array.Sort(numbers);
            Console.Write("First array elements after sorting : ");
            // Displaying sorted array  
            PrintArray(numbers);
            // Finding index of an array element  
            Console.WriteLine("\nIndex position of 4 is " + Array.IndexOf(numbers, 4));
            // Coping first array to empty array  
            Array.Copy(numbers, sample, numbers.Length);
            Console.Write("The array elements copied to second array are:");
            // Displaying second array  
            PrintArray(sample);
            Array.Reverse(numbers);
            Console.Write("\nFirst Array after reverse function is used : ");
            PrintArray(numbers);
        }
        // User defined method for iterating array elements  
        static void PrintArray(int[] numbers)
        {
            foreach (Object items in numbers)
            {
                Console.Write(items + " ");
            }
        }
    }
}
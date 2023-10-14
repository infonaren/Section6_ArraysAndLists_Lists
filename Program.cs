using System;
using System.Collections.Generic;


namespace Section6_ArraysAndLists_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4};

            // Add() => Adds an object to the end of the List<T>.
            numbers.Add(1);

            // AddRange() => Adds the elements of the specified collection to the end of the List<T>.
            numbers.AddRange(new int[3] {5,6,7});

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            // IndexOf()
            // => Returns the zero-based index of the first occurrence of a value in the List<T> or in a portion of it.
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));

            // LastIndexOf() 
            // Returns the zero - based index of the last occurrence of a value in the List<T> or in a portion of it.
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            // Count()
            // Returns the number of elements in the list
            Console.WriteLine("Count: "+numbers.Count);

            for ( var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    // Remove() 
                    // Removes the first occurrence of a specific object from the List<T>.
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
                Console.WriteLine(number);


            // CLear()
            // Removes all elements from the List<T>.
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}

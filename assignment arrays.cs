using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  1)
            //Console.Write("Enter numbers separated by spaces: ");
            //string[] numbersInput = Console.ReadLine().Split(' ');
            //int[] numbersArray = new int[numbersInput.Length];
            //for (int i = 0; i < numbersInput.Length; i++)
            //{
            //    numbersArray[i] = Convert.ToInt32(numbersInput[i]);
            //}
            //int[] storageArray = new int[numbersArray.Length];
            //int counter = 0;
            //for (int j = 0; j < numbersArray.Length; j++)
            //{
            //    bool check = false;
            //    for (int k = 0; k < counter; k++)
            //    {
            //        if (numbersArray[j] == numbersArray[k])
            //        {
            //            check = true;
            //            break;
            //        }
            //    }
            //    if (check == false)
            //    {
            //        storageArray[counter] = numbersArray[j];
            //        counter++;
            //    }
            //}
            //int[] outputArray = new int[counter];
            //for (int i = 0; i < outputArray.Length; i++)
            //{
            //    outputArray[i] = storageArray[i];
            //}

            //Console.WriteLine("Array without duplicates:");
            //foreach (int num in outputArray)
            //{
            //    Console.Write(num + " ");
            //}
            // 2)
            //int[] numbersarray = { 7, 8, 9, 10 };
            ////Console.WriteLine("Numbers in the array are\n");
            //int largest = int.MinValue;
            //int secondlargest = int.MinValue;
            //foreach (int i in numbersarray)
            //{
            //    if (i > largest)
            //    {
            //        largest = i;
            //        secondlargest = largest;
            //    }

            //    else if (i > secondlargest && i != largest)
            //    {
            //        secondlargest = i;
            //    }
            //    Console.WriteLine("largest element: " + largest);
            //    Console.WriteLine("secondlargest element: " + secondlargest);
            //}

            //3
            //int[] numarray = { 0, 0, 1, 2, 0 };
            //Console.WriteLine("Original array!");
            //PrintArray(numarray);

            //MoveZerosToEnd(numarray);

            //Console.WriteLine("Array afte moving zeros to end");
            //PrintArray(numarray);

            // void MoveZerosToEnd(int[] arr)
            //{
            //    int n = arr.Length;
            //    int nonzeroindex = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (arr[i] != 0)
            //        { arr[nonzeroindex++] = arr[i]; }
            //    }
            //    while (nonzeroindex < n)
            //    {
            //        arr[nonzeroindex++] = 0;
            //    }


            //}
            // void PrintArray(int[] arr)
            //{
            //    foreach (int num in arr)
            //    {
            //        Console.Write(num + " ");
            //    }
            //   Console.WriteLine();
            //}

            //4)
            //    Console.Write("Enter a string: ");
            //    string input = Console.ReadLine();
            //    char? result = Findfirstnonrepeatingcharacter(input);

            //    if (result.HasValue)
            //    {
            //        Console.WriteLine("The first nonrepeating character is:" + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("All the numbers repeat or the string is empty");
            //    }

            //}

            //static char? Findfirstnonrepeatingcharacter(string str)
            //{
            //    int[] charcount = new int[256];

            //    foreach (char c in str)

            //    {
            //        charcount[c]++;
            //    }
            //    foreach (char c in charcount)

            //    {
            //        if (charcount[c] == 1)
            //        {
            //            return c;
            //        }


            //    }
            //    return null;
            //}

            //5)
            //    int[] arr1 = { 1, 3, 5 };
            //    int[] arr2 = { 2, 4, 6 };
            //    int[] mergedarray = MergedSortedArrays(arr1, arr2);

            //    Console.WriteLine("mergedarray");
            //    foreach (var num in mergedarray)
            //    {
            //        Console.Write(num + " ");
            //    }
            //    Console.WriteLine();

            //}
            //static int[] MergedSortedArrays(int[] arr1, int[] arr2)
            //{
            //   int[] mergedarray = new int[arr1.Length + arr2.Length];
            //    int i = 0, j = 0, k = 0;

            //    while (i < arr1.Length && j < arr2.Length)
            //    {
            //        if (arr1[i] < arr2[j])
            //        {
            //            mergedarray[k++] = arr1[i++];
            //        }
            //        else
            //        {
            //            mergedarray[k++] = arr2[j++];
            //        }
            //    }
            //    while (i < arr1.Length)
            //    {
            //        mergedarray[k++] = arr1[i++];
            //    }
            //    while (j < arr2.Length)
            //    {
            //        mergedarray[k++] = arr2[j++];
            //    }

            //    return mergedarray;

            //6)
            //    int[] array = { 3, 1, 0, 4 };
            //    int missingnumber = FindMissingNumber(array);
            //    Console.WriteLine($"The missing number is: " + (missingnumber));

            //}
            //static int FindMissingNumber(int[] nums)

            //{
            //    int n = nums.Length;
            //    int expectedsum = n * (n + 1) / 2;
            //    int actualsum = 0;
            //    foreach (int num in nums)
            //    {
            //        actualsum += num;
            //    }

            //    return expectedsum - actualsum;
            //7)
            //    int number = 153;
            //    bool IsArmstrong = FindArmstrong(number);
            //    Console.WriteLine($"{number} is an Armstrong number");

            //}
            //static bool FindArmstrong(int number)
            //{
            //    int originalnumber = number;
            //    int sum = 0;

            //    // Calculate the sum of cubes of digits
            //    while (number > 0)
            //    {
            //        int digit = number % 10;
            //        sum += digit * digit * digit;
            //        number /= 10;
            //    }
            //    return sum == originalnumber;

            //8)
            //{
            //    string[] strs = { "interstellar", "internet", "intermediate" };
            //    string longestCommonPrefix = LongestCommonPrefix(strs);

            //    Console.WriteLine("Longest Common Prefix: " + longestCommonPrefix);
            //}

            // string LongestCommonPrefix(string[] strs)
            //{
            //    if (strs == null || strs.Length == 0)
            //        return "";

            //    // Start with first string as the initial prefix
            //    string prefix = strs[0];

            //    // Iterate through the array of strings
            //    for (int i = 1; i < strs.Length; i++)
            //    {
            //        // Compare prefix with each string in the array
            //        while (!strs[i].StartsWith(prefix))
            //        {
            //            // Reduce the prefix by one character from the end
            //            prefix = prefix.Substring(0, prefix.Length - 1);

            //            // If no common prefix exists
            //            if (prefix.Length == 0)
            //                return "";
            //        }
            //    }

            //    return prefix;

            //9
            /* Console.Write("Enter the number of terms for Fibonacci sequence: ");
             int n = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("\nFibonacci Sequence:");
             PrintFibonacciSequence(n);
         }

         static void PrintFibonacciSequence(int n)
         {
             int first = 0, second = 1;

             // Print the first and second terms

             Console.Write($"{first} {second}");

             for (int i = 2; i < n; i++)
             {
                 int next = first + second;
                 Console.Write($" {next}");
                 first = second;
                 second = next;
             }

             Console.WriteLine();  // Move to the next line after printing the sequence
           */
           //10
           /* int N = 0;

            // Prompt user for input until a valid integer is entered
            while (true)
            {
                Console.Write("Enter N: ");
                string input = Console.ReadLine();

                try
                {
                    N = int.Parse(input);
                    break; // Exit the loop if input is successfully parsed
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Input is too large or too small for an integer.");
                }
            }

            int[] values = new int[N];

            // Read input values
            for (int i = 0; i < N; i++)
            {
                while (true)
                {
                    Console.Write($"Enter value {i + 1}: ");
                    string input = Console.ReadLine();

                    try
                    {
                        values[i] = int.Parse(input);
                        break; // Exit the loop if input is successfully parsed
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Input is too large or too small for an integer.");
                    }
                }
            }

            // Variables to store counts, total, and average
            int positiveCount = 0;
            int negativeCount = 0;
            int total = 0;
            double average = 0.0;

            // Calculate counts and total
            foreach (var value in values)
            {
                if (value > 0)
                {
                    positiveCount++;
                }
                else if (value < 0)
                {
                    negativeCount++;
                }

                total += value;
            }

            // Calculate average only if N > 0
            if (N > 0)
            {
                average = (double)total / N;
            }

            // Output results
            Console.WriteLine($"The number of positive numbers: {positiveCount}");
            Console.WriteLine($"The number of negative numbers: {negativeCount}");
            Console.WriteLine($"Total is: {total}");
            Console.WriteLine($"Average is: {average}"); */


        }
    }

}
    

    

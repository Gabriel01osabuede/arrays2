using System;
using System.Linq;

namespace arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] studentsListsNames = {"Elijah","Ekene","AndreW","Sarah","precious"};
            int length = studentsListsNames.Length;
            
            // Console.WriteLine(studentsListsNames.Length);
            // Console.WriteLine(studentsListsNames.IsFixedSize);
            // Console.WriteLine(studentsListsNames.GetValue(3));
            // Console.WriteLine(studentsListsNames.GetUpperBound(0));
            // Console.WriteLine(studentsListsNames.IsReadOnly);
            // //Console.WriteLine(studentsListsNames.GetType());
            // Console.WriteLine(studentsListsNames.GetHashCode());
            // Array.Reverse(studentsListsNames);
            // Console.WriteLine(studentsListsNames[0]);
            //var find = Array.Find(studentsListsNames,(e => e.Contains("E")));
            var find1 = Array.Find(studentsListsNames,(e => e.Contains("Eke")));
            var find2 = Array.Find(studentsListsNames,(e => e.EndsWith("E")));
            var find3 = Array.Find(studentsListsNames,(e => e.StartsWith("E")));
            var find4 = Array.FindIndex(studentsListsNames,0,length,(e => e.StartsWith("E")));
            var find5 = Array.LastIndexOf(studentsListsNames,"Ekene");
            //Console.WriteLine(find);
            //Console.WriteLine(find5);

            int[] strangeNumbers = {67,23,12,45,23,11,91,81,9,0,5,3,2,6,1,7};
            int mynumberlength = strangeNumbers.Length;
            Array.Clear(strangeNumbers,3,5);
            //Console.WriteLine(strangeNumbers[2]);
            // foreach(var number in strangeNumbers)
            // {
            //     //Console.WriteLine(number);
            // }
            
            // foreach(var number in strangeNumbers)
            // {
            //     Console.WriteLine(number);
            // }

            // Console.WriteLine();
            // Array.Sort(strangeNumbers);

            // foreach(var number2 in strangeNumbers)
            // {
            //     Console.WriteLine(number2);
            // } 
            // Console.WriteLine();
            // Array.Sort(strangeNumbers);

            // foreach(var number2 in strangeNumbers)
            // {
            //     Console.WriteLine(number2);
            // } 
            
            // Console.WriteLine();
            // Array.Reverse(strangeNumbers);

            // foreach(var number3 in strangeNumbers)
            // {
            //     Console.WriteLine(number3);
            // } 
            
            // Console.WriteLine();
            // Array.Sort(studentsListsNames);

            // foreach(var number4 in studentsListsNames)
            // {
            //     Console.WriteLine(number4);
            // } 

            //Class example.
            int[] arrayOfNumbers = {23,47,89,64,102,90,2,5,10};
            Array.Reverse(arrayOfNumbers);
            int total = 0;
            foreach(var numbers in arrayOfNumbers)
            {
                Console.WriteLine($"The Reverse Numbers + 5 = {numbers + 5}");
               total += numbers;
                
            }
            
            Console.WriteLine($"The total of all numbers = {total}");

            
            //using linq namespace to sum.
           int allNumbers = arrayOfNumbers.Sum();
           Console.WriteLine($"\nThe Total of all numbers = {allNumbers}");
           
            
            
        }
    }
}

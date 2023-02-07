using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace CollectionsMasterConsoleUI
{
    class Program
    {

        public static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(numbers.Length);
                
            }          
        }
        public static void ReverseArray(int[] array)
        {
            int i = 0;
            int indexNo = array.Length - 1;
            while (i < indexNo)
            {
                var temp = array[i];
                array[i] = array[indexNo];
                array[indexNo] = temp;
                i++;
                indexNo--;
            }
        }
        public static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i <numbers.Length - 1; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                    Console.WriteLine(numbers[i]);
                        }
                else
                    Console.WriteLine(numbers[i]);
               
            }                                   
           
        }
        public static void Populater(List<int> numberList, int max)
        {
            for (int i = 0; i <= max; i++)
            { 
            Random rng = new Random();
            numberList.Add(rng.Next(max));
            }
        }
        public static void NumberChecker(List<int> numberList)
        {
            int searchNumber;
            bool isANumber;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out searchNumber);
            } while (isANumber == false);


            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("Your number is on the list!");
            }
            else
                Console.WriteLine("Your number is not on the list.");       
        
        }
        private static void OddKiller(List<int> numberList) 
        {            
           for (int i = numberList.Count- 1; i > -1; i--)
            {
                if (numberList[i]%2 != 0)
                {
                    numberList.RemoveAt(i);
                }                
                
             }
           NumberPrinter(numberList);
        }

        static void Main(string[] args)
        {
                     

            #region Arrays                  
            int[] arrayOf50 = new int[50] ; 
            Populater(arrayOf50);
            Console.WriteLine($"First number in array = {arrayOf50[0]} Last number in array = {arrayOf50[49]}"); 
            Console.WriteLine("All Numbers Original");          
            NumberPrinter(arrayOf50);


            Console.WriteLine("-------------------");                      
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(arrayOf50);
            NumberPrinter(arrayOf50);


            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(arrayOf50);
            NumberPrinter(arrayOf50);


            Console.WriteLine("-------------------");           
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(arrayOf50);


            Console.WriteLine("-------------------");
            Console.WriteLine("Sorted numbers:");
            Array.Sort(arrayOf50);
            NumberPrinter(arrayOf50);


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion


            #region Lists
            Console.WriteLine("************Start Lists**************");

            var intList = new List<int>();
            Console.WriteLine($" List capacity: {intList.Capacity}");
            Populater(intList, 50);
            Console.WriteLine($" List capacity: {intList.Capacity}");


            Console.WriteLine("---------------------");         
            NumberChecker(intList);


            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers:");        
            NumberPrinter(intList);


            Console.WriteLine("-------------------");
            Console.WriteLine("Evens Only!!");
            OddKiller(intList);


            Console.WriteLine("------------------");           
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);   
            

            Console.WriteLine("------------------");
            int[] listToArray = intList.ToArray();                                  
            intList.Clear();
            
            

            #endregion
        }


        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

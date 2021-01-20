using System;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort begin!");
            
            int[] inputArray = { 4, 6, 8, 2, 3, 1, 7, 5 };

            for(int i = 0; i < inputArray.Length; i++)
            {
                int smallestNumber = inputArray[i];
                for(int j = i + 1; j < inputArray.Length; j++ )
                {
                    if(smallestNumber > inputArray[j])
                    {
                        smallestNumber = inputArray[j];
                        inputArray[j] = inputArray[i];
                        inputArray[i] = smallestNumber;
                    }
                }            
            }
            for(int k = 0; k < inputArray.Length; k++)
            {
                Console.WriteLine(inputArray[k] + Environment.NewLine);
            }         
            Console.ReadKey();
        }  
    }
}

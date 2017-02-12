using System;


namespace CustomSizedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please set array size"); //asking user to set array size

            int size = Convert.ToInt32(Console.ReadLine()); // converting specified array size to int

            int[] array = new int[size];

            //assigning value for each array item
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Please set value for element {0}", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
               
            }

            int max = 0;
            int min = array[0];

            for (int i = 0; i < size; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine("Min value in the array is {0}", min);
            Console.WriteLine("Max value in the array is {0}", max);
            Console.ReadKey();

        }
    }
}
using System;


namespace Insertion
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
                Console.WriteLine("Please set value for element {0}", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            InsertionSort(array);
        }

        public static void InsertionSort(int[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                int position = i;
                while (i > 0)
                {
                    if (array[i] < array[i - 1])
                    {
                        Swap(array, i - 1, i);
                        i--;
                    }
                    else
                    {
                        i--;
                    }
                }    
                i = position;
            }
        }

        public static int[] Swap(int[] input, int position1, int position2)
        {

            int temp = input[position1];
            input[position1] = input[position2];
            input[position2] = temp;

            return input;

        }
    }
}

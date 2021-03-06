﻿using System;


namespace BubbleSort
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
            Bubble(array);
        }


        public static int[] Bubble(int[] array)
        {
            int j = 1;
            while (j != 0)
            {
                j = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        j = 1;
                    }
                }
            }
            return array;
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

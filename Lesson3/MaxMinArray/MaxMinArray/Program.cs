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
                Console.WriteLine("Please set value for element {0}", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            int max = DefineMax(array);
            int min = DefineMin(array);

            Console.WriteLine("Min value in the array is {0}", min);
            Console.WriteLine("Max value in the array is {0}", max);
            Console.ReadKey();

        }

        public static int DefineMax(int[] inPut)
        {
            int max = inPut[0];
            for (int i = 0; i < inPut.Length; i++)
            {
                if (inPut[i] > max)
                {
                    max = inPut[i];
                }
            }
            return max;
        }

        public static int DefineMin(int[] inPut)
        {
            int min = inPut[0];
            for (int i = 0; i < inPut.Length; i++)
            {
                if (inPut[i] < min)
                {
                    min = inPut[i];
                }
            }
            return min;
        }

           

        
    }
}
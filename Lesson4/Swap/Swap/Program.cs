using System;


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

        //int a = 1;
        //int b = 3; 
        //Swap(array, a, b);
        //Console.WriteLine("Element #{0} is {1}", a+1, array[a]);
        //Console.WriteLine("Element #{0} is {1}", b+1, array[b]);

        //Console.ReadKey();


        public static int[] Swap(int[] input, int position1, int position2)
        {

            int temp = input[position1];
            input[position1] = input[position2];
            input[position2] = temp;

            return input;

        }
    }
}

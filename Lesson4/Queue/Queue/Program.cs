using System;


namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[5];
            int count = 0;
            int head = 0;
            int tail = 0;

            //pushing array by i values
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                
                Enqueue(array, ref count, ref tail, rand.Next(10));
            }

            
            //popping i values from array
            for (int i = 0; i < 4; i++)
            {
                int a = Dequeue(array, ref count, ref head);
            }
        }
        public static bool IsEmpty (int[] array, ref int count)
        {
             if (count == 0)
             {
                 return true;
             }
          return false;
        }

        public static bool IsFull (int[] array, ref int count)
        {
            if (count == array.Length)
            {
                return true;
            }
            return false;
        }

        public static void Enqueue (int[] array, ref int count, ref int tail, int value)
        {
            if (IsEmpty(array, ref count))
            {
                array[0] = value;
                tail = 1;
                count = 1;
            }
            if (!IsFull(array, ref count))
            {
                array[tail] = value;
                tail++;
                count++;
            }
            else
            {
                Console.WriteLine("Queue is full, nothing will be enqueued");
            }
            if (tail >= array.Length)
            {
                tail = tail - array.Length;
            }
        }

        public static int Dequeue (int[] array, ref int count, ref int head)
        {
            int value = 0;
            if (!IsEmpty(array, ref count))
            {
                value = array[head];
                head++;
                count--;
            }
            else
            {
                Console.WriteLine("Queue is empty, nothing to dequeue");
            }
            if (head >= array.Length)
            {
                head = head - array.Length;
            }
            return value;
        }
    }
    }


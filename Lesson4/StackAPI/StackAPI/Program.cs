using System;


namespace StackAPI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int top = 0;
            int?[] array = new int?[5];

            //pushing array by i values
            for (int i = 0; i < 4; i++)
            {
                Random rand = new Random();
                Push(rand.Next(10), ref top, array);
             }

            int? peeked = Peek(ref top, array);

            //popping i values from array
            for (int i = 0; i < 4; i++)
            {
                int? a = Pop(ref top, array);
            }
        }
        public static bool Full(ref int top, int?[] array )
        {
            if (top - 1 == array.Length)
            {
                return true;
            }
            return false;
        }

        public static bool Empty(ref int top, int?[] array)
        {
            if (array[top] == null)
            {
                return true;
            }
            return false;
        }

        public static void Push (int valueToPush, ref int top, int?[] array)
        {
            if (Empty(ref top, array))
            {
                array[top] = valueToPush;
                            }
            else if (!Full(ref top, array))
            {
                top++;
                array[top] = valueToPush;
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public static int? Pop (ref int top, int?[] array)
        {
            if (!Empty(ref top, array))
            {
                int? popped = array[top];
                array[top] = null;
                top--;
                return popped;
            }
            return null;
        }

        public static int? Peek (ref int top, int?[] array)
        {
            if (!Empty(ref top, array))
            {
                int? peeked = array[top];
                return peeked;
            }
            return null;
        }

       
    }
}

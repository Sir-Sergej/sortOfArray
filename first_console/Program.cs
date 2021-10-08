using System;

namespace first_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[10];
            for(int i = 0; i < 10; i++)
            {
                values[i] = Int32.Parse(Console.ReadLine());
            }

            foreach(int value in values)
            {
                Console.Write(value + " ");
            } Console.WriteLine();

            sortFunction(values);

            foreach(int value in values)
            {
                Console.Write(value + " ");
            }
        }

        static void sortFunction(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int k = i + 1; k < array.Length; k++)
                {
                    if(array[i] <= array[k])
                    {
                        int temp = array[i];
                        array[i] = array[k];
                        array[k] = temp;
                        
                    }
                }
            }
        }
    }
}

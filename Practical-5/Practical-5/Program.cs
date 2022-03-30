
using System;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 11,22,33,44,55};

            for(int i=0; i<=arr.Length; i++)
            {
                try
                {
                    Console.WriteLine("Index: " + arr[i]);
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("This is Finally Block");
                }
                
            }
        }
    }
}

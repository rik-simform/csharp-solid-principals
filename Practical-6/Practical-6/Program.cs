using System;

namespace Practical_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Process bl = new Process();
            bl.ProcessCompleted += ProcessCompleted; 
            bl.StartProcess();
        }

        public static void ProcessCompleted()
        {
            Console.WriteLine("Method Invoked");
        }
    }
}

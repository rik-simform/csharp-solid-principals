using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    internal class Polymorphism_example
    {
        public class bird
        {
            public void Voice()
            {
                Console.WriteLine("Turr Turr");
            }
        }

        public class Duck : bird
        {
            public void Voice()
            {
                Console.WriteLine("Quack Quack");
            }
        }
    }
}

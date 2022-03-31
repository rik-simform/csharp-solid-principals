using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    internal class Abstraction_Example
    {
        public class laptop
        {
            private string brand;
            private string model;

            public void LaptopDetails()

            {

                Console.WriteLine("Brand: " + brand);

                Console.WriteLine("Model: " + model);

            }

            private void MotherBoardInfo()

            {

                Console.WriteLine("MotherBoard Information");

            }
        }
    }
}

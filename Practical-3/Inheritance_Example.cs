using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    internal class Inheritance_Example
    {
        public class Sponsor
        {
            protected string owner = "Rakuteen";
        }

        public class Team : Sponsor
        {
            private string teamName = "Team-Mavericks";

            public void PrintInfo()
            {
                Console.WriteLine(String.Concat(owner, teamName));
            }
        }
    }
}

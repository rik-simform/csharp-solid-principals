using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7
{
    internal class DIP
    {
        public interface Developer
        {
            public void develop();
        }
        public class BackEndDeveloper : Developer
        {
            public void develop()
            {
                this.Java();
            }
            public void Java()
            {
                Console.WriteLine("JAVA is BackEnd Language");
            }
        }
        public class FrontEndDeveloper : Developer
        {
            public void develop()
            {
                this.JavaScript();
            }
            public void JavaScript()
            {
                Console.WriteLine("JAVASCRIPT is FrontEnd Language");
            }
        }
        public class project
        {
            public void implement(Developer d)
            {
                d.develop();
            }
        }
    }
}

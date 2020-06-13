using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class OPPO : Smartphone
    {
        public override void subBrand()
        {
            Console.WriteLine("OPPO memiliki sub-brand Realme.");
        }

        public override void OS()
        {
            Console.Write("OPPO memiliki");
        	Console.WriteLine(" sistem operasi ColorOS.");
        }
    }
}
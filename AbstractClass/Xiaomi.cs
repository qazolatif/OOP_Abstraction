using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class Xiaomi : Smartphone
    {
        public override void subBrand()
        {
            Console.WriteLine("Xiaomi memiliki sub-brand Redmi.");
        }

        public override void OS()
        {
            Console.WriteLine("Xiaomi memiliki sistem operasi MIUI.");
        }
    }
}
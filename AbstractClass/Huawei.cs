using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class Huawei : Smartphone
    {
        public override void subBrand()
        {
            Console.WriteLine("Huawei memiliki sub-brand Honor.");
        }

        public override void OS()
        {
            Console.Write("Huawei memiliki");
            Console.WriteLine(" sistem operasi Harmony.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.Interface
{
    public class IXiaomi : IFounder, IOffice
    {
        public void Founder()
        {
            Console.WriteLine("Xiaomi didirikan oleh Lei Jun.");
        }

        public void officeAddress()
        {
            Console.WriteLine("Xiaomi berkantor di Beijing, China.");
        }
    }
}

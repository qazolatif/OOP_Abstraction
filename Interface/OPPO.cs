using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.Interface
{
    public class IOPPO : IFounder, IOffice
    {
        public void Founder()
        {
            Console.WriteLine("OPPO didirikan oleh Tony Chen.");
        }

        public void officeAddress()
        {
            Console.WriteLine("OPPO berkantor di Dongguan, China.");
        }
    }
}
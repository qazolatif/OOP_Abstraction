using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.AbstractClass
{
    public abstract class Smartphone
    {
        public abstract void subBrand();
        public abstract void OS();

        public void Games()
        {
            Console.Write("Perangkat ini dapat digunakan untuk");
            Console.WriteLine(" bermain games menggunakan layar sentuh.");
        }

        public void Calling()
        {
        	Console.Write("Perangkat ini dapat digunakan untuk");
        	Console.WriteLine(" menelepon menggunakan sinyal.");
        }

        public void Internet()
        {
        	Console.Write("Perangkat ini dapat digunakan untuk");
            Console.WriteLine(" mengakses internet.");
        }
    }
}
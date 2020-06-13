using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abstraction.AbstractClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone sp;
            IFounder founder;
            IOffice office;

            sp = new Huawei();
            founder = new IHuawei();
            office = new IHuawei();
            founder.Founder();
            office.officeAddress();
            sp.subBrand();
            sp.OS();
            sp.Games();
            sp.Calling();
            sp.Internet();

            Console.WriteLine();

            sp = new OPPO();
            founder = new IOPPO();
            office = new IOPPO();
            founder.Founder();
            office.officeAddress();
            sp.subBrand();
            sp.OS();
            sp.Games();
            sp.Calling();
            sp.Internet();

            Console.WriteLine();

            sp = new Xiaomi();
            founder = new IXiaomi();
            office = new IXiaomi();
            founder.Founder();
            office.officeAddress();
            sp.subBrand();
            sp.OS();
            sp.Games();
            sp.Calling();
            sp.Internet();

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.Interface
{
    public class IHuawei : IFounder, IOffice
    {
        public void Founder()
        {
            Console.WriteLine("Huawei didirikan oleh Ren Zhengfei.");
        }

        public void officeAddress()
        {
            Console.WriteLine("Huawei berkantor di Shenzhen, China.");
        }
    }
}

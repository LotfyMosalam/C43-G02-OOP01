﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {

        public TypeB() 
        {
            TypeA typeA = new TypeA();
            //typeA.x = 10; // InValid
            typeA.y = 20;   // Valid
            typeA.z = 30;   // Valid
        }

    }
}

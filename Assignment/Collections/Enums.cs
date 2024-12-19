using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Collections
{
    enum DayOfWeek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    enum Seasons
    {
        Spring, Summer, Autumn, Winter
    }


    [Flags]
    enum Permissions : byte
    {
        Read = 1, Write = 2, Delete = 4, Execute = 8
    }


    [Flags]
    enum Colors
    {
        Red = 1, Green = 2, Blue = 4,
    }
}

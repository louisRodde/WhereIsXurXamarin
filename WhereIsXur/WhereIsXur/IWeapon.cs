using System;
using System.Collections.Generic;
using System.Text;

namespace WhereIsXur
{
    interface IWeapon
    {
        String Name { get; }
        String Classe { get; }
        String Type { get; }
        String Effect { get; }
        String Image { get; }
    }
}

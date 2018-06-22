using System;
using System.Collections.Generic;
using System.Text;

namespace WhereIsXur
{
    class FabriqueWeapon
    {
        public static IWeapon CreateWeapon(String name, String classe, String type, String effect, string image)
        {
            return new Weapon { Name = name, Classe = classe, Type = type, Effect = effect, Image = image };
        }

        public static IWeapon CreateWeapon()
        {
            return new Weapon();
        }
    }
}

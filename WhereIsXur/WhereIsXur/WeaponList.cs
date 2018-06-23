using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WhereIsXur
{
    [XmlRoot(ElementName = "weapons")]
    public class WeaponList
    {
        public WeaponList() {
            this.weapons = new List<Weapon>();
        }

        [XmlArray(ElementName = "weapons")]
        [XmlArrayItem(ElementName = "weapon", Type = typeof(Weapon))]
        public List<Weapon> weapons { get; set; }

        public void AddWeapon()
        {
            this.weapons.Add(FabriqueWeapon.CreateWeapon() as Weapon);
        }
    }
}

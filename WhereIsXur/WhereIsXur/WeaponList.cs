using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WhereIsXur
{
    [XmlRoot(Namespace = "WhereIsXur", ElementName = "weapons", IsNullable = true)]
    public class WeaponList
    {
        public List<Weapon> weapons { get; set; }
    }
}

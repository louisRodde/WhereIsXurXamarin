using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace WhereIsXur
{
    public class Tools
    {
        public static void GetWeapons()
        {
            //List<Weapon> weapons;

            //String[] lines = File.ReadAllLines(@"C:/travail/Xamarin/WhereIsXur/WhereIsXur/weapons.xml", System.Text.Encoding.UTF8);

            //StringBuilder sb = new StringBuilder();

            //foreach(String line in lines)
            //{
            //    //Console.WriteLine(line);

            //    sb.Append(line);
            //}

            WeaponList list;

            //String result = sb.ToString();

            XmlSerializer serializer = new XmlSerializer(typeof(WeaponList));
            using (Stream stream = File.OpenRead(@"C:/travail/Xamarin/WhereIsXur/WhereIsXur/weapons.xml"))
            {
                var xmlSerializer = new XmlSerializer(typeof(WeaponList));


                list = xmlSerializer.Deserialize(stream) as WeaponList;

            }

            using (Stream s = new FileStream("lop.xml", FileMode.Create))
            {
                serializer.Serialize(s, list);
            }
            /*
            using (Stream s = File.Create("toto.xml"))
            {
                serializer.Serialize(str, new WeaponList());
            }
            */

            foreach (var item in list.weapons)
            {
                Console.WriteLine(item.Classe);
           }
           
        }
    }
}

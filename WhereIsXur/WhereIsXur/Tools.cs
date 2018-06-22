using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace WhereIsXur
{
    public class Tools
    {
        public static String GetWeapons()
        {
            List<Weapon> weapons;

            String[] lines = File.ReadAllLines(@"C:/travail/Xamarin/WhereIsXur/WhereIsXur/weapons.xml", System.Text.Encoding.UTF8);

            StringBuilder sb = new StringBuilder();

            foreach(String line in lines)
            {
                //Console.WriteLine(line);

                sb.Append(line);
            }

            WeaponList list;

            String result = sb.ToString();

            XmlSerializer serializer = new XmlSerializer(typeof(WeaponList));
            using (TextReader reader = new StringReader(result))
            {
                var xmlSerializer = new XmlSerializer(typeof(WeaponList), new XmlRootAttribute("weapons"));

                    
                list = (WeaponList)xmlSerializer.Deserialize(reader);
            }

            foreach (var item in list.weapons)
            {
                Console.WriteLine(item.Classe);
            }
            
            return null;
        }
    }
}

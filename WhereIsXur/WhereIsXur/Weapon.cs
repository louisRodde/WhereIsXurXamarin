using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WhereIsXur
{
    public class Weapon : IWeapon, INotifyPropertyChanged
    {
        [XmlElement("name")]
        public string Name
        {
            get { return Name; }
            set
            {
                Name = value;
                RaisePropertyChanged("name");
            }
        }
        [XmlElement("classe")]
        public string Classe
        {
            get => Classe;
            set
            {
                Classe = value;
                RaisePropertyChanged("classe");
            }
        }
        [XmlElement("type")]
        public string Type
        {
            get => Type;
            set
            {
                Type = value;
                RaisePropertyChanged("type");
            }
        }
        [XmlElement("effect")]
        public string Effect
        {
            get => Effect;
            set
            {
                Effect = value;
                RaisePropertyChanged("effect");
            }
        }
        [XmlElement("image")]
        public string Image
        {
            get => Image;
            set
            {
                Image = value;
                RaisePropertyChanged("image");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
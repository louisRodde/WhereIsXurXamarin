using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WhereIsXur
{
    [Serializable]
    public class Weapon : IWeapon, INotifyPropertyChanged
    {

        private string name;

        [XmlElement("name")]
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged("name");
            }
        }

        private String classe;

        [XmlElement("classe")]
        public string Classe
        {
            get => classe;
            set
            {
                classe = value;
                RaisePropertyChanged("classe");
            }
        }

        private String type;

        [XmlElement("type")]
        public string Type
        {
            get => type;
            set
            {
                type = value;
                RaisePropertyChanged("type");
            }
        }

        private String effect;

        [XmlElement("effect")]
        public string Effect
        {
            get => effect;
            set
            {
                effect = value;
                RaisePropertyChanged("effect");
            }
        }

        private String image;

        [XmlElement("image")]
        public string Image
        {
            get => image;
            set
            {
                image = value;
                RaisePropertyChanged("image");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Weapon () { }
    }
}
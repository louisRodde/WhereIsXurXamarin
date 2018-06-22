using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace WhereIsXur
{
    class WeaponViewModel : BaseINPC
    {
        public ObservableCollection<Weapon> Weapons { get; set; }        

        public WeaponViewModel()
        {
            Weapons = new ObservableCollection<Weapon>();
        }

        private Weapon _currentWeapon;

        public Weapon CurrentWeapon
        {
            get => _currentWeapon;
            set
            {
                _currentWeapon = value;
                RaisePropertyChanged("CurrentWeapon");
            }
        }
    }
}

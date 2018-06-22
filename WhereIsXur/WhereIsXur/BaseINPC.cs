using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WhereIsXur
{
    class BaseINPC
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

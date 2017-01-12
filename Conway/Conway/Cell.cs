using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway
{
    class Cell : INotifyPropertyChanged
    {
        private bool _state;
        public bool state
        {
            get { return _state; }
            set {
                _state = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("state"));
                };
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static implicit operator int(Cell c)
        {
            return Convert.ToInt32(c.state);
        }
    }
}

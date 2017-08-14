using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Teste
{
    public class ControleBase : Window, INotifyPropertyChanged
    {

        public ControleBase()
        {
            this.DataContext = this;
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;
        public virtual void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

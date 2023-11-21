using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Telerik_Demo;
public abstract class ViewModel : INotifyPropertyChanged
{
    private string? bfv;

    public string? ServerError
    {
        get
        {
            return bfv;
        }
        protected set
        {
            if (bfv != value)
            {
                bfv = value;
                OnPropertyChanged("ServerError");
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        if (propertyName == null)
        {
            throw new ArgumentNullException("propertyName");
        }

        if (this.PropertyChanged != null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
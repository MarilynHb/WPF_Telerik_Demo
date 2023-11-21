using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Telerik_Demo;

public class MainWindowViewModel : ViewModel
{
    string body = string.Empty;
    public string Body
    {
        get => body;
        set
        {
            if (body != value)
            {
                body = value;
                this.OnPropertyChanged();
            }
        }
    }
}

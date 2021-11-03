using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Chat_e.Service
{
  public class AppState2 : INotifyPropertyChanged
  {
    private bool select = false;
    public bool Select
    {
      get => select;
      set => SetProperty(ref select, value);
    } 
    public event PropertyChangedEventHandler PropertyChanged;
    void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new
                                 PropertyChangedEventArgs(propertyName));
    }

    bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string
                                                     propertyName = null)
    {
      if (Equals(storage, value))
      {
        return false;
      }

      storage = value;
      OnPropertyChanged(propertyName);
      return true;
    }

    public void selectOn()
    {
      Select = true;
    }
  }
}

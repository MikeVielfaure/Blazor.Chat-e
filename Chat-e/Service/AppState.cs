using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Chat_e.Service
{
  public class AppState
  {
    public bool selectedBool { get; set; } = false;
    public Chat_e.components.nav_menu_component.Nav_menu nav = new components.nav_menu_component.Nav_menu();

    public Chat_e.components.nav_menu_component.Nav_menu GetNav_Menu()
    {
      return this.nav;
    }

    public void setNav_Menu(Chat_e.components.nav_menu_component.Nav_menu nav)
    {
      this.nav = nav;
    }

   


    public event Action OnChange;

    public void SetSelectedBoool(bool selected)
    {
      selectedBool = selected;
      NotifyStateChanged();
    }

    public void NotifyStateChanged() => OnChange?.Invoke();
  }
}

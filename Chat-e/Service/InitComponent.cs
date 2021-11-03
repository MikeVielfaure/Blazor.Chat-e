using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_e.Service
{
  public class InitComponent
  {
    public Chat_e.components.list_conecte_component.List_conecte connecte = new components.list_conecte_component.List_conecte();

    public void SetConnecte(components.list_conecte_component.List_conecte mainLayout)
    {
      this.connecte = mainLayout;
    }

    public components.list_conecte_component.List_conecte GetConnecte()
    {
      return this.connecte;
    }
  }
}

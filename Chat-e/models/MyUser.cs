using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_e.models
{
  public class MyUser
  {
    public User user { get; set; }

    public Chat_e.Shared.MainLayout mainLayout = new Shared.MainLayout();

    public void SetMainLayout(Shared.MainLayout mainLayout)
    {
      this.mainLayout = mainLayout;
    }

    public Shared.MainLayout GetMainLayout()
    {
      return this.mainLayout;
    }
  }
}

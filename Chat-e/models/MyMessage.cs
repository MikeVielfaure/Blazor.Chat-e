using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_e.models
{
  public class MyMessage
  {
    private string leMessage { get; set; }
    public string LeMessage
    {
      get { return leMessage; }
      set
      {
        leMessage = value;
        if (value != "")
        {
          verifMessage = false;
        }
        else
        {
          
          verifMessage = true;

        }
      }
    }

    public bool verifMessage = true;
    public Chat_e.components.chat_component.Chat chat = new components.chat_component.Chat();

    public MyMessage(Chat_e.components.chat_component.Chat chat)
    {
      this.chat = chat;
    }
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

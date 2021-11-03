using Chat_e.models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Chat_e.Service
{
  public class Guard
  {
    [Inject]
    private NavigationManager nav { get; set; }

    [Inject]
   private MyUser myUser { get; set; }


    public void verifAuth()
    {
      myUser = new MyUser();
     
      if(myUser.user != null)
      {

      }
      else
      {
        nav.NavigateTo("/connexion");
      }

    }
  }
}

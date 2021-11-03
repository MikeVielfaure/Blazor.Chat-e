// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Chat_e.components.autocomplete_component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Chat_e;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Chat_e.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Chat_e.Validate_Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Chat_e.components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\_Imports.razor"
using Chat_e.models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\components\autocomplete-component\Autocomplete.razor"
using Chat_e.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\components\autocomplete-component\Autocomplete.razor"
using chat_component;

#line default
#line hidden
#nullable disable
    public partial class Autocomplete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\vielf\Documents\Mike\blazor\projets_server\Chat-e\API\Chat-e\Chat-e\components\autocomplete-component\Autocomplete.razor"
       
    [CascadingParameter(Name = "lesUser")]
    private List<User> lesUser { get; set; }

    [CascadingParameter(Name = "lesUser")]
    private List<User> autoUser { get; set; }

    Chat_e.components.list_conecte_component.List_conecte connecte = new list_conecte_component.List_conecte();

    private int index;

  private bool autoPlay = false;

  private bool autoTouch = false;

  private string name = "";

  protected override async Task OnInitializedAsync()
  {

  }



  private async Task onClickUser(int k)
  {
    //connecte = InitComponent.GetConnecte();
    //List<User> bbb = new List<User>();
    //bbb.Add(lesUser[k]);
    //await connecte.changeLesUser(bbb);
    name = lesUser[k].id;
    autoPlay = false;

  }

  private void onClickInput()
  {

    autoPlay = true;
  }

  private void onInput(ChangeEventArgs args)
  {
    name= args.Value.ToString();
    lesUser =new List<User>();
    lesUser = autoUser.FindAll(e => e.id.Contains(name));
    //List<string> test = new List<string>();
    // test = autoUser.FindAll(e => e.Contains(name));
    //test = autoUser.Where(e => e.Contains(name));
    //autoUser.Clear();
    //autoUser = test;
  }

  private void onBlur()
  {
    if (autoTouch == false)
    {
      autoPlay = false;
    }
  }

  private void onFocus()
  {
    autoPlay = true;
  }

  private void onLeave()
  {
    autoTouch = false;
  }

  private void onEnter()
  {
    autoTouch = true;
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InitComponent InitComponent { get; set; }
    }
}
#pragma warning restore 1591

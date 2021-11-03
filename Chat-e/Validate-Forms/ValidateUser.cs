using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_e.Validate_Forms
{
  public class ValidateUser
  {
    [Required(ErrorMessage = "Champ requis") ]

    public string id { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_e.models
{
  public class User
  {
    [Key]
    public string id { get; set; }
  }
}

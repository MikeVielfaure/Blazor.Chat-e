using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_e.models
{
  public class Messages
  {
    [Key]
    public int id { get; set; }

    [Required]
    [Column(TypeName = "DateTime")]
    public DateTime date {get; set; }

    [Required]
    [Column(TypeName = "nvarchar(10000)")]
    public string contenu { get; set; }

    
    [ForeignKey("User")]
    public string iduser { get; set; }

    
    

  }
}

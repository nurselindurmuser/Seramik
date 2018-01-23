using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public enum UsageArea
      
    {
        [Display(Name = "Duvar")]
        Wall = 1,
        [Display(Name = "Zemin")]
        Floor = 2     
    }
    
}

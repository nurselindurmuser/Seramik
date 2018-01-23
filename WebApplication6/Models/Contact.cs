using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class Contact:BaseEntity
    {
        [Required(ErrorMessage = "Tam Ad alanı gereklidir")]
        [Display(Name = "Tam Ad")]
        [StringLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-posta alanı gereklidir")]
        [Display(Name = "E-posta")]
        [StringLength(200)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon alanı gereklidir")]
        [Display(Name = "Telefon")]
        [StringLength(200)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Mesaj alanı gereklidir")]
        [Display(Name = "Mesaj")]
        [StringLength(4000)]
        public string Message { get; set; }
    }
}

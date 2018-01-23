using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class Product:BaseEntity
    {

        [Required(ErrorMessage = "Başlık alanı bilgisi gereklidir")]
        [Display(Name = "Başlık")]
        [StringLength(200)]
        public string Title { get; set; }

        [Display(Name = "Fotoğraf")]
        [StringLength(200)]
        public string Photo { get; set; }

        [Required(ErrorMessage = "Detay alanı bilgisi gereklidir")]
        [Display(Name = "Detay")]
        [StringLength(4000)]
        public string Detail { get; set; }

        //ENUM
        [Required(ErrorMessage = "Kullanım alanı, alanı bilgisi gereklidir")]
        [Display(Name = "Kullanım alanı")]
        public UsageArea UsageArea { get; set; }

        //ENUM
        [Required(ErrorMessage = "Ebat alanı bilgisi gereklidir")]
        [Display(Name = "Ebat")]
        public Size Size { get; set; }

        //ENUM
        [Required(ErrorMessage = "Renk alanı bilgisi gereklidir")]
        [Display(Name = "Renk")]
        public Color Color { get; set; }

        [Required(ErrorMessage = "Tarih alanı bilgisi gereklidir")]
        [Display(Name = "Tarih")]
        public DateTime Date { get; set; }


    }
}

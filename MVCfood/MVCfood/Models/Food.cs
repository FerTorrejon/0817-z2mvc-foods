using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCfood.Models
{
    public class Food
    {
        [Key]
        public int foodID { get; set; }

        [Required]
        public string Name { get ; set ; }

        [Display(Description ="Food Description")]
        [StringLength(30,ErrorMessage = "Te pasaste, solo entre 5 a 30 caracteres" , MinimumLength =5)]
        public string Description { get; set; }
    }
}
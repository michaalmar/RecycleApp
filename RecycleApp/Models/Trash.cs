using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecycleApp.Models
{
    public class Trash
    {
        [Key]   
        public int TrashID { get; set; }

      
        [Required]
        [Display(Name = "Kategoria")]
        public int CategoryID { get; set; }

        [Required]
        [Display (Name="Nazwa odpadu")]
        public string  Name { get; set; }  
        
        public virtual Category Category { get; set; }
    }
}
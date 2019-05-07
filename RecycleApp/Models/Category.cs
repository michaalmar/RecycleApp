using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecycleApp.Models
{
    public class Category
    {
        [Key]
        [Display (Name="Kategoria")]
        public int CategoryID { get; set; }

        [Required]
        [Display (Name="Nazwa Kategorii")]
        public string Name { get; set; }

        public virtual ICollection<Trash> Trashes { get; set; }

    }
}
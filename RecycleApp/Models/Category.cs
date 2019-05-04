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
        public int CategoryID { get; set; }
        [Display (Name="Nazwa Kategorii")]
        public string Name { get; set; }

        public virtual ICollection<Trash> Trashes { get; set; }

    }
}
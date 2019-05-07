using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecycleApp.Models
{
    public class User
    {

        [Key]
        public int userID { get; set; }

        [Display(Name = "Imię")]    
        public string firstName { get; set; }

        [Display(Name = "Nazwisko")]   
        public string lastName { get; set; }

        [Display(Name = "Wiek")]    
        public int age { get; set; }

        [Display(Name = "Nazwa użytkownika")]
        public string userName { get; set; }

        
        [Display(Name = "Hasło")]    
        public string password { get; set; }

    }
}
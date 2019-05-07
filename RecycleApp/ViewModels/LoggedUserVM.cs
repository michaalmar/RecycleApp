using RecycleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecycleApp.ViewModels
{
    public class LoggedUserVM
    {
        public User user { get; set; } 

        public string loggedUser
        {
            
            
            get
            {
                return HttpContext.Current.User.Identity.Name;
            }
        }

    }
}
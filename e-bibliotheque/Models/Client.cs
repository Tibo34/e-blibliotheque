using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_bibliotheque.Models
{
    public class Client
    {
        private string nom;
        private string email;
       

        public string Nom { get => nom; set => nom = value; }
        public string Email { get => email; set => email = value; }
      

        public Client(string nom,string email)
        {
            Nom = nom;
            Email = email;
            
        }



      
    }
}
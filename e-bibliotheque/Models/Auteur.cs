using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_bibliotheque.Models
{
    public class Auteur
    {
        private int id;
        private string nom;

        public Auteur(int id,string nom)
        {
            Id = id;
            Nom = nom;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
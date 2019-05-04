using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_bibliotheque.Models
{
    public class Livre
    {
        private int id;
        private string titre;
        private DateTime dateParution;
        private Auteur auteur;

        public Livre(int id,string titre,DateTime date, Auteur auteur)
        {
            Id = id;
            Titre = titre;
            DateParution = date;
            Auteur = auteur;
        }

        public override bool Equals(object obj)
        {
            Type type = this.GetType();
            if (!obj.GetType().Equals(type))
            {
                return false;
            }
            Livre livre = (Livre)obj;
            if (livre.Id == Id)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public int Id { get => id; set => id = value; }
        public string Titre { get => titre; set => titre = value; }
        public DateTime DateParution { get => dateParution; set => dateParution = value; }
        public Auteur Auteur { get => auteur; set => auteur = value; }
    }
}
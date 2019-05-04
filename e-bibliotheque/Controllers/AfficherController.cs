using e_bibliotheque.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace e_bibliotheque.Controllers
{
    public class AfficherController : Controller
    {
        //Get:Livres+Auteur
        public string Index()
        {
            Blibliotheque bliblio = Blibliotheque.initialisation();
            List<Livre> listLivre = bliblio.ListLivres;
            string str = "";
            foreach (Livre livre in listLivre)
            {
                str += "Titre : " + livre.Titre + " Auteur : " + livre.Auteur.Nom + "<br>";
            }
            return str;
        }

        public string Auteurs()
        {
            Blibliotheque bliblio = Blibliotheque.initialisation();
            List<Livre> listLivre = bliblio.ListLivres;
            List<Auteur> listAuteurs = new List<Auteur>();
            string str = "Auteurs <br>";
            foreach (Livre livre in listLivre)
            {
                if (!listAuteurs.Contains(livre.Auteur))
                {
                    listAuteurs.Add(livre.Auteur);
                }               
            }
            foreach(Auteur a in listAuteurs)
            {
                str += a.Nom+"<br>";
            }
            return str;
        }

        public string Auteur(int id)
        {
            Blibliotheque bliblio = Blibliotheque.initialisation();
            List<Livre> listLivre = bliblio.ListLivres;
            
            foreach (Livre livre in listLivre)
            {
                if (livre.Auteur.Id == id)
                {
                   return livre.Auteur.Nom;
                }
            }
         
            return "Auteur n'existe pas";
        }

        public string Livre(int id)
        {
            Blibliotheque bliblio = Blibliotheque.initialisation();
            List<Livre> listLivre = bliblio.ListLivres;
            List<Emprunt> listEmprunt = bliblio.ListEmprunts;
            string str = "";
            foreach (Livre livre in listLivre)
            {
                if (livre.Id == id)
                {
                    if (bliblio.isEmprunter(livre))
                    {
                        str = "Emprunt est emprunté";
                    }
                    return "titre : "+livre.Titre+ "<br> date de parution "+livre.DateParution+" "+str;
                }
            }
            return "Le livre n'existe pas";
        }

        public string  rechercheLivre(string titre)
        {
            Blibliotheque bliblio = Blibliotheque.initialisation();
            List<Livre> listLivre = bliblio.ListLivres;
            List<Livre> trouve = new List<Livre>();
            foreach(Livre livre in listLivre)
            {
                if (livre.Titre.Contains(titre))
                {
                    trouve.Add(livre);
                }
            }
            return trouve.ToString();
        }
    }
}
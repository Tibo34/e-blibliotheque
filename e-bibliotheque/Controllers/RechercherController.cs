using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_bibliotheque.Models;

namespace e_bibliotheque.Controllers
{
    public class RechercherController : Controller
    {
        // GET: Rechercher
        public string Livre(string id)
        {
            Blibliotheque bliblio = Blibliotheque.initialisation();
            List<Livre> listLivre = bliblio.ListLivres;
            List<Livre> trouve = new List<Livre>();           
            foreach (Livre livre in listLivre)
            {
                if (livre.Titre.Contains(id))
                {
                    trouve.Add(livre);                   
                }
            }
            string str = "";
            foreach(Livre livre in trouve)
            {
                str += livre.Titre + "<br>";
            }
            return str;
        }
    }
}
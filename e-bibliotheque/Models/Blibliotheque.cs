using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_bibliotheque.Models
{
    public class Blibliotheque
    {

        private List<Livre> listLivres;
        private List<Client> listClients;
        private List<Emprunt> listEmprunts;

        public List<Livre> ListLivres { get => listLivres; set => listLivres = value; }
        public List<Client> ListClients { get => listClients; set => listClients = value; }
        public List<Emprunt> ListEmprunts { get => listEmprunts; set => listEmprunts = value; }

        public Blibliotheque()
        {
            ListClients = new List<Client>();
            ListLivres = new List<Livre>();
            listEmprunts = new List<Emprunt>();
        }

        public void ajouterLivre(Livre livre)
        {
            ListLivres.Add(livre);
        }

        public void ajouterClient(Client client)
        {
            ListClients.Add(client);
        }

        public bool emprunterLivre(Client client,Livre livre)
        {
            if (ListLivres.Contains(livre)&&isNotEmprunte(livre))
            {
                Emprunt emprunt = new Emprunt(client, livre);
                ListEmprunts.Add(emprunt);               
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isEmprunter(Livre l)
        {
            foreach(Emprunt e in listEmprunts)
            {
                if (e.Livre.Equals(l))
                {
                    return true;
                }
            }
            return false;
        }

        public string FindEmprunt(Livre l)
        {
            string str = "";
            if (isEmprunter(l))
            {
                foreach (Emprunt e in listEmprunts)
                {
                    if (e.Livre.Equals(l))
                    {
                        str=e.Client.Nom;
                    }
                }
            }
            return str;
        }

        private bool isNotEmprunte(Livre livre)
        {         
            foreach(Emprunt emprunt in ListEmprunts)
            {
              if (emprunt.Livre.Equals(livre))
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static Blibliotheque initialisation()
        {
            Blibliotheque bliblio = new Blibliotheque();
            Livre l1, l2, l3, l4, l5;
            Auteur a1, a2, a3;
            Client c1, c2;
            a1 = new Auteur(1, "J. K. Rowling");
            a2 = new Auteur(2, "J. R. R. Tolkien");
            a3 = new Auteur(3, "Akira Toriyama");
            l1 = new Livre(1,"L'ecole des sorcier",new DateTime(1998,12,12),a1);
            l2 = new Livre(2,"la chambre des secret",new DateTime(1999,12,1),a1);
            l3 = new Livre(3,"La communaute de l'anneau",new DateTime(2001,12,5),a2);
            l4 = new Livre(4,"Les deux tours",new DateTime(2002,12,24),a2);
            l5 = new Livre(5,"DragonBall",new DateTime(1988,1,12),a3);
            bliblio.ajouterLivre(l1);
            bliblio.ajouterLivre(l2);
            bliblio.ajouterLivre(l3);
            bliblio.ajouterLivre(l4);
            bliblio.ajouterLivre(l5);
            c1 = new Client("Jean", "jean@gmail.com");
            c2 = new Client("Jacque", "jacque@gmail.com");
            bliblio.ajouterClient(c1);
            bliblio.ajouterClient(c2);
            bliblio.emprunterLivre(c1, l1);
            bliblio.emprunterLivre(c1, l5);

            return bliblio;
        }
    }
}
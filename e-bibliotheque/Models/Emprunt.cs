using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_bibliotheque.Models
{
    public class Emprunt
    {
        private Client client;
        private Livre livre;

        public Client Client { get => client; set => client = value; }
        public Livre Livre { get => livre; set => livre = value; }

        public Emprunt(Client c,Livre l)
        {
            Client = c;
            Livre = l;
        }

    }
}
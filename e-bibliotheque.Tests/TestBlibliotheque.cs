using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using e_bibliotheque.Models;

namespace e_bibliotheque.Tests
{
    [TestClass]
    public class TestBlibliotheque
    {
        [TestMethod]
        public void TestajouterLivre()
        {
            Blibliotheque  bliblio = new Blibliotheque();
            Auteur jkRowling = new Auteur(1, "JK Rowling");
            Livre l1 = new Livre(1, "l'ecole des sorcier", new DateTime(2012,12,12),jkRowling);
            bliblio.ajouterLivre(l1);
            Assert.AreEqual(1, bliblio.ListLivres.Count);
        }

        [TestMethod]
        public void TestajouterClient()
        {
            Blibliotheque bliblio = new Blibliotheque();
            Client client = new Client("Jean", "jean@gamil.com");
            bliblio.ajouterClient(client);
            Assert.AreEqual(1, bliblio.ListClients.Count);
        }

        [TestMethod]
        public void emprunt_livre_reussi()
        {
            Blibliotheque bliblio = new Blibliotheque();
            Auteur jkRowling = new Auteur(1, "JK Rowling");
            Livre l1 = new Livre(1, "l'ecole des sorcier", new DateTime(2012, 12, 12), jkRowling);
            bliblio.ajouterLivre(l1);
            Client client = new Client("Jean", "jean@gamil.com");
            bliblio.ajouterClient(client);
            bool emprunt = bliblio.emprunterLivre(client, l1);
            Assert.AreEqual(emprunt, true);
          //  Assert.AreEqual(bliblio.ListEmprunts.Count, 1);

        }
    }
}

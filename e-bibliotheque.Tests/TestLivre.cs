using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using e_bibliotheque.Models;

namespace e_bibliotheque.Tests
{
    [TestClass]
    public class TestLivre
    {
        [TestMethod]
        public void EqualsLivre()
        {
            Livre l1, l2;
            Auteur jkRowling = new Auteur(1, "JK Rowling");
            l1 = new Livre(1,"l'école des sorcier",new DateTime(2012, 12,12),jkRowling);
            l2= new Livre(1, "l'école des sorcier", new DateTime(2012, 12, 12), jkRowling);
            bool res = l1.Equals(l2);
            Assert.AreEqual(res, true);

        }
    }
}

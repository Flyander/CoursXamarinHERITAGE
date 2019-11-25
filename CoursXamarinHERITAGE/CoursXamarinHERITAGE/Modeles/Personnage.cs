using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CoursXamarinHERITAGE.Modeles
{
    class Personnage
    {
        #region Attributs
        public static ArrayList collPersonnage = new ArrayList();

        private string nom;
        #endregion

        #region Constructeurs
        public Personnage(string nom)
        {
            this.nom = nom;
            Personnage.collPersonnage.Add(this);
        }
        #endregion

        #region Getters/Setters
        public string Nom { get => nom; set => nom = value; }

        #endregion

        #region Méthodes
        public string parler()
        {
            return "Hello";
        }

        public virtual string marcher()
        {
            return "Je marche";
        }
        #endregion
    }
}

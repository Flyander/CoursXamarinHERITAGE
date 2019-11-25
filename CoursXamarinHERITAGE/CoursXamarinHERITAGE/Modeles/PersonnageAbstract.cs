using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CoursXamarinHERITAGE.Modeles
{
    abstract class PersonnageAbstract
    {
        #region Attributs
        public static ArrayList collPersonnage = new ArrayList();

        protected string nom;
        #endregion

        #region Constructeurs
        public PersonnageAbstract(string nom)
        {
            this.nom = nom;
            Personnage.collPersonnage.Add(this);
        }
        #endregion

        #region Getters/Setters
        public abstract string nom_personnage { get; set; }

        #endregion

        #region Méthodes
        public abstract string parler();

        public abstract string marcher();
        #endregion
    }
}

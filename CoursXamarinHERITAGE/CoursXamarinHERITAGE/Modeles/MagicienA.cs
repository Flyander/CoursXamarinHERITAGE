using System;
using System.Collections.Generic;
using System.Text;

namespace CoursXamarinHERITAGE.Modeles
{
    class MagicienA : PersonnageAbstract
    {
        #region Constructeur
        public MagicienA(string nom) : base(nom)
        {
        }
        #endregion

        #region Getters/Setters
        public override string nom_personnage { get => nom.ToUpper(); set => nom = value; }
        #endregion

        #region Methodes
        public override string marcher()
        {
            return "Je vole";
        }

        public override string parler()
        {
            return "Je chuchote";
        }

        #endregion
    }
}

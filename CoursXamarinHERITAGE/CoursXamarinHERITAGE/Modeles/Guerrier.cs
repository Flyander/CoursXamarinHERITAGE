using System;
using System.Collections.Generic;
using System.Text;

namespace CoursXamarinHERITAGE.Modeles
{
    class Guerrier : Personnage
    {
        #region Attributs
        private int _age;
        #endregion

        #region Constructeur
        public Guerrier(string nom, int age) : base(nom)
        {
            this.Age = age;
        }
        #endregion

        #region Getters/Setters
        public int Age { get => _age; set => _age = value; }
        #endregion

        #region Methodes
        public override string marcher()
        {
            return "Je cours";
        }
        #endregion
    }
}

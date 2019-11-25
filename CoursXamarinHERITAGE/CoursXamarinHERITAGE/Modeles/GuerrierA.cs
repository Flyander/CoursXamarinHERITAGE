namespace CoursXamarinHERITAGE.Modeles
{
    class GuerrierA : PersonnageAbstract
    {
        #region Constructeur
        public GuerrierA(string nom) : base(nom)
        {
        }
        #endregion

        #region Getters/Setters
        public override string nom_personnage { get => nom.ToUpper(); set => nom = value; }
        #endregion

        #region Methodes
        public override string marcher()
        {
            return "Je cours";
        }

        public override string parler()
        {
            return "Je crie";
        }

        #endregion
    }
}

using CoursXamarinHERITAGE.Modeles;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace CoursXamarinHERITAGE.VuesModeles
{
    class PrincipalVueModele : INotifyPropertyChanged
    {
        #region Attributs
        private string _leType = null;
        private Personnage _lePersonnage = null;
        private string _image = null;
        #endregion

        #region Constructeurs
        public PrincipalVueModele()
        {
            BoutonCommandTest = new Command(RandomPersonnage);
        }
        #endregion

        #region Getters/Setters
        public string Image { get { return _image; } set { _image = value; OnPropertyChanged(nameof(Image)); } }
        public ICommand BoutonCommandTest { get; }
        public string LeType { get { return _leType; } set { _leType = value; OnPropertyChanged(nameof(LeType)); } }
        public Personnage LePersonnage { get { return _lePersonnage; } set { _lePersonnage = value; OnPropertyChanged(nameof(LePersonnage)); } }

        #endregion

        #region Methodes
        public void RandomPersonnage()
        {
            Personnage unPerso = null;
            Random aleatoire = new Random();
            int nombreAlea = aleatoire.Next(3);
            switch (nombreAlea) 
            { 

                case 0:
                    Image = "Personnage.png";
                    unPerso = new Personnage("Bernard");
                    break;
                case 1:
                    Image = "magician.jpg";
                    unPerso = new Magicien("Magicen d'oz", 18);
                    break;
                case 2:
                    Image = "warrior.jpg";
                    unPerso = new Guerrier("Shreko le boss", 20);
                    break;
            }
            LePersonnage = (Personnage)unPerso;
            LeType = LePersonnage.GetType().Name;
        }
        #endregion

        #region notifications
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

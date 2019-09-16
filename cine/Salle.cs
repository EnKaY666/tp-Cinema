using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine
{
    public class Salle
    {
        private string film;
        private int nbPlace;
        private double prixNormal;
        private int placeNormal;
        private int placeReduit;

        public Salle(string f, int p, double px)
        {
            this.film = f;
            this.nbPlace = p;
            this.prixNormal = px;
            this.placeNormal = 0;
            this.placeReduit = 0;
        }

        public int nbPlaceDisponible()
        {
            int dispo = 0;
            dispo = this.nbPlace - this.placeReduit - this.placeNormal;
            return dispo;
        }
        public void vendrePlace(int nbre, bool reduit)
        {
            this.nbPlace = nbPlaceDisponible();
            if (this.nbPlace > nbre)
            {
                if (reduit == true)
                {
                    double prix;
                    prix = nbre * (this.prixNormal * 0.8);
                    this.placeReduit = this.placeReduit + nbre;
                }
                else
                {
                    double prix;
                    prix = nbre * this.prixNormal;
                    this.placeNormal = this.placeNormal + nbre;
                }
                this.nbPlace = this.nbPlace - nbre;
                //afficher le prix
            }
            else
            {
                //afficher une erreur
            }
        }
        public void remiseAZero()
        {
            this.placeNormal = 0;
            this.placeReduit = 0;
        }
        public double chiffreAffaire()
        {
            double total;
            total = (placeNormal * prixNormal) + (placeReduit * (prixNormal * 0.80));
            return total;
        }
    }
}

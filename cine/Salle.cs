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
                //afficher un label avec le prix de la vente
            }
            else
            {
                //afficher un label qui indique une erreur de manque de place
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
            total = (this.placeNormal * this.prixNormal) + (this.placeReduit * (this.prixNormal * 0.80));
            return total;
        }
        public double tauxRemplissage()
        {
            double taux;
            taux = (this.nbPlace * (this.placeNormal + this.placeReduit)) / 100;
            return taux;
        }
        public string toString()
        {
            string nom = this.film;
            int place = this.nbPlace;
            int venduNormal = this.placeNormal;
            int venduReduit = this.placeReduit;
            double p = this.prixNormal;
            string resumer;
            resumer = "Film joué:"+nom+" / Nombre de places:"+place+" / prix d'une place:"+p+" / "+venduNormal+" Place sont vendu à prix Normal / "+venduReduit+" Place sont venduent à prix Réduit";
            return resumer;
        }

    }
}

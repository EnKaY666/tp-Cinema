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
    }
}

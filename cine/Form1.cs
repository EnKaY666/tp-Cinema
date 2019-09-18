using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine
{
    public partial class Form1 : Form
    {
        List<Salle> lesSalles = new List<Salle>(); // création de la liste
        
        public Form1()
        {
            InitializeComponent();
            lb.MultiColumn = true;
            for (int x=1; x < lesSalles.Count ; x++)
            {
                lb.Items.Add(lesSalles[x]);
            }
        }

        private void ReserveBTN_Click(object sender, EventArgs e)
        {
            bool reduit = cb_reduit.Checked;
            int nFilm = Convert.ToInt16(numeroFilm.Text);
            int nPlace = Convert.ToInt16(nbPlace.Text);
            string vente = Salle.vendrePlace(nPlace, reduit);
            erreurLabal.Text = vente;
            erreurLabal.Visible = true;
;       }
    }
}

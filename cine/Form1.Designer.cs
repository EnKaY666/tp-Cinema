﻿namespace cine
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.achatBillet = new System.Windows.Forms.Panel();
            this.erreurLabal = new System.Windows.Forms.Label();
            this.reserveBTN = new System.Windows.Forms.Button();
            this.nbPlace = new System.Windows.Forms.TextBox();
            this.numeroFilm = new System.Windows.Forms.TextBox();
            this.cb_reduit = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.ListBox();
            this.achatBillet.SuspendLayout();
            this.SuspendLayout();
            // 
            // achatBillet
            // 
            this.achatBillet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.achatBillet.Controls.Add(this.erreurLabal);
            this.achatBillet.Controls.Add(this.reserveBTN);
            this.achatBillet.Controls.Add(this.nbPlace);
            this.achatBillet.Controls.Add(this.numeroFilm);
            this.achatBillet.Controls.Add(this.cb_reduit);
            this.achatBillet.Controls.Add(this.label3);
            this.achatBillet.Controls.Add(this.label2);
            this.achatBillet.Controls.Add(this.label1);
            this.achatBillet.Location = new System.Drawing.Point(13, 13);
            this.achatBillet.Name = "achatBillet";
            this.achatBillet.Size = new System.Drawing.Size(224, 267);
            this.achatBillet.TabIndex = 0;
            // 
            // erreurLabal
            // 
            this.erreurLabal.AutoSize = true;
            this.erreurLabal.Location = new System.Drawing.Point(7, 194);
            this.erreurLabal.Name = "erreurLabal";
            this.erreurLabal.Size = new System.Drawing.Size(0, 13);
            this.erreurLabal.TabIndex = 8;
            this.erreurLabal.Visible = false;
            // 
            // reserveBTN
            // 
            this.reserveBTN.Location = new System.Drawing.Point(73, 215);
            this.reserveBTN.Name = "reserveBTN";
            this.reserveBTN.Size = new System.Drawing.Size(75, 45);
            this.reserveBTN.TabIndex = 7;
            this.reserveBTN.Text = "Réserver";
            this.reserveBTN.UseVisualStyleBackColor = true;
            this.reserveBTN.Click += new System.EventHandler(this.ReserveBTN_Click);
            // 
            // nbPlace
            // 
            this.nbPlace.Location = new System.Drawing.Point(154, 88);
            this.nbPlace.Name = "nbPlace";
            this.nbPlace.Size = new System.Drawing.Size(62, 20);
            this.nbPlace.TabIndex = 6;
            // 
            // numeroFilm
            // 
            this.numeroFilm.Location = new System.Drawing.Point(154, 41);
            this.numeroFilm.Name = "numeroFilm";
            this.numeroFilm.Size = new System.Drawing.Size(63, 20);
            this.numeroFilm.TabIndex = 5;
            // 
            // cb_reduit
            // 
            this.cb_reduit.AutoSize = true;
            this.cb_reduit.Location = new System.Drawing.Point(10, 147);
            this.cb_reduit.Name = "cb_reduit";
            this.cb_reduit.Size = new System.Drawing.Size(117, 17);
            this.cb_reduit.TabIndex = 4;
            this.cb_reduit.Text = "Droit au Prix Réduit";
            this.cb_reduit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saisir Nombres de Billets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saisir Numéro de la Séance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Achat de Billets pour une Séance:";
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(244, 13);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(756, 264);
            this.lb.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 544);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.achatBillet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.achatBillet.ResumeLayout(false);
            this.achatBillet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel achatBillet;
        private System.Windows.Forms.Label erreurLabal;
        private System.Windows.Forms.Button reserveBTN;
        private System.Windows.Forms.TextBox nbPlace;
        private System.Windows.Forms.TextBox numeroFilm;
        private System.Windows.Forms.CheckBox cb_reduit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb;
    }
}


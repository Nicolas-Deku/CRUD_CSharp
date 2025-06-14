using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.classe
{
    class Voiture
    {
        // Propriétés (attributs de la classe)
        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int Annee { get; set; }
        public decimal Prix { get; set; }
        public string ImagePath { get; set; }

        // Constructeur par défaut
        public Voiture() { }

        // Constructeur avec ID (par exemple pour une voiture déjà en base)
        public Voiture(int id, string matricule, string marque, string modele, int annee, decimal prix, string imagePath)
        {
            Id = id;
            Matricule = matricule;
            Marque = marque;
            Modele = modele;
            Annee = annee;
            Prix = prix;
            ImagePath = imagePath;
        }

        // Constructeur sans ID (par exemple avant insertion)
        public Voiture(string matricule, string marque, string modele, int annee, decimal prix, string imagePath)
        {
            Matricule = matricule;
            Marque = marque;
            Modele = modele;
            Annee = annee;
            Prix = prix;
            ImagePath = imagePath;
        }
    }
}

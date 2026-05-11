using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vehicules
{
    // Classe mère Vehicule
    internal class Vehicule
    {
        // Variables d'instance pour la marque et le modèle du véhicule
        private string marque;
        private string modele;

        // Constructeur de la classe mère Vehicule
        public Vehicule(string marque, string modele)
        {
            this.marque = marque;
            this.modele = modele;
        }

        // Getters et setters pour les propriétés de la classe mère
        public string getMarque()
        {
            return marque;
        }

        public void setMarque(string marque)
        {
            this.marque = marque;
        }

        public string getModele()
        {
            return modele;
        }

        public void setModele(string modele)
        {
            this.modele = modele;
        }

        // Classe fille Voiture qui hérite de Vehicule
        public class Voiture : Vehicule
        {
            // Variable d'instance pour le nombre de portes de la voiture
            private int nbPortes;

            // Constructeur de la classe fille Voiture
            public Voiture(string marque, string modele, int nbPortes) : base(marque, modele)
            {
                this.nbPortes = nbPortes;
            }

            // getters et setters pour les propriétés de la classe fille Voiture
            public int getNbPortes()
            {
                return nbPortes;
            }

            public void setNbPortes(int nbPortes)
            {
                this.nbPortes = nbPortes;
            }
        }


        // Classe fille Moto qui hérite de Vehicule
        public class Moto : Vehicule
        {
            // Variable d'instance pour la cylindrée de la moto
            private int cylindree;

            // Constructeur de la classe fille Moto
            public Moto(string marque, string modele, int cylindree) : base(marque, modele)
            {
                this.cylindree = cylindree;
            }

            // getters et setters pour les propriétés de la classe fille Moto
            public int getCylindree()
            {
                return cylindree;
            }

            public void setCylindree(int cylindree)
            {
                this.cylindree = cylindree;
            }
        }

        
    }
}

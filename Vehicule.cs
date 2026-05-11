using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vehicules
{
    // Classe mère Vehicule qui est abstraite, ce qui signifie qu'elle ne peut pas être instanciée directement et doit être héritée par des classes filles
    public abstract class Vehicule
    {
        // Variables d'instance pour la marque et le modèle du véhicule
        private string marque;
        private string modele;

        // Constructeur de la classe mère Vehicule
        protected Vehicule(string marque, string modele)
        {
            this.marque = marque;
            this.modele = modele;
        }

        // Cette méthode protégée permet de récupérer les informations de base du véhicule (marque et modèle)
        protected string RecupInfo()
        {
            return $"Marque: {marque}, Modèle: {modele}";
        }

        // Méthode abstraite que les classes filles doivent implémenter pour fournir des informations spécifiques à leur type de véhicule
        public abstract string VehiculInfo();

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

            // Implémentation de la méthode abstraite VehiculInfo pour la classe Voiture
            public override string VehiculInfo()
            {
                return (base.RecupInfo() + $", Nombre de portes: {this.nbPortes}");
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

            // Implémentation de la méthode abstraite VehiculInfo pour la classe Moto
            public override string VehiculInfo()
            {
                return (base.RecupInfo() + $", Cylindrée: {this.cylindree}");
            }
        }


    }
}

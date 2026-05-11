using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vehicules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'instances de Voiture et Moto
            Vehicule Peugeot = new Vehicule.Voiture("Peugeot", "206", 2);
            Vehicule Yamaha = new Vehicule.Moto("Yamaha", "MT-07", 689);

            // Stockage des véhicules dans une liste
            List<Vehicule> lesVehicules = new List<Vehicule> { Peugeot, Yamaha };

            // Affichage des informations de chaque véhicule dans la liste lesVehicules
            foreach (Vehicule unVehicule in lesVehicules)
            {
                Console.WriteLine(unVehicule.VehiculInfo());
            }
        }
    }
}

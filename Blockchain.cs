///Entreprise : ETML
///Auteur : Christopher Ristic 
///Date : 28.03.2025

using System;

namespace Blockchain
{
    /// <summary>
    /// Blockchain
    /// </summary>
    internal class Blockchain
    {
        /// <summary>
        /// Premier bloc de la chaîne
        /// </summary>
        public Bloc PremierBloc { get; private set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Blockchain()
        {
            PremierBloc = null; // Initialisé à null, aucun bloc dans la chaîne au départ
        }

        /// <summary>
        /// Ajoute un nouveau bloc à la fin de la chaîne
        /// </summary>
        /// <param name="data">Données du nouveau bloc</param>
        public void AjouterBloc(string data)
        {
            // Si la chaîne est vide (PremierBloc est null), créer le premier bloc
            if (PremierBloc == null)
            {
                PremierBloc = new Bloc(data);
            }
            else
            {
                // Si la chaîne n'est pas vide, parcourez-la jusqu'au dernier bloc
                Bloc dernierBloc = PremierBloc;
                while (dernierBloc.Next != null)
                {
                    dernierBloc = dernierBloc.Next;
                }
                // Ajoutez le nouveau bloc à la fin
                dernierBloc.Next = new Bloc(data);
            }
        }

        /// <summary>
        /// Affiche les données de tous les blocs dans la chaîne
        /// </summary>
        public void Afficher()
        {
            Bloc courant = PremierBloc;
            while (courant != null)
            {
                Console.WriteLine(courant.Data);
                courant = courant.Next;
            }
        }
    }
}

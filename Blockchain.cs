///Entreprise : ETML
///Auteur : Christopher Ristic 
///Date : 28.03.2025

using System;
using System.Security.Cryptography;

namespace Blockchain
{
    /// <summary>
    /// Blockchain
    /// </summary>
    internal class Blockchain
    {
        public Bloc PremierBloc { get; private set; }

        public void AjouterBloc(string data)
        {
            Bloc nouveauBloc = new Bloc(data);
            if (PremierBloc == null)
            {
                PremierBloc = nouveauBloc;
            }
            else
            {
                Bloc courant = PremierBloc;
                while (courant.Next != null)
                {
                    courant = courant.Next;
                }
                courant.Next = nouveauBloc;
                nouveauBloc.Precedent = courant;
            }
        }

        public void Afficher()
        {
            Bloc courant = PremierBloc;
            while (courant != null)
            {
                string precedentData = courant.Precedent?.Data ?? "Aucun";
                Console.WriteLine($"Bloc : {courant.Data}, Hash : {courant.Hash}, Précédent : {precedentData}");
                courant = courant.Next;
            }
        }

    }
}

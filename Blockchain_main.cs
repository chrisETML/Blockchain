/*
Entreprise : ETML
Auteur : Christopher Ristic 
Date : 28.03.2025
*/

using System;

namespace Blockchain
{
    internal class Blockchain_main
    {
        /// <summary>
        /// Programme pour la blockchain
        /// </summary>
        static void Main()
        {

            Blockchain blockchain = new Blockchain();

            blockchain.AjouterBloc("Bob envoie 5 à Charlie");
            blockchain.AjouterBloc("Alice envoie 10 à Bob");

            blockchain.Afficher();


        }
    }
}

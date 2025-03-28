///Entreprise : ETML
///Auteur : Christopher Ristic 
///Date : 28.03.2025

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
            blockchain.AjouterBloc("Transaction 1 : Alice envoie 10 à Bob");
            blockchain.AjouterBloc("Transaction 2 : Bob envoie 5 à Charlie");
            blockchain.AjouterBloc("Transaction 3 : Charlie envoie 2 à Dave");
            blockchain.Afficher();

        }
    }
}

/*
Entreprise : ETML
Auteur : Christopher Ristic 
Date : 28.03.2025
*/

namespace Blockchain
{
    /// <summary>
    /// Bloc pour la blockchain
    /// </summary>
    internal class Bloc
    {
        /// <summary>
        /// Données du bloc
        /// </summary>
        public string Data { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Bloc Next { get; private set; } = null;

        /// <summary>
        /// Hash du bloc
        /// </summary>
        public string Hash { get; private set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="data">Donnée du bloc</param>
        public Bloc(string data) 
        {
            Data = data;
        }
    }
}

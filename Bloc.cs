
using System.Security.Cryptography;
using System.Text;

using System;
///Entreprise : ETML
///Auteur : Christopher Ristic 
///Date : 28.03.2025

namespace Blockchain
{
    internal class Bloc
    {
        public string Data { get; private set; }
        public Bloc Next { get; set; } = null;
        public Bloc Precedent { get; set; } = null;
        public string Hash { get; private set; }

        public Bloc(string data)
        {
            Data = data;
            Hash = CalculerHash();
        }

        private string CalculerHash()
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(Data);
                byte[] hashBytes = sha256.ComputeHash(dataBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}

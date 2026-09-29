using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProjetCarte.Modele
{
    internal class Carte
    {
        #region Attribut
        private string id;
        private string brand;

        private string model;

        private string variant;

        #endregion
        #region Construsteur
        public Carte()
        { }
        #endregion
        #region Getter/Setter 
        {
        [JsonPropertyName("id")]
        public static string Id { get; private set; }
        [JsonPropertyName("brand")]
        public static string brand { get; private set; }
        [JsonPropertyName ("model")]
        public static string model { get; private set; }
        [JsonPropertyName("variant")]
        public static string variant { get; private set; }
    }
        #region Méthode

        #endregion
    }
}

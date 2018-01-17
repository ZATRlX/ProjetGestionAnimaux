/// ETML
/// Auteur : Géraud Silvestri
/// Date : 17.01.2018
/// Description : controleur de la partie pour ajouter un animal
using System;
using MySql.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace X_133_silvestrge_AddAnimal
{
    public class Controller
    {
        private Accueil _view;
        static private string connectionString = @"SERVER=localhost;USERID=root;PASSWORD=;DATABASE= db_animals";
        private List<Weight> allWeights = new List<Weight>();

        //déclaration des objets
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlDataReader reader;

        public Controller()
        {

        }
        
        public Accueil View { get => _view; set => _view = value; }
        public List<Weight> AllWeights { get => allWeights; set => allWeights = value; }

        public bool AddData(string specie, string name, int age, int gender, string image, string dateOfBirth, int food, string comment, int weight, string vaccins, string race)
        {
            bool added = false;
            AllWeights.Add(new Weight(weight));

            string requete = "INSERT INTO t_animals(aniSpecies,aniName,aniAge,aniGender,aniAvatar,aniDateOfbirth,aniFood,aniComment) VALUES ("+specie+","+name+","+age+","+gender+","+image+","+dateOfBirth+","+food+","+comment+");";
            string requeteWeight="INSERT INTO weighs(weiCurrent, weiDate) VALUES ("+weight+","+DateTime.Now.ToString()+");";
            MySqlDataReader rdr = DoAQuery(requete);
            MySqlDataReader adapter = DoAQuery(requeteWeight);
           
            return added; 
        }

        /// <summary>
        /// établis une connexion à la base de données
        /// </summary>
        /// <param name="requete"></param>
        /// <returns></returns>
        private MySqlDataReader DoAQuery(string requete)
        {
            MySqlCommand acmd = new MySqlCommand(requete, connection);

            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            if (reader != null)
            {
                reader.Close();
            }

            reader = acmd.ExecuteReader();

            return reader;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace GestionDuCompte.Classes
{
    public class User
    {
        //TODO sortir ces variables et les rassembler
        public List<User> lstUser = new List<User>();
        public User currentUser;

        //Variables
        private string name;
        private string pseudo;
        private string mail;
        private string password;
        private string passPhrase;
        private string answer;
        //TODO Faire une liste de la classe animal
        private List<Animal> lstAnimals = new List<Animal>();
        private Dictionary<string, string> lstPublic = new Dictionary<string, string>();
        private string strPreferenceColor;
        //TODO Chercher le type d'une image
        private int profilePicture;
        //TODO Créer la classe Agenda
        private Dictionary<DateTime, string> agendaUser;

        //Get-Setters
        public string Name { get => name; set => name = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        public string PassPhrase { get => passPhrase; set => passPhrase = value; }
        public string Answer { get => answer; set => answer = value; }
        public List<Animal> LstAnimals { get => lstAnimals; set => lstAnimals = value; }
        public Dictionary<string, string> LstPublic { get => lstPublic; set => lstPublic = value; }
        public string StrPreferenceColor { get => strPreferenceColor; set => strPreferenceColor = value; }
        public int ProfilePicture { get => profilePicture; set => profilePicture = value; }
        public Dictionary<DateTime, string> AgendaUser { get => agendaUser; set => agendaUser = value; }

        //Constructeur
        /// <summary>
        /// Constructeur de la classe User
        /// </summary>
        /// <param name="name">Nom</param>
        /// <param name="pseudo">Pseudonyme</param>
        /// <param name="mail">Adresse mail</param>
        /// <param name="password">Mot de passe</param>
        /// <param name="passPhrase">Phrase secrète</param>
        /// <param name="answer">Réponse à la phrase secrète</param>
        /// <param name="profilePicture">Photo de profil</param>
        public User(string name, string pseudo, string mail,string password, string passPhrase, string answer, int profilePicture)
        {
            Name = name;
            Pseudo = pseudo;
            Mail = mail;
            Password = password;
            PassPhrase = passPhrase;
            Answer = answer;
            ProfilePicture = profilePicture;
            lstUser.Add(this);
        }

        //TODO Pseudo utilisé comme repère
        //TODO METHODES A METTRE DANS LE MODEL & LIER A LA BD
        /// <summary>
        /// Méthode servant à actualiser les données de l'utilisateur avec la base de donnée
        /// </summary>
        public void ActualizeUser()
        {
            //TODO Ajouter les variables restantes à la BD
            currentUser.Name = Convert.ToString(ExecuteQuery(@"SELECT Name FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
            currentUser.Mail = Convert.ToString(ExecuteQuery(@"SELECT Mail FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
            currentUser.Password = Convert.ToString(ExecuteQuery(@"SELECT Password FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
            currentUser.PassPhrase = Convert.ToString(ExecuteQuery(@"SELECT PassPhrase FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
            currentUser.Answer = Convert.ToString(ExecuteQuery(@"SELECT Answer FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
            currentUser.ProfilePicture = Convert.ToInt32(ExecuteQuery(@"SELECT ProfilePicture FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
            ActualizeAgendaUser();
        }
        /// <summary>
        /// Méthode servant à sauvegarder les changement de l'utilisateur dans la base de donnée
        /// </summary>
        public void SaveUserChanges()
        {
            //TODO Ajouter les variables restantes à la BD
            ExecuteQuery(@"UPDATE t_user SET Name = " + currentUser.Name + "WHERE Pseudo = " + currentUser.Pseudo + ";");
            ExecuteQuery(@"UPDATE t_user SET Mail = " + currentUser.Mail + "WHERE Pseudo = " + currentUser.Pseudo + ";");
            ExecuteQuery(@"UPDATE t_user SET Password = " + currentUser.Password + "WHERE Pseudo = " + currentUser.Pseudo + ";");
            ExecuteQuery(@"UPDATE t_user SET PassPhrase = " + currentUser.PassPhrase + "WHERE Pseudo = " + currentUser.Pseudo + ";");
            ExecuteQuery(@"UPDATE t_user SET Answer = " + currentUser.Answer + "WHERE Pseudo = " + currentUser.Pseudo + ";");
            ExecuteQuery(@"UPDATE t_user SET ProfilePicture = " + currentUser.ProfilePicture + "WHERE Pseudo = " + currentUser.Pseudo + ";");
        }

        public void ActualizeAgendaUser()
        {
            foreach(Animal animal in currentUser.LstAnimals)
            {
                string currentID = Convert.ToString(ExecuteQuery(@"SELECT idAnimals FROM t_animals WHERE Name = " + animal.Name + ";"));
                List<string> lstTemp = new List<string>();
                List<string> lstTempDate = new List<string>();
                List<string> lstTempDescrib = new List<string>();
                int i;

                //planned
                i = 0;
                rdr = ExecuteQuery(@"SELECT idVisit FROM planned WHERE idAnimals = " + currentID + ";");
                while (rdr.Read())
                {
                    lstTemp.Add(Convert.ToString(rdr.GetValue(i)));
                    i++;
                }
                i = 0;
                foreach(string id in lstTemp)
                {
                    rdr = ExecuteQuery(@"SELECT visDate FROM t_visit WHERE idVisit = " + id + ";");
                    while (rdr.Read())
                    {
                        lstTempDate.Add(Convert.ToString(rdr.GetValue(i)));
                        i++;
                    }
                    i = 0;
                    rdr = ExecuteQuery(@"SELECT visDescription FROM t_visit WHERE idVisit = " + id + ";");
                    while (rdr.Read())
                    {
                        lstTempDescrib.Add(Convert.ToString(rdr.GetValue(i)));
                        i++;
                    }
                }
                i = 0;
                foreach(string date in lstTempDate)
                {
                    animal.AgendaAnimal.Add(date, lstTempDescrib[i]);
                    ++i;
                }
                lstTemp.Clear();
                lstTempDate.Clear();
                lstTempDescrib.Clear();

                //follow
                i = 0;
                rdr = ExecuteQuery(@"SELECT id_vaccine FROM take WHERE idAnimals = " + currentID + ";");
                while (rdr.Read())
                {
                    lstTemp.Add(Convert.ToString(rdr.GetValue(i)));
                    i++;
                }
                i = 0;
                foreach (string id in lstTemp)
                {
                    rdr = ExecuteQuery(@"SELECT vacDate FROM t_vaccine WHERE id_vaccine = " + id + ";");
                    while (rdr.Read())
                    {
                        lstTempDate.Add(Convert.ToString(rdr.GetValue(i)));
                        i++;
                    }
                    i = 0;
                    rdr = ExecuteQuery(@"SELECT vacName FROM t_vaccine WHERE id_vaccine = " + id + ";");
                    while (rdr.Read())
                    {
                        lstTempDescrib.Add(Convert.ToString(rdr.GetValue(i)));
                        i++;
                    }
                }
                i = 0;
                foreach (string date in lstTempDate)
                {
                    animal.AgendaAnimal.Add(date, lstTempDescrib[i]);
                    ++i;
                }
                lstTemp.Clear();
                lstTempDate.Clear();
                lstTempDescrib.Clear();

                //birthday
                //TODO Continue
                if (System.DateTime.UtcNow - animal.Birthday <= 0) ;
            }
        }
        //

        //TODO Foreach lstAnimals
        /// <summary>
        /// Prend un animal de la liste de l'utilisateur
        /// </summary>
        /// <param name="nameAnimal">Nom de l'animal</param>
        /// <returns></returns>
        public Animal GetAnimal(string nameAnimal)
        {
            foreach (Animal animal in LstAnimals)
            {
                if (animal.Name == nameAnimal)
                {
                    return animal;
                }
            }
            return LstAnimals[0];
        }
        /// <summary>
        /// Ajoute un animal à la liste de l'utilisateur
        /// </summary>
        /// <param name="animal">Nom de l'animal</param>
        public void AddAnimal(Animal animal)
        {
            LstAnimals.Add(animal);
        }
        /// <summary>
        /// Enlève un animal de la liste de l'utilisateur
        /// </summary>
        /// <param name="animal">Nom de l'animal</param>
        public void RemoveAnimal(Animal animal)
        {
            LstAnimals.Remove(animal);
        }
        //TODO lstPublic, preferenceColor, profilPicture, agendaUser
        

        //HACK SQL
        //string servant de connection à la base de donnée. Utilisé dans l'objet MySqlConnection.
        static string connectionString = @"server=localhost;userid=root;password=;database=db_smartphones";

        //Objet qui sera utilisé dans les méthodes qui récupèrent des données
        SqlConnection connection = new SqlConnection(connectionString);

        //Objet "lecteur" de données 
        SqlDataReader rdr;
        

        /// <summary>
        /// Execute les commandes SQL dans la base de donnée
        /// </summary>
        /// <param name="query">commande à executer</param>
        /// <returns>MySqlDataReader rdr</returns>
        private SqlDataReader ExecuteQuery(string query)
        {
            SqlCommand acmd = new SqlCommand(query, connection);

            //Se connecte à la base de donnée
            if (connection != null && connection.State == connectionState.Closed)
            {
                connection.Open();
            }

            if (rdr != null)
            {
                rdr.Close();
            }

            //Execute la commande
            rdr = acmd.ExecuteReader();

            return rdr;
        }
    }
}
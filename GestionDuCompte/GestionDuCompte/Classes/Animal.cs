using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GestionDuCompte.Classes
{
    public class Animal
    {
        public Animal currentAnimal;

        //Variables
        private string species;
        private string name;
        private int age;
        private bool gender;
        private bool alive;
        private int avatar;
        private int agendaAnimal;
        private DateTime birthday;
        private int food;
        private Dictionary<DateTime, float> weight = new Dictionary<DateTime, float>();
        private int traitement;
        private User owner;

        //Get-Setters
        public string Specie { get => species; set => species = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool Gender { get => gender; set => gender = value; }
        public bool Alive { get => alive; set => alive = value; }
        public int Avatar { get => avatar; set => avatar = value; }
        public int AgendaAnimal { get => agendaAnimal; set => agendaAnimal = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public int Food { get => food; set => food = value; }
        public Dictionary<DateTime, float> Weight { get => weight; set => weight = value; }
        public int Traitement { get => traitement; set => traitement = value; }
        public User Owner { get => owner; set => owner = value; }

        //Constructeur
        /// <summary>
        /// Constructeur de la classe Animal
        /// </summary>
        /// <param name="specie">Espèce</param>
        /// <param name="name">Nom</param>
        /// <param name="age">Âge</param>
        /// <param name="gender">Genre</param>
        /// <param name="alive">En vie ou non</param>
        /// <param name="avatar">Photo de profil</param>
        /// <param name="birthday">Date d'anniversaire</param>
        /// <param name="food">Régime alimentaire</param>
        /// <param name="owner">Maître</param>
        public Animal(string specie, string name, int age, bool gender, bool alive, int avatar, DateTime birthday, int food, User owner)
        {
            Specie = specie;
            Name = name;
            Age = age;
            Gender = gender;
            Alive = alive;
            Avatar = avatar;
            Birthday = birthday;
            Food = food;
            Owner = owner;
            Owner.AddAnimal(this);
        }

        //TODO METHODES A METTRE DANS LE MODEL & LIER A LA BD
        /// <summary>
        /// Méthode servant à actualiser les données de l'utilisateur avec la base de donnée
        /// </summary>
        public void ActualizeUser()
        {
            //TODO Ajouter les variables restantes à la BD
            currentAnimal.Specie = Convert.ToString(ExecuteQuery(@"SELECT Specie FROM t_animals WHERE Name = " + currentAnimal.Name + ";"));
            currentAnimal.Age = Convert.ToInt32(ExecuteQuery(@"SELECT Age FROM t_animals WHERE Name = " + currentAnimal.Name + ";"));
            currentAnimal.Gender = Convert.ToBoolean(ExecuteQuery(@"SELECT Gender FROM t_animals WHERE Name = " + currentAnimal.Name + ";"));
            currentAnimal.Alive = Convert.ToBoolean(ExecuteQuery(@"SELECT Alive FROM t_animals WHERE Name = " + currentAnimal.Name + ";"));
            currentAnimal.Avatar = Convert.ToInt32(ExecuteQuery(@"SELECT Avatar FROM t_animals WHERE Name = " + currentAnimal.Name + ";"));
            currentAnimal.Birthday = Convert.ToDateTime(ExecuteQuery(@"SELECT Birthday FROM t_animals WHERE Name = " + currentAnimal.Name + ";"));
        }
        /// <summary>
        /// Méthode servant à sauvegarder les changement de l'utilisateur dans la base de donnée
        /// </summary>
        public void SaveUserChanges()
        {
            //TODO Ajouter les variables restantes à la BD
            ExecuteQuery(@"UPDATE t_Animal SET Specie = " + currentAnimal.Specie + "WHERE Name = " + currentAnimal.Name + ";");
            ExecuteQuery(@"UPDATE t_Animal SET Age = " + currentAnimal.Age + "WHERE Name = " + currentAnimal.Name + ";");
            ExecuteQuery(@"UPDATE t_Animal SET Gender = " + currentAnimal.Gender + "WHERE Name = " + currentAnimal.Name + ";");
            ExecuteQuery(@"UPDATE t_Animal SET Alive = " + currentAnimal.Alive + "WHERE Name = " + currentAnimal.Name + ";");
            ExecuteQuery(@"UPDATE t_Animal SET Avatar = " + currentAnimal.Avatar + "WHERE Name = " + currentAnimal.Name + ";");
            ExecuteQuery(@"UPDATE t_Animal SET Birthday = " + currentAnimal.Birthday + "WHERE Name = " + currentAnimal.Name + ";");
        }
        //
        /// <summary>
        /// Permet de dire si un animal est décédé
        /// </summary>
        /// <param name="died">Est mort ou non</param>
        public void Died(bool died)
        {
            Alive = !died;
            if (died)
            {
                Avatar = 0;//TODO Avatar = Image Grave in Classes, Traitement & Agenda = Null
                Traitement = 0;
                AgendaAnimal = 0;
            }
        }
        /// <summary>
        /// Rajoute une année à l'animal
        /// </summary>
        /// <param name="birthday">Permet de savoir si c'est l'anniversaire de l'animal</param>
        public void IsBirthday(bool birthday)
        {
            if (birthday && Alive)
            {
                Age++;
            }
        }


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
using System;
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
        private List<string> lstAnimals = new List<string>();
        private List<Dictionary<DateTime, string>> lstPublic = new List<Dictionary<DateTime, string>>();
        private string strPreferenceColor;
        //TODO Chercher le type d'une image
        private int profilePicture;
        //TODO Créer la classe Agenda
        private int agendaUser;

        //Get-Setters
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Pseudo
        {
            get
            {
                return pseudo;
            }
            set
            {
                pseudo = value;
            }
        }
        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string PassPhrase
        {
            get
            {
                return passPhrase;
            }
            set
            {
                passPhrase = value;
            }
        }
        public string Answer
        {
            get
            {
                return answer;
            }
            set
            {
                answer = value;
            }
        }
        public List<string> LstAnimals
        {
            get
            {
                return lstAnimals;
            }
            set
            {
                lstAnimals = value;
            }
        }
        public List<Dictionary<DateTime, string>> LstPublic
        {
            get
            {
                return lstPublic;
            }
            set
            {
                lstPublic = value;
            }
        }
        public string StrPreferenceColor
        {
            get
            {
                return strPreferenceColor;
            }
            set
            {
                strPreferenceColor = value;
            }
        }
        public int ProfilePicture
        {
            get
            {
                return profilePicture;
            }
            set
            {
                profilePicture = value;
            }
        }
        public int AgendaUser
        {
            get
            {
                return agendaUser;
            }
            set
            {
                agendaUser = value;
            }
        }

        //Constructeur
        public User(string name, string pseudo, string mail,string password, string passPhrase, string answer, List<string> lstAnimals, List<Dictionary<DateTime, string>> lstPublic, string strPreferenceColor, int profilePicture, int agendaUser)
        {
            Name = name;
            Pseudo = pseudo;
            Mail = mail;
            Password = password;
            PassPhrase = passPhrase;
            Answer = answer;
            LstAnimals = lstAnimals;
            LstPublic = lstPublic;
            StrPreferenceColor = strPreferenceColor;
            ProfilePicture = profilePicture;
            AgendaUser = agendaUser;
            lstUser.Add(this);
        }

        //TODO Pseudo utilisé comme repère
        //TODO METHODES A METTRE DANS LE MODEL & LIER A LA BD
        public void ActualizeUser()
        {
            //TODO Ajouter les variables restantes à la BD
            currentUser.Name = Convert.ToString(ExecuteQuery(@"SELECT Name FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
            currentUser.Mail = Convert.ToString(ExecuteQuery(@"SELECT Mail FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
            currentUser.Password = Convert.ToString(ExecuteQuery(@"SELECT Password FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
            currentUser.PassPhrase = Convert.ToString(ExecuteQuery(@"SELECT PassPhrase FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
            currentUser.Answer = Convert.ToString(ExecuteQuery(@"SELECT Answer FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
            currentUser.ProfilePicture = Convert.ToInt32(ExecuteQuery(@"SELECT ProfilePicture FROM t_user WHERE Pseudo = " + currentUser.Pseudo + ";"));
        }
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
        public string GetUserName()
        {
            return currentUser.Name;
        }
        public void ChangeUserName(string name)
        {
            currentUser.Name = name;
        }
        public string GetUserPseudo()
        {
            return currentUser.Pseudo;
        }
        public void ChangeUserPseudo(string pseudo)
        {
            currentUser.Pseudo = pseudo;
        }
        public string GetUserMail()
        {
            return currentUser.Mail;
        }
        public void ChangeUserMail(string mail)
        {
            currentUser.Mail = mail;
        }
        public string GetUserPassword()
        {
            return currentUser.Password;
        }
        public void ChangeUserPassword(string password)
        {
            currentUser.Password = password;
        }
        public string GetUserPassPhrase()
        {
            return currentUser.PassPhrase;
        }
        public void ChangeUserPassPhrase(string passPhrase)
        {
            currentUser.PassPhrase = passPhrase;
        }
        public string GetUserAnswer()
        {
            return currentUser.Answer;
        }
        public void ChangeUserAnswer(string answer)
        {
            currentUser.Answer = answer;
        }
        public List<string> GetLstAnimals()
        {
            return currentUser.LstAnimals;
        }
        //TODO Foreach lstAnimals
        public string GetAnimal(string nameAnimal)
        {
            return nameAnimal;
        }
        public void AddAnimal(string animal)
        {
            currentUser.LstAnimals.Add(animal);
        }
        public void RemoveAnimal(string animal)
        {
            currentUser.LstAnimals.Remove(animal);
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
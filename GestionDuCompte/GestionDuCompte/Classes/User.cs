using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public User(string name, string pseudo, string mail,string password, string passPhrase, List<string> lstAnimals, List<Dictionary<DateTime, string>> lstPublic, string strPreferenceColor, int profilePicture, int agendaUser)
        {
            Name = name;
            Pseudo = pseudo;
            Mail = mail;
            Password = password;
            PassPhrase = passPhrase;
            LstAnimals = lstAnimals;
            LstPublic = lstPublic;
            StrPreferenceColor = strPreferenceColor;
            ProfilePicture = profilePicture;
            AgendaUser = agendaUser;
            lstUser.Add(this);
        }

        //TODO Utiliser le pseudo comme repère dans la base de donnée
        //TODO METHODES A METTRE DANS LE MODE & LIER A LA BD
        public void ActualizeUser()
        {

        }
        public void SaveUserChanges()
        {

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
    }
}
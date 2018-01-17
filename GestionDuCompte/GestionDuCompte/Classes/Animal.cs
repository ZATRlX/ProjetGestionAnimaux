using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionDuCompte.Classes
{
    public class Animal
    {
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
            User usr = new User("b", "b", "b", "b", "b", "b", 1);
        }

        //Méthodes
        /// <summary>
        /// Permet de dire si un animal est décédé
        /// </summary>
        /// <param name="died">Est mort ou non</param>
        public void Died(bool died)
        {
            Alive = died;
        }
        /// <summary>
        /// Rajoute une année à l'animal
        /// </summary>
        /// <param name="birthday">Permet de savoir si c'est l'anniversaire de l'animal</param>
        public void IsBirthday(bool birthday)
        {
            if (birthday)
            {
                Age++;
            }
        }
    }
}
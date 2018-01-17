/// ETML
/// Auteur : Géraud Silvestri
/// Date : 17.01.2018
/// Description : gère les vaccins d'un animal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace X_133_silvestrge_AddAnimal
{
    public class Vaccine
    {
        private string _name;
        private DateTime _date;
        private string _comment;

        public string Comment { get => _comment; set => _comment = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime Date { get => _date; set => _date = value; }

        /// <summary>
        /// permet de créer un vaccin avec son nom et sa date
        /// </summary>
        /// <param name="name"></param>
        public Vaccine(string name)
        {
            _name = name;
            _date = DateTime.Now;
        }

        /// <summary>
        /// permet de rajouter un commentaire en plus du vaccin
        /// </summary>
        /// <param name="name"></param>
        /// <param name="comment"></param>
        public Vaccine(string name, string comment)
        {
            _name = name;
            _date = DateTime.Now;
            _comment = comment;
        }
    }
}
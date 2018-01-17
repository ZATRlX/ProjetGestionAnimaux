/// ETML
/// Auteur : Géraud Silvestri
/// Date : 17.01.2018
/// Description : gère le poids d'un animal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace X_133_silvestrge_AddAnimal
{
    public class Weight
    {
        //déclaration des variables
        private DateTime _date;
        private int _currentWeight;

        /// <summary>
        /// custom constructor
        /// </summary>
        /// <param name="weight"></param>
        public Weight(int weight)
        {
            _currentWeight = weight;
            _date = DateTime.Now;
        }

        public int CurrentWeight { get => _currentWeight; set => _currentWeight = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
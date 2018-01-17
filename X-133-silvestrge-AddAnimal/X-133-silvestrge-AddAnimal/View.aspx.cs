/// ETML
/// Auteur : Géraud Silvestri
/// Date : 15.01.2018
/// Description : Permet d'ajouter un nouvel animal dans la BDD
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace X_133_silvestrge_AddAnimal
{
    public partial class Accueil : System.Web.UI.Page
    {
        //déclaration des variables        
        private Controller _controller;

        /// <summary>
        /// définit le controleur de la vue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Controller control = new Controller();
            _controller = control;
            _controller.View = this;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtBName.Text;
            string type = cmbBType.Text;
            string race = txtBSpecies.Text;    
            string vaccine = cmbBoxVaccines.Text;
            string sexe = cmbBoxSexe.Text;
            int age=0;
            int food = 0;
            string path = txtBPath.Text;
            string comment = txtBoxComment.Text;
            int sexeB;
            int weight=0;
            Weight weigh;
            DateTime bDate = DateTime.Now ;
            string date = "";

            try
            {
                bDate = DateTime.Parse(txtBDate.Text);
                date = bDate.Date.ToString();
                date = date.Substring(0, 10);
            }
            catch
            {
                Response.Write("<script language=javascript>alert('Veuillez rentrer une date valide')</script>");
            }

            if (!Int32.TryParse(txtBAge.Text, out age))
                Response.Write("<script language=javascript>alert('Veuillez rentrer un age valide')</script>");

            if (!Int32.TryParse(txtBFood.Text, out food))
                Response.Write("<script language=javascript>alert('Veuillez rentrer une quantité de nourriture valide')</script>");

            if (!Int32.TryParse(txtBWeight.Text, out weight))
                Response.Write("<script language=javascript>alert('Veuillez rentrer un poids valide')</script>");

            if (sexe == "fille")
            {
                sexeB = 1;
            }

            else
                sexeB = 0;

            _controller.AddData(type, name, age, sexeB, path, date, food, comment, weight, vaccine, race);


        }

        protected void btnWeight_Click(object sender, EventArgs e)
        {
            
        }
    }
}
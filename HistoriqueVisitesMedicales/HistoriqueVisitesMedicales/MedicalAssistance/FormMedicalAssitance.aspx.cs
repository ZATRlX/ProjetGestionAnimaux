using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace HistoriqueVisitesMedicales
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //déclaration des variables
        static string connectionString = @"SERVER=localhost;USERID=root;PASSWORD=;DATABASE= db_animals";
        //déclaration des objets
        MySqlConnection connection = new MySqlConnection(connectionString);
        Dictionary<string, Image> dictionaryOfImages = new Dictionary<string, Image>();
        MySqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pTitle = this.tbTitle.Text;
            //DateTime pDate = DateTime.Parse(tbDate.Text);
            string pDoctor = this.tbDoctor.Text;
            string pPlace = this.tbPlace.Text;
            string pComment = this.tbComment.Text;
            string sqlRequete = @"INSERT INTO t_visit (NULL,pTitle ,pDate,pDoctor,pPlace.pComment,pAnimalIndex) VALUES (@idVisit,@visTitle ,@visDate,@visDoctorName,@visPlace,@visDesciption,@visAnimal);";
            MySqlCommand Cmd = new MySqlCommand(sqlRequete, connection);
            Cmd.ExecuteNonQuery();
         
            Response.Redirect("ListMedicalAssistance.aspx");
        }
    }
}
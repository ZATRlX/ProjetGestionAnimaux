using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HistoriqueVisitesMedicales
{
    public partial class ListMedicalAssistance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string sqlRequete = @"Select DISTINCT telNom FROM t_telephone;";

            //MySqlDataReader rdr = DoAQuery(sqlRequete);
            //while (rdr.Read())
            //{
            //    listNamePhone.Add(rdr.GetString(0));
            //}
            string pTitle;
            DateTime pDate;
            string pDoctor;
            string pPlace;
            string pComment;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListMedicalAssistanceEdit.aspx");
        }
    }
}
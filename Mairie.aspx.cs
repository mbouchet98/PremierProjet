using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PremierProjet
{
    public partial class Mairie1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Mairie maMairie = new Mairie(1,"nom","adresse", 1 );
            Mairie maMairie1 = new Mairie(2, "nom2", "adresse");

            DateTime maDateElection = new DateTime(1997, 01, 01);
            Maire monMaire = new Maire("leNomMaire1", "leprenomMaire", maDateElection,1);

            
            lblMairie.Text = monMaire.gsNomMaire + " " + monMaire.gsPrenomMaire;
            info.Controls.Add(new LiteralControl("<ul><li class='mar'>" + monMaire.gsDateElectionDuMaire + "</li><li class='mar'>" + monMaire.gsMairie + "</li></ul></table>"));

            lblMaire.Text = maMairie.gsNom1;
            donner.Controls.Add(new LiteralControl("<ul><li>" + maMairie.gsId1 + "</li><li>" + maMairie.gsAdresse1 + " </li><li> " + maMairie.gsNumEmployer + "</li></ul>"));

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PremierProjet
{
    public partial class Maire1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime maDateElection = new DateTime(1997, 01, 01);
            Maire monMaire = new Maire("leNomMaire", "leprenomMaire", maDateElection,1);
            
            Label1.Text = "Mon Premier Projet";
            contenu.Controls.Add(new LiteralControl("<table class='brd' > <tr> <th class='brd'> nom </th> <th class='brd'> prenom </th> <th class='brd'> DateElection </th> <th class='brd'> Mairie </th> </tr>"));
            contenu.Controls.Add(new LiteralControl("<tr class='color1'> <td th class='brd'>" + monMaire.gsNomMaire + " </td> <td class='brd'> " + monMaire.gsPrenomMaire + " </td> <td  class='brd'> " + monMaire.gsDateElectionDuMaire + " </td> <td  class='brd'> " + monMaire.gsMairie + " </td> </tr>"));
            contenu.Controls.Add(new LiteralControl("</table>"));
        }
    }
}
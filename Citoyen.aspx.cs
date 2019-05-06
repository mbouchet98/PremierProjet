using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace PremierProjet
{
    public partial class Citoyen1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime maDate= new DateTime(1997,01,01);
            Citoyen monCitoyen = new Citoyen("leNom", "lePrenom", maDate,"ladresse","lemail",0549996060);
            DateTime maDate1 = new DateTime(1966, 05, 05);
            Citoyen monCitoyen1 = new Citoyen("Nom", "Prenom", maDate1, "adresse", "email", 0645879623);
            Label1.Text = "Mon Premier Projet";
            contenu.Controls.Add(new LiteralControl("<table class='brd' > <tr> <th class='brd'> nom </th> <th class='brd'> prenom </th> <th class='brd'> Datenaissance </th> <th class='brd'> adresse </th> <th class='brd'> email </th> <th class='brd'> numTel </th> </tr>"));
            contenu.Controls.Add(new LiteralControl("<tr class='color1'> <td th class='brd'>" + monCitoyen.gsNom + " </td> <td class='brd'> " + monCitoyen.gsPrenom + " </td> <td  class='brd'> " + monCitoyen.gsDateDeNaissance + " </td> <td  class='brd'> " + monCitoyen.gsAdresse + " </td> <td  class='brd'> " + monCitoyen.sgEmail + " </td> <td  class='brd'> " + monCitoyen.gsNumTel + " </td> </tr>"));
            contenu.Controls.Add(new LiteralControl("<tr class='color2'> <td th class='brd'> " + monCitoyen1.gsNom + " </td> <td th class='brd'> " + monCitoyen1.gsPrenom + " </td> <td th class='brd'> " + monCitoyen1.gsDateDeNaissance + " </td> <td th class='brd'> " + monCitoyen1.gsAdresse + " </td> <td th class='brd'>" + monCitoyen1.sgEmail + " </td> <td th class='brd'> " + monCitoyen1.gsNumTel + " </td> </tr>"));
            contenu.Controls.Add(new LiteralControl("</table>"));
     
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventHandlerCreation
{
    public class EventHandlerEngine : System.Web.UI.Page
    {
        public EventHandlerEngine()
        {

        }
        public void transfererPerso(Object sender, EventArgs e)
        {
            Server.Transfer("Personnalisation.aspx", true);
        }
        public void transferDvdEnMain(Object sender, EventArgs e)
        {
            HttpContext _context = HttpContext.Current;
            _context.Items.Add("Mode", "Main");
            Server.Transfer("AffichageDVD.aspx");
        }
        public void transferDvdAutrui(Object sender, EventArgs e)
        {
            HttpContext _context = HttpContext.Current;
            _context.Items.Add("Mode", "Autrui");
            Server.Transfer("AffichageDVD.aspx");
        }
        public void transferCreerUnDVD(Object sender, EventArgs e)
        {
            HttpContext _context = HttpContext.Current;
            _context.Items.Add("Mode", "Ajouter");
            Server.Transfer("DetailDVD.aspx");
        }
        public void transferDvdTout(Object sender, EventArgs e)
        {
            HttpContext _context = HttpContext.Current;
            Server.Transfer("AffichageDVD.aspx");
        }
        public void disconnect(Object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx", true);
        }
        public void transferMultiplesDVD(Object sender, EventArgs e)
        {
            Server.Transfer("AjouterPlusieursDVD.aspx", true);
        }
        public void verifyUserCredentials(Object sender, EventArgs e)
        {
            Server.Transfer("AffichageDVD.aspx", true);
            //Server.Transfer("DetailDVD.aspx?mot=1", true);
            //Server.Transfer("DetailDVD.aspx ? mot =roseline & password = pass@123");
            //Response.Redirect("DetailDVD.aspx?name =roseline&password=pass@123");

            /*
            HttpContext _context = HttpContext.Current;
            _context.Items.Add("Mode", "Supprimer");
            Server.Transfer("DetailDVD.aspx");
            */
        }
        public void ajouterDVD(Object sender, EventArgs e)
        {
            Server.Transfer("AffichageDVD.aspx", true);
        }
        public void transfererCourriel(Object sender, EventArgs e)
        {
            //Server.Transfer("Courriel.aspx", true);

            // Server.Transfer("AffichageDVD.aspx", true);
            Server.Transfer("Courriel.aspx");
        }
        public void transfererGestionUtil(Object sender, EventArgs e)
        {
            //Server.Transfer("Courriel.aspx", true);

            // Server.Transfer("AffichageDVD.aspx", true);
            Server.Transfer("GestionUtilisateur.aspx");
        }
        public void transferDetailDVD(Object sender, EventArgs e)
        {
            HttpContext _context = HttpContext.Current;
            _context.Items.Add("Mode", "Visualiser");
            Server.Transfer("DetailDVD.aspx");
        }
        public void transferModifierDVD(Object sender, EventArgs e)
        {
            HttpContext _context = HttpContext.Current;
            _context.Items.Add("Mode", "Modifier");
            Server.Transfer("DetailDVD.aspx");
        }
        public void transferSupprimerDVD(Object sender, EventArgs e)
        {
            HttpContext _context = HttpContext.Current;
            _context.Items.Add("Mode", "Supprimer");
            Server.Transfer("DetailDVD.aspx");
        }
        public void transferCourriel(Object sender, EventArgs e)
        {
            HttpContext _context = HttpContext.Current;
            _context.Items.Add("Mode", "Supprimer");
            Server.Transfer("DetailDVD.aspx");
        }
        public void transferApproprierDVD(Object sender, EventArgs e)
        {
            HttpContext _context = HttpContext.Current;
            _context.Items.Add("Mode", "Approprier");
            Server.Transfer("DetailDVD.aspx");
        }

        public void verifierLogin(Object sender, EventArgs e)
        {

        }

    }
}

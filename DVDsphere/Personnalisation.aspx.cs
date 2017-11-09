using ElementCreation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Personnalisation : System.Web.UI.Page
{
    public ElementCreator elementCreator = new ElementCreator();
    protected void Page_Load(object sender, EventArgs e)
    {
        elementCreator.generateHeader(headerPlaceHolder, 1);
        elementCreator.generatePersonnalisation(dvdDetailPlaceHolder, 0);

        elementCreator.generateFooter(footerPlaceHolder);
    }
}
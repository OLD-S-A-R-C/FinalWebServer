using ElementCreation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    public ElementCreator elementCreator = new ElementCreator();

    protected void Page_Load(object sender, EventArgs e)
    {
        elementCreator.generateHeader(headerPlaceHolder, 0);
        elementCreator.generateLoginDynamic(loginPlaceHolder);
        elementCreator.generateFooter(footerPlaceHolder);
    }

    public void verifyUserCredentials(Object sender, EventArgs e)
    {

    }
}
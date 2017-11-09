using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;
using EventHandlerCreation;

namespace ElementCreation
{
    public class ElementCreator : System.Web.UI.Page
    {
        public EventHandlerEngine eventHandlerEngine = new EventHandlerEngine();

        public void generateHeader(Control Conteneur, int intCodeUtilisateur)
        {
            Panel panelHeader = divDYN(Conteneur, "divPanelHeader", "", HorizontalAlign.Center);

            if (intCodeUtilisateur == 0)
            {
                Literal br = new Literal();
                br.Text = "<div id='divEntete' class='sEntete'> <p class='sTitreApplication'>DVDsphere ☭</p><p class=' rainbow' >L</p></div>";
                panelHeader.Controls.Add(br);
            }
            else if(intCodeUtilisateur == 1)
            {
                Literal br = new Literal();
                br.Text = "<div id='divEntete' class='sEntete'><p class='sTitreApplication red-orange-brown' >DVDsphere ☭</p><p class=' rainbow' >L</p><p>";
                panelHeader.Controls.Add(br);
                /*
                    "<a href = 'AffichageDVD.aspx' >DVDS EN MAIN</a>" +
                    "<a href = 'XXX.php' >DVDs D'AUTRUI</a>" +
                    "<a href = 'XXX.php' >TOUT LES DVDS</a>" +
                    "<a href = 'XXX.php' >PERSONNALISATION</a>" +
                    "<a href = 'XXX.php' >COURRIEL ✉</a>";*/
                LinkButton link = new LinkButton();
                link.ID = "btnDvdEnMain";
                link.Text = "DVDS EN MAIN";
                link.Click += eventHandlerEngine.transferDvdEnMain;
                panelHeader.Controls.Add(link);
                //transferDvdAutrui

                link = new LinkButton();
                link.ID = "btnDvdAutrui";
                link.Text = "DVDS D'AUTRUI";
                link.Click += eventHandlerEngine.transferDvdAutrui;
                panelHeader.Controls.Add(link);

                link = new LinkButton();
                link.ID = "btnDvdTout";
                link.Text = "TOUT LES DVDS";
                link.Click += eventHandlerEngine.transferDvdTout;
                panelHeader.Controls.Add(link);

                
                link = new LinkButton();
                link.ID = "btnPerso";
                link.Text = "PERSONNALISATION";
                link.Click += eventHandlerEngine.transfererPerso;
                panelHeader.Controls.Add(link);

                link = new LinkButton();
                link.ID = "btnCourriel";
                link.Text = "COURRIEL ✉";
                link.Click += eventHandlerEngine.transfererCourriel;
                panelHeader.Controls.Add(link);

                link = new LinkButton();
                link.ID = "btnDeonnexion";
                link.Text = "DÉCONNEXION";
                link.Click += eventHandlerEngine.disconnect;
                panelHeader.Controls.Add(link);

                link = new LinkButton();
                link.ID = "btnGestion";
                link.Text = "GESTIONS(A)";
                link.Click += eventHandlerEngine.transfererGestionUtil;
                panelHeader.Controls.Add(link);

                br = new Literal();
                br.Text = "</div>";
                panelHeader.Controls.Add(br);




            }
            else if (intCodeUtilisateur == 2)
            {
                Literal br = new Literal();
                br.Text = "<div id='divEntete' class='sEntete'><p class='sTitreApplication red-orange-brown' >QWERTY</p><p class=' rainbow' >L</p><p><a href = 'affichageAnnonce.php' >AFFICHAGE ANNONCES</a><a href = 'affichageUtilisateur.php' >AFFICHAGE UTILISATEURS</a> <a href = 'Page 3' >OPTION BASE DE DONNÉES</a> <a href = 'deconnexion.php' >DÉCONNEXION</ a ><span class='sNomUtilisateur'>(administrateur) NomUtilisateur</span></p></div>";
                panelHeader.Controls.Add(br);
            }
            Conteneur.Controls.Add(panelHeader);
        }

        public void generateFooter(Control Conteneur)
        {
            Literal br = new Literal();
            br.Text = "<footer><p>&copy; DVDsphere <span class='sPiedPage'>Une idée original d'Ariel Sashcov, Mohamed Cherifi et Gabriel Roy</span></p></footer>";
            Conteneur.Controls.Add(br);
        }
        public void generateLogin(Control Conteneur1, Control Conteneur2, Control Conteneur3, EventHandler nomFonction)
        {
            Literal br = new Literal();
            br.Text = "<div align='center'><br><br><table><tr><td colspan = '3' style = 'text-align:center'><br><span style = 'font-weight:bold;font-size: 60px;font-family:Arial Black;'> DVDsphere </span ><br></td></tr><tr ><td colspan = '2' ><br ><span style = 'font-weight:bold' > Connectez - vous avec un compte existant</ span ><br ></td > <td rowspan = '4' ></td ></tr ><tr ><td ><input id = 'tbCourriel' name = 'tbCourriel' type = 'text' class='textbox' placeholder='Courriel'><br></td> </tr><tr><td><input id = 'tbMDP' name='tbMDP' type='password' class='textbox' placeholder='Mot de passe'><br></td></tr><tr><td colspan = '2' >";
            Conteneur1.Controls.Add(br);

            Button btn = new Button();
            btn.ID = "btnConnexion";
            btn.Text = "Se connecter";
            btn.CssClass = "btn";
            btn.Click += nomFonction;
            Conteneur2.Controls.Add(btn);

            Literal br2 = new Literal();
            br2.Text = " </table></div>";
            Conteneur3.Controls.Add(br2);
        }

        public void generateLoginDynamic(Control Conteneur)
        {
            Panel panelDivLogin = divDYN(Conteneur, "divLogin", "", HorizontalAlign.Center);

            Literal br = new Literal();
            br.Text = "<div align='center'><br><br><table><tr><td colspan = '3' style = 'text-align:center'><br><span style = 'font-weight:bold;font-size: 60px;font-family:Arial Black;'> DVDsphere </span ><br></td></tr><tr ><td colspan = '2' ><br ><span style = 'font-weight:bold' > Connectez - vous avec un compte existant</ span ><br ></td > <td rowspan = '4' ></td ></tr ><tr ><td ><input id = 'tbCourriel' name = 'tbCourriel' type = 'text' class='textbox' style='background-color: #fb9898' placeholder='Le courriel ou/et le mot de passe est incorrect!'><br></td> </tr><tr><td><input id = 'tbMDP' name='tbMDP' type='password' value='*********' class='textbox' style='background-color: #98FB98'placeholder='Mot de passe'><br></td></tr><tr><td colspan = '2' >";
            panelDivLogin.Controls.Add(br);

            Button btn = new Button();
            btn.ID = "btnConnexion";
            btn.Text = "Se connecter";
            btn.CssClass = "btn";
            btn.Click += eventHandlerEngine.verifyUserCredentials;
            panelDivLogin.Controls.Add(btn);

            Literal br2 = new Literal();
            br2.Text = "&nbsp;&nbsp;&nbsp;<a href = 'changerPasswordAnonyme.php' style='color: rgb(66,165,220);'>mot de passe oublié?</a><br></td></tr> </table></div>";
            panelDivLogin.Controls.Add(br2);

            Conteneur.Controls.Add(panelDivLogin);
        }

        public void generateDvdSelection(Control Conteneur)
        {
            Literal br = new Literal();
            br.Text = "<div align=right><table > <input type=text class=textbox placeholder='Termes de recherche' style=margin-right:20px><input type=button style=font-weight:bold;margin-top:10px;margin-right:40px class=btn value='Rechercher' onClick=changePage('AffichageCompletAnnonceCreer.php')><select><option disabled selected hidden> Trié par</option>" +
                "<option value=DateParution>Ordre alphabétique de titre (Croissant)</option>" +
                "<option value=DateParution>Ordre alphabétique de titre (Déroissant)</option>" +
                "<option value=Categorie>Ordre alphabétique d'utilisateur (Croissant)</option>" +
                "<option value=Categorie>Ordre alphabétique d'utilisateur (Déroissant)</option>" +
                "<option value=DescriptionAbregee>Ordre alphabétique de titres français (Croissant)</option>" +
                "<option value=DescriptionAbregee>Ordre alphabétique de titres français (Déroissant)</option></select>&nbsp;Nb Résultats<select>" +
                "<option value=5>5</option>" +
                "<option value=10>10</option>" +
                "<option value=15>15</option>" +
                "<option value=10>20</option>" +
                "<option value=15>25</option>" +
                "<option value=10>30</option>" +
                "<option value=10>35</option>" +
                "<option value=15>40</option>" +
                "<option value=10>45</option>" +
                "<option value=15>50</option>" +
                "<option value=15>55</option>" +
                "<option value=10>60</option>" +
                "<option value=15>65</option>" +
                "<option value=10>70</option>" +
                "<option value=15>75</option>" +
                "<option value=10>80</option>" +
                "<option value=15>85</option>" +
                "<option value=10>90</option>" +
                "<option value=10>95</option>" +
                "<option value=10>100</option></select> ";
            Conteneur.Controls.Add(br);

            br = new Literal();
            br.Text = "&nbsp;";
            Conteneur.Controls.Add(br);

            Button btn = new Button();
            btn.ID = "btnAjouterUnDVD";
            btn.Text = "Ajouter un DVD";
            btn.CssClass = "btn";
            btn.Attributes.Add("Style", "font-weight:bold");
            btn.Click += eventHandlerEngine.transferCreerUnDVD;
            Conteneur.Controls.Add(btn);

            br = new Literal();
            br.Text = "&nbsp;";
            Conteneur.Controls.Add(br);

            btn = new Button();
            btn.ID = "btnAjouterDesDVD";
            btn.Text = "Ajouter des DVD";
            btn.CssClass = "btn";
            btn.Attributes.Add("Style", "font-weight:bold");
            btn.Click += eventHandlerEngine.transferMultiplesDVD;
            Conteneur.Controls.Add(btn);

            br = new Literal();
            br.Text = "&nbsp;";
            Conteneur.Controls.Add(br);

            br = new Literal();
            br.Text = "</table></div>";

            Conteneur.Controls.Add(br);
        }

        public void generateDVDlist(Control conteneur)
        {
            HttpContext _context = HttpContext.Current;
            if(_context.Items["Mode"]==null)
            {
                generateDVD(conteneur, "images/171112.jpg", "Gabriel Roy", "À tout jamais", "200", true, "1");
                generateDVD(conteneur, "images/171201.jpg", "Gabriel Roy", "Au travers de l'univers", "200", true, "2");
                generateDVD(conteneur, "images/171001.jpg", "Gabriel Roy", "Apocalypse Maintenant", "200", true, "3");
                generateDVD(conteneur, "images/171013.jpg", "Ariel Sashcov", "Cadavres", "45", false, "4");
                generateDVD(conteneur, "images/171003.jpg", "Gabriel Roy", "Danny Ocean 13", "200", true, "5");
                generateDVD(conteneur, "images/171002.jpg", "Ariel Sashcov", "Dans une galaxie près de chez vous", "45", false, "6");
                generateDVD(conteneur, "images/171118.jpg", "Ariel Sashcov", "Dans une galaxie près de chez vous 2", "45", false, "7");
                generateDVD(conteneur, "images/171008.jpg", "Gabriel Roy", "F.O.U.", "200", true, "8");
                generateDVD(conteneur, "images/171114.jpg", "Ariel Sashcov", "L'agence", "45", false, "9");
                generateDVD(conteneur, "images/171104.jpg", "Ariel Sashcov", "12 hommes pas content", "45", false, "10");
            }
            else if (_context.Items["Mode"].Equals("Autrui"))
            {
                generateDVD(conteneur, "images/171013.jpg", "", "Cadavres", "45", false, "1");
                generateDVD(conteneur, "images/171002.jpg", "", "Dans une galaxie près de chez vous", "45", false, "2");
                generateDVD(conteneur, "images/171118.jpg", "", "Dans une galaxie près de chez vous 2", "45", false, "3");
                generateDVD(conteneur, "images/171114.jpg", "", "L'agence", "45", false, "4");
                generateDVD(conteneur, "images/171104.jpg", "", "12 hommes pas content", "45", false, "5");
            }
            else if (_context.Items["Mode"].Equals("Main"))
            {
                generateDVD(conteneur, "images/171112.jpg", "", "À tout jamais", "200", true, "1");
                generateDVD(conteneur, "images/171201.jpg", "", "Au travers de l'univers", "200", true, "2");
                generateDVD(conteneur, "images/171001.jpg", "", "Apocalypse Maintenant", "200", true, "3");
                generateDVD(conteneur, "images/171003.jpg", "", "Danny Ocean 13", "200", true, "4");
                generateDVD(conteneur, "images/171008.jpg", "", "F.O.U.", "200", true, "5");
            }
            else
            {
                generateDVD(conteneur, "images/171112.jpg", "Gabriel Roy", "À tout jamais", "200", true, "1");
                generateDVD(conteneur, "images/171201.jpg", "Gabriel Roy", "Au travers de l'univers", "200", true, "2");
                generateDVD(conteneur, "images/171001.jpg", "Gabriel Roy", "Apocalypse Maintenant", "200", true, "3");
                generateDVD(conteneur, "images/171013.jpg", "Ariel Sashcov", "Cadavres", "45", false, "4");
                generateDVD(conteneur, "images/171003.jpg", "Gabriel Roy", "Danny Ocean 13", "200", true, "5");
                generateDVD(conteneur, "images/171002.jpg", "Ariel Sashcov", "Dans une galaxie près de chez vous", "45", false, "6");
                generateDVD(conteneur, "images/171118.jpg", "Ariel Sashcov", "Dans une galaxie près de chez vous 2", "45", false, "7");
                generateDVD(conteneur, "images/171008.jpg", "Gabriel Roy", "F.O.U.", "200", true, "8");
                generateDVD(conteneur, "images/171114.jpg", "Ariel Sashcov", "L'agence", "45", false, "9");
                generateDVD(conteneur, "images/171104.jpg", "Ariel Sashcov", "12 hommes pas content", "45", false, "10");
            }


        }

        public void generateDVD(Control Conteneur, String strImgUrl, String strUser, String strTitre, String  strRGB, Boolean boolProprio, String strNbr)
        {
            /*
            for(int i = 0; i < intNbrDVD;i++)
            {
                strBrValue += "<div align='center' style='margin-top: 10px;'><table  border='0'><tr><td style='vertical-align:middle;font-weight:bold;font-weight:bold;font-size: 60px;' rowspan='5'>"+i.ToString().PadLeft(2, '0') + "</td><td style='vertical-align:middle;font-weight:bold;padding-top: 15px;' rowspan='5'> <img src='144png.png'></td><td style='vertical-align:middle;font-weight:bold;padding-top: 15px;font-size: 30px;' colspan='1'>Titre français du DVD </td><td style='vertical-align:middle;font-weight:bold;padding-top: 15px;font-size: 20px;text-align:right;padding-right: 15px;' colspan='1'>Catégorie: Documentaire</td><td style='vertical-align:middle;font-weight:bold;padding-top: 15px;font-size: 20px;text-align:left;padding-right: 0px;' rowspan='1'>No. 00784</td><td rowspan='5' style='min-width: 100px;'>   <br><br></td></tr><tr><td style='vertical-align:middle;font-weight:bold;padding-top: 15px;' colspan='2' rowspan='1'><a href='contacterAuteur.php'>Nom de l’utilisateur ayant le DVD en main</a> </td><td style='vertical-align:bottom;font-weight:bold;text-align:left;' rowspan='4'><br></td><tr><td colspan='2' style='min-width: 600px;' rowspan='3'><a href='affichageCompletAnnonce.php'>Ceci est une petite description du DVD en question.</td></tr></tr></table>   </div> ";
            }
            */

            Literal br = new Literal();
            
            br.Text = "<div align='center' style='margin-top: 10px;'><table  border='0'><tr><td style='vertical-align:middle;font-weight:bold;font-weight:bold;font-size: 60px;' rowspan='5'>" + strNbr.PadLeft(2, '0') + "</td><td style='vertical-align:middle;font-weight:bold;padding-top: 15px;' rowspan='5'> <img src='" + strImgUrl + "'></td><td style='color: rgb("+strRGB+ "," + strRGB + "," + strRGB + ");vertical-align:middle;font-weight:bold;padding-top: 15px;font-size: 30px;' colspan='1'>" + strTitre + "</td><td style='vertical-align:middle;font-weight:bold;padding-top: 15px;font-size: 20px;text-align:right;padding-right: 15px;' colspan='1'><!--Categorie--></td><td style='vertical-align:middle;font-weight:bold;padding-top: 15px;font-size: 20px;text-align:left;padding-right: 0px;' rowspan='1'></td><td rowspan='5' style='min-width: 10px;'>   <br><br></td></tr><tr><td style='vertical-align:middle;font-weight:bold;padding-top: 15px;' colspan='2' rowspan='1'><a href='contacterAuteur.php'>" + strUser + "</a> </td><td style='vertical-align:bottom;font-weight:bold;text-align:left;' rowspan='4'><br></td><tr><td colspan='2' style='min-width: 600px;vertical-align: bottom;' rowspan='3'><a href='affichageCompletAnnonce.php'>";
            Conteneur.Controls.Add(br);

            if (boolProprio)
            {
                Button btn = new Button();
                btn.ID = "btnVisualiser" + strTitre.Replace("  ", "");
                btn.Text = "Visualiser";
                btn.CssClass = "btn";
                btn.Click += eventHandlerEngine.transferDetailDVD;
                Conteneur.Controls.Add(btn);

                br = new Literal();
                br.Text = "&nbsp;";
                Conteneur.Controls.Add(br);

                btn = new Button();
                btn.ID = "btnModifier" + strTitre.Replace("  ", "");
                btn.Text = "Modifier";
                btn.CssClass = "btn";
                btn.Click += eventHandlerEngine.transferModifierDVD;
                Conteneur.Controls.Add(btn);

                br = new Literal();
                br.Text = "&nbsp;";
                Conteneur.Controls.Add(br);

                btn = new Button();
                btn.ID = "btnSupprimer" + strTitre.Replace("  ", "");
                btn.Text = "Supprimer";
                btn.CssClass = "btn";
                btn.Click += eventHandlerEngine.transferSupprimerDVD;
                Conteneur.Controls.Add(btn);
            }
            else
            {
                Button btn = new Button();
                btn.ID = "btnVisualiser" + strTitre.Replace("  ", "");
                btn.Text = "Visualiser";
                btn.CssClass = "btn";
                btn.Click += eventHandlerEngine.transferDetailDVD;
                Conteneur.Controls.Add(btn);

                br = new Literal();
                br.Text = "&nbsp;";
                Conteneur.Controls.Add(br);

                btn = new Button();
                btn.ID = "btnCourriel" + strTitre.Replace("  ", "");
                btn.Text = "Courriel";
                btn.CssClass = "btn";
                btn.Click += eventHandlerEngine.transfererCourriel;
                Conteneur.Controls.Add(btn);

                br = new Literal();
                br.Text = "&nbsp;";
                Conteneur.Controls.Add(br);

                btn = new Button();
                btn.ID = "btnApproprier" + strTitre.Replace("  ", "");
                btn.Text = "Approprier";
                btn.CssClass = "btn";
                btn.Click += eventHandlerEngine.transferApproprierDVD;
                Conteneur.Controls.Add(btn);
            }


            br = new Literal();
            br.Text = "<!--Description--></td></tr></tr></table>   </div> ";
            Conteneur.Controls.Add(br);

        }
        
        public void generateDvdPageSelection(Control Conteneur)
        {
            Literal br = new Literal();
            br.Text = "<div align='center' style='margin-top: 10px;'><table><tr><td><input type='button' style='font-weight:bold;margin-top:10px;margin-left:10px' class='btn' value='◄◄' onClick='firstPage()'><input type='button' style='font-weight:bold;margin-top:10px;margin-left:10px' class='btn' value='◄' onClick='backPage()'><select id='selectPage1' style='font-weight:bold;margin-top:10px;margin-left:10px' onChange='changePage(this.options[this.selectedIndex].value)'><option value='1'>1</option><option value='2'>2</option><option value='3'>3</option><option value='4'>4</option></select> <input type='button' style='font-weight:bold;margin-top:10px;margin-left:10px' class='btn' value='►' onClick='nextPage()'><input type='button' style='font-weight:bold;margin-top:10px;margin-left:10px' class='btn' value='►►' onClick='lastPage()'></td></tr></table></div>";
            Conteneur.Controls.Add(br);
        }

        public Panel divDYN(Control Conteneur, String strID, String strCssClass, HorizontalAlign horizontal)
        {
            Panel panel = new Panel();
            panel.ID = strID;
            panel.CssClass = strCssClass;
            panel.HorizontalAlign = HorizontalAlign.Center;
            return panel;
        }

        public Image imgDYN(Control Conteneur, String strID, String strUrlImg)
        {
            Image img = new Image();
            img.ID = strID;
            img.ImageUrl = strUrlImg;

            return img;
        }

        public TextBox tbDYN(Control conteneur, String strID, String strPlaceHolder, String strType, String strStyle, String strCssClass, String strMaxLength)
        {
            TextBox tb = new TextBox();
            tb.ID = strID;
            tb.CssClass = strCssClass;
            tb.Attributes.Add("Style", strStyle);
            tb.Attributes.Add("Type", strType);
            tb.Attributes.Add("placeholder", strPlaceHolder);
            tb.Attributes.Add("maxlength", strMaxLength);
            return tb;
        }

        public TextBox textAreaDYN(Control conteneur, String strID, String strPlaceHolder, String strType, String strStyle, String strCssClass, String strMaxLength)
        {
            TextBox tb = new TextBox();
            tb.ID = strID;
            tb.TextMode = TextBoxMode.MultiLine;
            tb.CssClass = strCssClass;
            tb.Attributes.Add("Style", strStyle);
            tb.Attributes.Add("Type", strType);
            tb.Attributes.Add("placeholder", strPlaceHolder);
            tb.Attributes.Add("maxlength", strMaxLength);
            return tb;
        }

        public CheckBox chkDYN(Control conteneur, String strID, bool boolChecked, String strCssClass, String strStyle)
        {
            CheckBox chk = new CheckBox();
            chk.ID = strID;
            chk.Checked = boolChecked;
            chk.CssClass = strCssClass;
            chk.Attributes.Add("Style", strStyle);
            return chk;
        }

        public FileUpload fileUploadDYN(Control conteneur, String strID, bool boolVisible, String strCssClass)
        {
            FileUpload flu = new FileUpload();
            flu.ID = strID;
            flu.CssClass = strCssClass;
            flu.Visible = boolVisible;
            return flu;
        }

        public Label labelDyn(Control conteneur, String strID, String strText)
        {
            Label lb = new Label();
            lb.ID = strID;
            lb.Text = strText;
            return lb;
        }

        public DropDownList ddlDYN(Control conteneur, String strID, String strCssClass, String[] strListItems)
        {
            DropDownList ddl = new DropDownList();
            ddl.ID = strID;
            ddl.CssClass = strCssClass;
            ddl.Attributes.Add("size", "1");

            foreach(String strItem in strListItems)
            {
                ListItem lstItem = new ListItem();
                lstItem.Value = strItem;
                lstItem.Text = strItem;

                ddl.Items.Add(lstItem);
            }

            
            return ddl;
        }

        public void generateDetailDVD(Control Conteneur, int intMode)
        {
            HttpContext _context = HttpContext.Current;

            Panel panelDivDVD = new Panel();
            panelDivDVD.ID = "divDVD";
            panelDivDVD.CssClass = "";
            panelDivDVD.Attributes.Add("align", "center");
            panelDivDVD.Attributes.Add("style", "padding-top:10px;padding-bottom:40px;align='center;");

            Literal br = new Literal();
            br.Text = "<table border='0'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "<tr><td colspan='3'></td></tr><tr><td colspan='3' style='color: #18A3FA;text-align:center;align='center;font-weight:bold;font-size:30px;'>";
            panelDivDVD.Controls.Add(br);

            Label lb = new Label();
            lb.ID = "lbFonction";
            if (_context.Items["Mode"]==null)
            {
                lb.Text = "AJOUTER UN DVD";
            }
            else if (_context.Items["Mode"].Equals("Ajouter"))
            {
                lb.Text = "AJOUTER UN DVD";
            }
            else if (_context.Items["Mode"].Equals("Modifier"))
            {
                lb.Text = "MODIFIER UN DVD";
            }
            else if (_context.Items["Mode"].Equals("Approprier"))
            {
                lb.Text = "APPROPRIER UN DVD";
            }
            else if (_context.Items["Mode"].Equals("Supprimer"))
            {
                lb.Text = "SUPPRIMER UN DVD";
            }
            else
            {
                lb.Text = "VISUALISER UN DVD";
            }

            lb.Attributes.Add("Style", "font-weight:bold;font-size:30px;");

            panelDivDVD.Controls.Add(lb);


            br = new Literal();
            br.Text = "</td></tr>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "<tr><th rowspan='1' colspan='3' style='text-align:center'>";
            panelDivDVD.Controls.Add(br);

            Image img = imgDYN(panelDivDVD, "imgDVD", "600png.png");

            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                 img = imgDYN(panelDivDVD, "imgDVD", "600png.png");
            }
            else
            {
                 img = imgDYN(panelDivDVD, "imgDVD", "images/171001.jpg");
            }


            panelDivDVD.Controls.Add(img);
            
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Titre français: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            TextBox tb = tbDYN(panelDivDVD, "tbTitreFrancais", "","text", "width: 300px", "textbox","50");
            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = "Apocalypse Maintenant";
            }

            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser") || _context.Items["Mode"].Equals("Supprimer") || _context.Items["Mode"].Equals("Approprier"))
                {
                    tb.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(tb);

            br = new Literal();
            br.Text = "</td></tr><tr><th style='padding-top: 10px;padding-left: 20px;'>Titre original: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbTitreOriginal", "", "text", "width: 300px", "textbox", "50");
            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = "Apocalypse Now";
            }
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser")|| _context.Items["Mode"].Equals("Supprimer")|| _context.Items["Mode"].Equals("Approprier"))
                {
                    tb.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(tb);

            br = new Literal();
            br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td<td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr style='margin-top: 10px;padding-left: 20px;'><th style='padding-top: 10px;padding-left: 20px;'>Catégorie: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            String[] lstCategorie = {"Action","Adolescent","Biographie","Cape et d'épée","Catastrophe","Chronique","Comédie de mœurs","Comédie d'horreur","Comédie dramatique","Comédie fantaisiste","Comédie musicale","Comédie policière","Comédie satirique","Comédie sentimentale","Comédie","Criminel","Danse","Dessins animés","Documentaire","Drame de guerre","Drame de mœurs","Drame d'horreur","Drame judiciaire","Drame musical","Drame poétique","Drame policier","Drame psychologique","Drame sentimental","Drame social","Drame","Espionnage","Expérimental","Fantastique","Film à sketches","Film d'animation","Film d'art martial","Historique","Horreur","Humoristique","Marionnettes","Mélodrame","Musical","Road movie","Romantique","Science-fiction","Série policière","Série TV","Spectacle d'humour","Spectacle musical","Suspense","Western"};

            DropDownList ddl = ddlDYN(panelDivDVD,"ddlCategorie","", lstCategorie);
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser") || _context.Items["Mode"].Equals("Supprimer") || _context.Items["Mode"].Equals("Approprier"))
                {
                    ddl.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(ddl);

            br = new Literal();
            br.Text = "</td></tr><tr style='margin-top: 30px;padding-left: 20px;'><th style='padding-top: 10px;padding-left: 20px;'>Format: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            String[] lstFormat = { "Normal", " Panoramique", " Blu-Ray" };

            ddl = ddlDYN(panelDivDVD, "ddlFormat", "", lstFormat);
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser")|| _context.Items["Mode"].Equals("Supprimer")|| _context.Items["Mode"].Equals("Approprier"))
                {
                    ddl.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(ddl);

            br = new Literal();
            br.Text = "</td></tr><tr style='margin-top: 30px;padding-left: 20px;'><th style='padding-top: 10px;padding-left: 20px;'>Langue: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            String[] lstLangue = { "anglais"," français"," espagnol" };

            ddl = ddlDYN(panelDivDVD, "ddlLangue", "", lstLangue);
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser"))
                {
                    ddl.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(ddl);

            br = new Literal();
            br.Text = "</td></tr><tr style='margin-top: 30px;padding-left: 20px;'><th style='padding-top: 10px;padding-left: 20px;'>Sous-titre: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            ddl = ddlDYN(panelDivDVD, "ddlSousTitre", "", lstLangue);
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser") || _context.Items["Mode"].Equals("Supprimer") || _context.Items["Mode"].Equals("Approprier"))
                {
                    ddl.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(ddl);

            br = new Literal();
            br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr style='margin-top: 30px;padding-left: 20px;'><th style='padding-top: 10px;padding-left: 20px;'>Producteur:</th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbProducteur", "", "text", "width: 300px", "textbox", "50");
            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = "Francis Ford Coppola";
            }
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser") || _context.Items["Mode"].Equals("Supprimer") || _context.Items["Mode"].Equals("Approprier"))
                {
                    tb.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(tb);

            br = new Literal();
            br.Text = "</td></tr><tr style='padding-top: 0px;padding-left: 20px;'><th style='padding-top: 10px;padding-left: 20px;'>Realisateur:</th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbRealisateur", "", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);
            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = "John Milius";
            }
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser") || _context.Items["Mode"].Equals("Supprimer") || _context.Items["Mode"].Equals("Approprier"))
                {
                    tb.Enabled = false;
                }
            }
            br = new Literal();
            br.Text = "</td></tr><tr style='padding-top: 0px;padding-left: 20px;'><th style='padding-top: 10px;padding-left: 20px;'>Acteur #1:</th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbActeur1", "", "text", "width: 300px", "textbox", "50");
            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = "Martin Sheen";
            }
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser") || _context.Items["Mode"].Equals("Supprimer") || _context.Items["Mode"].Equals("Approprier"))
                {
                    tb.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(tb);

            br = new Literal();
            br.Text = "</td></tr><tr style='padding-top: 0px;padding-left: 20px;'><th style='padding-top: 10px;padding-left: 20px;'>Acteur #2:</th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbActeur2", "", "text", "width: 300px", "textbox", "50");
            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = "Marlon Brando";
            }
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser") || _context.Items["Mode"].Equals("Supprimer") || _context.Items["Mode"].Equals("Approprier"))
                {
                    tb.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(tb);

            br = new Literal();
            br.Text = "</td></tr><tr style='padding-top: 0px;padding-left: 20px;'><th style='padding-top: 10px;padding-left: 20px;'>Acteur #3:</th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbActeur3", "", "text", "width: 300px", "textbox", "50");
            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = "Robert Duvall";
            }
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser") || _context.Items["Mode"].Equals("Supprimer") || _context.Items["Mode"].Equals("Approprier"))
                {
                    tb.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(tb);

            br = new Literal();
            br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr ><td colspan='3' style='padding-top: 25px;padding-left: 20px;'><span style='font-weight: bold;padding-right: 5px;'>Durée:</span>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbDuree", "120", "number", "width: 40px;", "textbox", "50");
            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = "147";
            }
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser") || _context.Items["Mode"].Equals("Supprimer") || _context.Items["Mode"].Equals("Approprier"))
                {
                    tb.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(tb);
             
            br = new Literal();
            br.Text = " <span style='font-weight: bold;padding-right: 5px;padding-left: 5px;'>Année de sortie:</span>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbAnnee", "2017", "number", "width: 50px;", "textbox", "50");
            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = "1979";
            }
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser") || _context.Items["Mode"].Equals("Supprimer") || _context.Items["Mode"].Equals("Approprier"))
                {
                    tb.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(tb);

            br = new Literal();
            br.Text = " <span style='font-weight: bold;padding-right: 5px;padding-left: 5px;'>Disques:</span>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbDisques", "1", "number", "width: 30px;", "textbox", "50");
            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = "1";
            }
            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser") || _context.Items["Mode"].Equals("Supprimer") || _context.Items["Mode"].Equals("Approprier"))
                {
                    tb.Enabled = false;
                }
            }
            panelDivDVD.Controls.Add(tb);

            br = new Literal();
            br.Text = "</td></tr><tr><td colspan='3' style='padding-left: 20px;'><span style='font-weight: bold;padding-right: 5px;'>Original:</span>";
            panelDivDVD.Controls.Add(br);

            CheckBox chk = chkDYN(panelDivDVD, "chkOriginal", false, "sTitreCentree", "width: 30px;");
            panelDivDVD.Controls.Add(chk);

            br = new Literal();
            br.Text = "<span style='font-weight: bold;padding-right: 5px;padding-left: 35px;'>Version étendu:</span>";
            panelDivDVD.Controls.Add(br);

            chk = chkDYN(panelDivDVD, "chkVersion", false, "sTitreCentree", "width: 30px;");
            panelDivDVD.Controls.Add(chk);

            br = new Literal();
            br.Text = "<span style='font-weight: bold;padding-right: 5px;padding-left: 70px'>Visible:</span>";
            panelDivDVD.Controls.Add(br);

            chk = chkDYN(panelDivDVD, "chkVisible", false, "sTitreCentree", "width: 30px;");
            panelDivDVD.Controls.Add(chk);

            FileUpload flu = fileUploadDYN(panelDivDVD, "imgFileUpload", true, "btn");
            if (_context.Items["Mode"] == null)
            {
                br = new Literal();
                br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr style='padding-left: 20px;'><th style='padding-top: 25px;padding-left: 20px;'>Vignette:</th><th style='padding-top: 15px;padding-left: 20px;'>";
                panelDivDVD.Controls.Add(br);
                panelDivDVD.Controls.Add(flu);
            }
            else if (_context.Items["Mode"].Equals("Ajouter"))
            {
                br = new Literal();
                br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr style='padding-left: 20px;'><th style='padding-top: 25px;padding-left: 20px;'>Vignette:</th><th style='padding-top: 15px;padding-left: 20px;'>";
                panelDivDVD.Controls.Add(br);
                panelDivDVD.Controls.Add(flu);
            }
            else if (_context.Items["Mode"].Equals("Modifier"))
            {
                br = new Literal();
                br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr style='padding-left: 20px;'><th style='padding-top: 25px;padding-left: 20px;'>Vignette:</th><th style='padding-top: 15px;padding-left: 20px;'>";
                panelDivDVD.Controls.Add(br);
                panelDivDVD.Controls.Add(flu);
            }
            else
            {
                br = new Literal();
                br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr style='padding-left: 20px;'><th style='padding-top: 25px;padding-left: 20px;'></th><th style='padding-top: 15px;padding-left: 20px;'>";
                panelDivDVD.Controls.Add(br);
            }

            br = new Literal();
            br.Text = "</th><th style='padding-top: 15px;padding-left: 20px;'></th></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td colspan='3'><p style='color: #18A3FA;'>Résumé du film </p>";
            panelDivDVD.Controls.Add(br);

            tb = textAreaDYN(panelDivDVD, "tbDescription", "", "text", "width: 600px; height:100px", "textbox", "50");
            if (lb.Text.Equals("AJOUTER UN DVD"))
            {
                tb.Text = "";
            }
            else
            {
                tb.Text = "During the Vietnam War, Captain Willard is sent on a dangerous mission into Cambodia to assassinate a renegade colonel who has set himself up as a god among a local tribe.";
            }
            panelDivDVD.Controls.Add(tb);

            br = new Literal();
            br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr> <tr><td colspan='3' style='text-align:center'>";
            panelDivDVD.Controls.Add(br);

            Button btn = new Button();
            btn.ID = "btnAjouter";
            btn.Text = "Ajouter";
            if (_context.Items["Mode"] == null)
            {
                btn.Text = "Ajouter";
            }
            else if (_context.Items["Mode"].Equals("Ajouter"))
            {
                btn.Text = "Ajouter";
            }
            else if (_context.Items["Mode"].Equals("Modifier"))
            {
                btn.Text = "Modifier";
            }
            else if (_context.Items["Mode"].Equals("Approprier"))
            {
                btn.Text = "Appropier";
            }
            else if (_context.Items["Mode"].Equals("Supprimer"))
            {
                btn.Text = "Supprimer";
            }
            else
            {
                btn.Visible = false;
            }
            btn.CssClass = "btn";
            btn.Click += eventHandlerEngine.ajouterDVD;
            panelDivDVD.Controls.Add(btn);

            br = new Literal();
            br.Text = "</td><tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><tr><td colspan='3' style='color: #18A3FA;'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "Propriétaire: Gabriel Roy";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</td></tr><tr><td colspan='3' style='color: #18A3FA;'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "Emprunteur: Gabriel Roy";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</td></tr><td colspan='3' style='color: #18A3FA;'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "Dernière mise à jour effectuée le 2 novembre 2017 par Gabriel Roy";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</table>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</td></tr>";
            panelDivDVD.Controls.Add(br);

            if (_context.Items["Mode"] != null)
            {
                if (_context.Items["Mode"].Equals("Visualiser"))
                {

                }
            }

                Conteneur.Controls.Add(panelDivDVD);
        }

        public void generateAjouterPlusieursDVD(Control Conteneur, int intMode)
        {
            HttpContext _context = HttpContext.Current;

            Panel panelDivDVD = new Panel();
            panelDivDVD.ID = "divDVD";
            panelDivDVD.CssClass = "";
            panelDivDVD.Attributes.Add("align", "center");
            panelDivDVD.Attributes.Add("style", "padding-top:10px;padding-bottom:40px;align='center;");

            Literal br = new Literal();
            br.Text = "<table border='0'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "<tr><td colspan='3'></td></tr><tr><td colspan='3' style='color: #18A3FA;text-align:center;align='center;font-weight:bold;font-size:30px;'>";
            panelDivDVD.Controls.Add(br);

            Label lb = new Label();
            lb.ID = "lbFonction";

            lb.Text = "AJOUTER PLUSIEURS DVDS";


            lb.Attributes.Add("Style", "font-weight:bold;font-size:30px;");

            panelDivDVD.Controls.Add(lb);


            br = new Literal();
            br.Text = "</td></tr>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "<tr><th rowspan='1' colspan='3' style='text-align:center'>";
            panelDivDVD.Controls.Add(br);


           ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Titre Français #1: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            TextBox tb = tbDYN(panelDivDVD, "tbFilm1", "", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);
            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Titre Français #2: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbFilm2", "", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);
            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Titre Français #3: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbFilm3", "", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Titre Français #4: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbFilm4", "", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Titre Français #5: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbFilm5", "", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Titre Français #6: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbFilm6", "", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Titre Français #7: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbFilm7", "", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Titre Français #8: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbFilm8", "", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Titre Français #9: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbFilm9", "", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Titre Français #10: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbFilm10", "", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);


            br = new Literal();
            br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr> <tr><td colspan='3' style='text-align:center'>";
            panelDivDVD.Controls.Add(br);

            Button btn = new Button();
            btn.ID = "btnAjouter";
            btn.Text = "Ajouter";
                btn.Text = "Ajouter";
            btn.CssClass = "btn";
            btn.Click += eventHandlerEngine.ajouterDVD;
            panelDivDVD.Controls.Add(btn);

            br = new Literal();
            br.Text = "</td><tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><tr><td colspan='3' style='color: #18A3FA;'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "Propriétaire: Gabriel Roy";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</td></tr><tr><td colspan='3' style='color: #18A3FA;'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "Emprunteur: Gabriel Roy";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</td></tr><td colspan='3' style='color: #18A3FA;'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "Dernière mise à jour effectuée le 2 novembre 2017 par Gabriel Roy";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</table>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</td></tr>";
            panelDivDVD.Controls.Add(br);

            Conteneur.Controls.Add(panelDivDVD);
        }

        public void generatePersonnalisation(Control Conteneur, int intMode)
        {
            HttpContext _context = HttpContext.Current;

            Panel panelDivDVD = new Panel();
            panelDivDVD.ID = "divDVD";
            panelDivDVD.CssClass = "";
            panelDivDVD.Attributes.Add("align", "center");
            panelDivDVD.Attributes.Add("style", "padding-top:10px;padding-bottom:40px;align='center;");

            Literal br = new Literal();
            br.Text = "<table border='0'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "<tr><td colspan='3'></td></tr><tr><td colspan='3' style='color: #18A3FA;text-align:center;align='center;font-weight:bold;font-size:30px;'>";
            panelDivDVD.Controls.Add(br);

            Label lb = new Label();
            lb.ID = "lbFonction";

            lb.Text = "PERSONNALISATION";


            lb.Attributes.Add("Style", "font-weight:bold;font-size:30px;");

            panelDivDVD.Controls.Add(lb);


            br = new Literal();
            br.Text = "</td></tr>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "<tr><th rowspan='1' colspan='3' style='text-align:center'>";
            panelDivDVD.Controls.Add(br);


            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Nouveau mot de passe: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            TextBox tb = tbDYN(panelDivDVD, "tbFilm1", "Écrire votre nouveau mot de passe", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);
            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Nouveau mot de passe: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbFilm2", "Récrire votre nouveau mot de passe", "text", "width: 300px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);
            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'></th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            Button btn2 = new Button();
            btn2.ID = "btnChanger";
            btn2.Text = "Changer mot de passe";
            btn2.CssClass = "btn";
            btn2.Click += eventHandlerEngine.ajouterDVD;
            panelDivDVD.Controls.Add(btn2);
            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-left: 80px;'>";
            panelDivDVD.Controls.Add(br);
            CheckBox chk = chkDYN(panelDivDVD, "chkVersion", false, "sTitreCentree", "width: 30px;");
            panelDivDVD.Controls.Add(chk);
            // désire recevoir un courriel lors d’ajout d’un ou plusieurs DVDs ?

            br = new Literal();
            br.Text = "</th><td style='' colspan='2'> Désirez-vous recevoir un courriel lors d’ajout d’un ou plusieurs DVDs ";
            panelDivDVD.Controls.Add(br);
            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-left: 80px;'>";
            panelDivDVD.Controls.Add(br);
            chk = chkDYN(panelDivDVD, "chkCourrielDVD", false, "sTitreCentree", "width: 30px;");
            panelDivDVD.Controls.Add(chk);
            // désire recevoir un courriel lors d’ajout d’un ou plusieurs DVDs ?

            br = new Literal();
            br.Text = "</th><td style='' colspan='2'> Désirez-vous recevoir un courriel lors du retrait d’un DVD?";
            panelDivDVD.Controls.Add(br);
            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-left: 80px;'>";
            panelDivDVD.Controls.Add(br);
            chk = chkDYN(panelDivDVD, "chkCourrielRetrait", false, "sTitreCentree", "width: 30px;");
            panelDivDVD.Controls.Add(chk);
            // désire recevoir un courriel lors d’ajout d’un ou plusieurs DVDs ?

            br = new Literal();
            br.Text = "</th><td style='' colspan='2'> Désirez-vous recevoir un courriel lors de l’appropriation d’un DVD ? ";
            panelDivDVD.Controls.Add(br);
            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-left: 80px;'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "<select>" +
                "<option value=5>5</option>" +
                "<option value=10>10</option>" +
                "<option value=15>15</option>" +
                "<option value=10>20</option>" +
                "<option value=15>25</option>" +
                "<option value=10>30</option>" +
                "<option value=10>35</option>" +
                "<option value=15>40</option>" +
                "<option value=10>45</option>" +
                "<option value=15>50</option>" +
                "<option value=15>55</option>" +
                "<option value=10>60</option>" +
                "<option value=15>65</option>" +
                "<option value=10>70</option>" +
                "<option value=15>75</option>" +
                "<option value=10>80</option>" +
                "<option value=15>85</option>" +
                "<option value=10>90</option>" +
                "<option value=10>95</option>" +
                "<option value=10>100</option></select> ";
            panelDivDVD.Controls.Add(br);
            // désire recevoir un courriel lors d’ajout d’un ou plusieurs DVDs ?

            br = new Literal();
            br.Text = "</th><td style='' colspan='2'> Nombre de DVDs à afficher par page? ";
            panelDivDVD.Controls.Add(br);


            br = new Literal();
            br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr> <tr><td colspan='3' style='text-align:center'>";
            panelDivDVD.Controls.Add(br);

            Button btn = new Button();
            btn.ID = "btnConfirmer";
            btn.Text = "Confirmer";
            btn.CssClass = "btn";
            btn.Click += eventHandlerEngine.ajouterDVD;
            panelDivDVD.Controls.Add(btn);

            br = new Literal();
            br.Text = "</td><tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><tr><td colspan='3' style='color: #18A3FA;'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</table>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</td></tr>";
            panelDivDVD.Controls.Add(br);

            Conteneur.Controls.Add(panelDivDVD);
        }

        public void generateCourriel(Control Conteneur, int intMode)
        {
            HttpContext _context = HttpContext.Current;

            Panel panelDivDVD = new Panel();
            panelDivDVD.ID = "divDVD";
            panelDivDVD.CssClass = "";
            panelDivDVD.Attributes.Add("align", "center");
            panelDivDVD.Attributes.Add("style", "padding-top:10px;padding-bottom:40px;align='center;");

            Literal br = new Literal();
            br.Text = "<table border='0'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "<tr><td colspan='3'></td></tr><tr><td colspan='3' style='color: #18A3FA;text-align:center;align='center;font-weight:bold;font-size:30px;'>";
            panelDivDVD.Controls.Add(br);

            Label lb = new Label();
            lb.ID = "lbFonction";

            lb.Text = "Courriel";


            lb.Attributes.Add("Style", "font-weight:bold;font-size:30px;");

            panelDivDVD.Controls.Add(lb);


            br = new Literal();
            br.Text = "</td></tr>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "<tr><th rowspan='1' colspan='3' style='text-align:center'>";
            panelDivDVD.Controls.Add(br);


            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Destinataires: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            TextBox tb = tbDYN(panelDivDVD, "tbFilm1", "Destinataires", "text", "width: 500px", "textbox", "50");
            tb.Text = "Gabriel Roy (Groy@gmail.com); Ariel Sashcov (Ariel@gmail.com)";
            panelDivDVD.Controls.Add(tb);

            CheckBox chk = chkDYN(panelDivDVD, "chkCourrielRetrait", false, "sTitreCentree", "width: 30px;");
            chk.Text = "Tout le monde";
            panelDivDVD.Controls.Add(chk);
            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Objet: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = tbDYN(panelDivDVD, "tbFilm2", "Nouveau film sur DVD!", "text", "width: 600px", "textbox", "50");
            tb.Text = "Nouveau film sur DVD!";
            panelDivDVD.Controls.Add(tb);
            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'></th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            tb = textAreaDYN(panelDivDVD, "tbDescription", "", "text", "width: 600px; height:100px", "textbox", "50");
            tb.Text = "Zootopia est maintenant sortie en DVD chez Best Buy. Qui va le chercher?";
            panelDivDVD.Controls.Add(tb);
            
            br = new Literal();
            br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr> <tr><td colspan='3' style='text-align:center'>";
            panelDivDVD.Controls.Add(br);

            Button btn = new Button();
            btn.ID = "btnConfirmer";
            btn.Text = "Envoyer";
            btn.CssClass = "btn";
            btn.Click += eventHandlerEngine.ajouterDVD;
            panelDivDVD.Controls.Add(btn);

            br = new Literal();
            br.Text = "</td><tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><tr><td colspan='3' style='color: #18A3FA;'>";
            panelDivDVD.Controls.Add(br);


            br = new Literal();
            br.Text = "</table>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</td></tr>";
            panelDivDVD.Controls.Add(br);

            Conteneur.Controls.Add(panelDivDVD);
        }

        public void generateGestion(Control Conteneur, int intMode)
        {
            HttpContext _context = HttpContext.Current;

            Panel panelDivDVD = new Panel();
            panelDivDVD.ID = "divDVD";
            panelDivDVD.CssClass = "";
            panelDivDVD.Attributes.Add("align", "center");
            panelDivDVD.Attributes.Add("style", "padding-top:10px;padding-bottom:40px;align='center;");

            Literal br = new Literal();
            br.Text = "<table border='0'>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "<tr><td colspan='3'></td></tr><tr><td colspan='3' style='color: #18A3FA;text-align:center;align='center;font-weight:bold;font-size:30px;'>";
            panelDivDVD.Controls.Add(br);

            Label lb = new Label();
            lb.ID = "lbFonction";

            lb.Text = "Gestion Utilisateur";


            lb.Attributes.Add("Style", "font-weight:bold;font-size:30px;");

            panelDivDVD.Controls.Add(lb);


            br = new Literal();
            br.Text = "</td></tr>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "<tr><th rowspan='1' colspan='3' style='text-align:center'>";
            panelDivDVD.Controls.Add(br);


            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Nouveau Utilisateur: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            TextBox tb = tbDYN(panelDivDVD, "tbUtil", "Identifiant", "text", "width: 100px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);
            //////////////////////////////////////////////
            br = new Literal();
            br.Text = "&nbsp;&nbsp;&nbsp;";
            panelDivDVD.Controls.Add(br);
            //////////////////////////////////////////////
            tb = tbDYN(panelDivDVD, "tbMotDePasse", "Courriel", "text", "width: 100px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);
            //////////////////////////////////////////////
            br = new Literal();
            br.Text = "&nbsp;&nbsp;&nbsp;";
            panelDivDVD.Controls.Add(br);
            //////////////////////////////////////////////
            tb = tbDYN(panelDivDVD, "tbMotDePasse23f", "Récrire courriel ", "text", "width: 100px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);
            //////////////////////////////////////////////
            br = new Literal();
            br.Text = "&nbsp;&nbsp;&nbsp;";
            panelDivDVD.Controls.Add(br);
            //////////////////////////////////////////////
            tb = tbDYN(panelDivDVD, "tbMotDePasse3", "Mot de passe", "text", "width: 100px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);
            //////////////////////////////////////////////
            br = new Literal();
            br.Text = "&nbsp;&nbsp;&nbsp;";
            panelDivDVD.Controls.Add(br);
            //////////////////////////////////////////////
            tb = tbDYN(panelDivDVD, "tbMotDePasse4", "Récrire mot de passe", "text", "width: 100px", "textbox", "50");
            panelDivDVD.Controls.Add(tb);

            br = new Literal();
            br.Text = "&nbsp;&nbsp;&nbsp;";
            panelDivDVD.Controls.Add(br);

            Button btn = new Button();
            btn.ID = "btnConfirmer";
            btn.Text = "Ajouter";
            btn.CssClass = "btn";
            btn.Click += eventHandlerEngine.transfererGestionUtil;
            panelDivDVD.Controls.Add(btn);

            br = new Literal();
            br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr>";
            panelDivDVD.Controls.Add(br);
            CheckBox chk; /*= chkDYN(panelDivDVD, "chkCourrielRetrait", false, "sTitreCentree", "width: 30px;");
            chk.Text = "SuperUtilisateur";
            panelDivDVD.Controls.Add(chk);*/

            for(int i = 0; i<10;i++)
            {
                br = new Literal();
                br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-left: 20px;padding-top: 0px'>Utilisateur #"+(i+1)+": </th><td style='' colspan='2'>";
                panelDivDVD.Controls.Add(br);
                //////////////////////////////////////////////
                br = new Literal();
                br.Text = "&nbsp;&nbsp;&nbsp;";
                panelDivDVD.Controls.Add(br);
                //////////////////////////////////////////////
                tb = tbDYN(panelDivDVD, "tbUtil"+i, "Gabriel Roy", "text", "width: 100px", "textbox", "50");
                tb.Text = "Gabriel Roy";
                panelDivDVD.Controls.Add(tb);
                //////////////////////////////////////////////
                br = new Literal();
                br.Text = "&nbsp;&nbsp;&nbsp;";
                panelDivDVD.Controls.Add(br);
                //////////////////////////////////////////////
                tb = tbDYN(panelDivDVD, "tbMotDePassfe" + i, "groy@gmail.com", "text", "width: 100px", "textbox", "50");
                tb.Text = "groy@gmail.com";
                panelDivDVD.Controls.Add(tb);
                //////////////////////////////////////////////
                br = new Literal();
                br.Text = "&nbsp;&nbsp;&nbsp;";
                panelDivDVD.Controls.Add(br);
                //////////////////////////////////////////////
                tb = tbDYN(panelDivDVD, "tbMotDePasse4" + i, "********", "text", "width: 100px", "textbox", "50");
                tb.Text = "*******************";
                panelDivDVD.Controls.Add(tb);
                //////////////////////////////////////////////
                br = new Literal();
                br.Text = "&nbsp;&nbsp;&nbsp;";
                panelDivDVD.Controls.Add(br);
                //////////////////////////////////////////////
                chk = chkDYN(panelDivDVD, "chkCourrielRetrait" + i, false, "sTitreCentree", "width: 30px;");
                chk.Text = "Super";
                panelDivDVD.Controls.Add(chk);
                //////////////////////////////////////////////
                br = new Literal();
                br.Text = "&nbsp;&nbsp;&nbsp;";
                panelDivDVD.Controls.Add(br);
                //////////////////////////////////////////////
                btn = new Button();
                btn.ID = "btnModifierUtil" + i;
                btn.Text = "Modifier";
                btn.CssClass = "btn";
                btn.Click += eventHandlerEngine.transfererGestionUtil;
                panelDivDVD.Controls.Add(btn);
                //////////////////////////////////////////////
                br = new Literal();
                br.Text = "&nbsp;&nbsp;&nbsp;";
                panelDivDVD.Controls.Add(br);
                //////////////////////////////////////////////
                btn = new Button();
                btn.ID = "btnSupprimer" + i;
                btn.Text = "Supprimer";
                btn.CssClass = "btn";
                btn.Click += eventHandlerEngine.transfererGestionUtil;
                panelDivDVD.Controls.Add(btn);
                //////////////////////////////////////////////
                br = new Literal();
                br.Text = "&nbsp;&nbsp;&nbsp;";
                panelDivDVD.Controls.Add(br);
                //////////////////////////////////////////////
                btn = new Button();
                btn.ID = "btnDVD" + i;
                btn.Text = "DVD";
                btn.CssClass = "btn";
                btn.Click += eventHandlerEngine.transferDvdAutrui;
                panelDivDVD.Controls.Add(btn);
            }

            br = new Literal();
            br.Text = "</td></tr><tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr>";
            panelDivDVD.Controls.Add(br);
            


            ////////////////////////////////////////////////////////////////////////
            br = new Literal();
            br.Text = "</th></tr><tr><td colspan='3'></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><th style='padding-top: 10px;padding-left: 20px;'>Objet: </th><td style='' colspan='2'>";
            panelDivDVD.Controls.Add(br);

            /*
            tb = tbDYN(panelDivDVD, "tbFilm2", "Nouveau film sur DVD!", "text", "width: 600px", "textbox", "50");
            tb.Text = "Nouveau film sur DVD!";
            panelDivDVD.Controls.Add(tb);*/
            ////////////////////////////////////////////////////////////////////////

            br.Text = "</td><tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><td></td><td></td><td></td></tr> <tr><tr><td colspan='3' style='color: #18A3FA;'>";
            panelDivDVD.Controls.Add(br);


            br = new Literal();
            br.Text = "</table>";
            panelDivDVD.Controls.Add(br);

            br = new Literal();
            br.Text = "</td></tr>";
            panelDivDVD.Controls.Add(br);

            Conteneur.Controls.Add(panelDivDVD);
        }

    }
}
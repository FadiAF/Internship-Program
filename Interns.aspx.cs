using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using iTextSharp.text;

using iTextSharp.text.pdf;

using iTextSharp.text.html.simpleparser;
using iTextSharp.text.html;
using InternshipProgramModel;
using System.IO;
using System.Text.RegularExpressions;

public partial class Interns : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        InternshipProgramEntities context = new InternshipProgramEntities();
        bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
        var deps = context.Departments;
        foreach (Department dep in deps)
        {
            ddl.Items.Add(new System.Web.UI.WebControls.ListItem(dep.DepName.ToString(), dep.DepID.ToString()));
        }
        if (val1)
        {
            log.InnerHtml = "Welcome " + User.Identity.Name;
        }
        if (Roles.IsUserInRole("admin"))
        {
            log.InnerHtml += " Add Intern";
            log.HRef = "./newIntern.aspx";
        }
        else if (Roles.IsUserInRole("employee"))
        {
            log.InnerHtml += "";
            log.HRef = "";
        }
        else
        {
            log.InnerHtml = "Login/Register";
            log.HRef = "./Login.aspx";
        }
        if (Request.QueryString.Count == 0)
        {

            var candids = context.Intern1;
            foreach (Intern1 i in candids)
            {
                HtmlGenericControl NewControl = new HtmlGenericControl("div");
                NewControl.ID = i.ID.ToString();
                HtmlTable tbl = new HtmlTable();
                //HtmlTableRow cell1 = new HtmlTableRow();
                //HtmlTableCell cll1 = new HtmlTableCell();
                //cll1.InnerHtml = string.Format("<a href='/intern.aspx?id=" + i.ID + "'><img src='" + i.photo + "' width='25%' height='25%' align='center'/></a>");
                //cell1.Cells.Add(cll1);
                HtmlTableRow cell2 = new HtmlTableRow();
                HtmlTableCell cll2 = new HtmlTableCell();
                cll2.InnerHtml = string.Format("<a href='/intern.aspx?id=" + i.ID + "'>" + i.FirstName + " " + i.LastName + "</a>");
                cell2.Cells.Add(cll2);
                HtmlTableRow cell3 = new HtmlTableRow();
                HtmlTableCell cll3 = new HtmlTableCell();
                cll3.InnerHtml = i.Mobile.ToString();
                cell3.Cells.Add(cll3);
                HtmlTableRow cell4 = new HtmlTableRow();
                HtmlTableCell cll4 = new HtmlTableCell();
                cll4.InnerHtml = i.Email;
                cell4.Cells.Add(cll4);
                HtmlTableRow cell5 = new HtmlTableRow();
                HtmlTableCell cll5 = new HtmlTableCell();
                Button button2 = new Button();
                button2.Text = "Delete";
                button2.CssClass = i.ID.ToString();
                button2.Click += Button2_Click;
                button2.Attributes.Add("runat", "server");
                //cll5.Controls.Add(button2);
                cell5.Cells.Add(cll5);
                //tbl.Rows.Add(cell1);
                tbl.Rows.Add(cell2);
                tbl.Rows.Add(cell3);
                tbl.Rows.Add(cell4);
                tbl.Rows.Add(cell5);
                tbl.Style.Add("align", "center");
                NewControl.Controls.Add(tbl);
                NewControl.Style.Add("float", "left");
                NewControl.Style.Add("width", "33%");
                NewControl.Attributes.Add("align", "center");
                NewControl.Style.Add("text-align", "center");
                NewControl.Attributes["class"] = "interns col-4";
                NewControl.ID = i.ID.ToString();
                interns.Controls.Add(NewControl);

            }
        }
        else
        {
            if (Request.QueryString["Name"] != null)
            {
                var candids = context.Intern1.ToList().Where(n => n.FirstName.Contains(Request.QueryString["Name"].ToString()));
                foreach (Intern1 i in candids)
                {
                    HtmlGenericControl NewControl = new HtmlGenericControl("div");
                    NewControl.ID = i.ID.ToString();
                    HtmlTable tbl = new HtmlTable();
                    //HtmlTableRow cell1 = new HtmlTableRow();
                    //HtmlTableCell cll1 = new HtmlTableCell();
                    //cll1.InnerHtml = string.Format("<a href='/intern.aspx?id=" + i.ID + "'><img src='" + i.photo + "' width='25%' height='25%' align='center'/></a>");
                    //cell1.Cells.Add(cll1);
                    HtmlTableRow cell2 = new HtmlTableRow();
                    HtmlTableCell cll2 = new HtmlTableCell();
                    cll2.InnerHtml = string.Format("<a href='/intern.aspx?id=" + i.ID + "'>" + i.FirstName + " " + i.LastName + "</a>");
                    cell2.Cells.Add(cll2);
                    HtmlTableRow cell3 = new HtmlTableRow();
                    HtmlTableCell cll3 = new HtmlTableCell();
                    cll3.InnerHtml = i.Mobile.ToString();
                    cell3.Cells.Add(cll3);
                    HtmlTableRow cell4 = new HtmlTableRow();
                    HtmlTableCell cll4 = new HtmlTableCell();
                    cll4.InnerHtml = i.Email;
                    cell4.Cells.Add(cll4);
                    HtmlTableRow cell5 = new HtmlTableRow();
                    HtmlTableCell cll5 = new HtmlTableCell();
                    Button button2 = new Button();
                    button2.Text = "Delete";
                    button2.CssClass = i.ID.ToString();
                    button2.Click += Button2_Click;
                    button2.Attributes.Add("runat", "server");
                    //cll5.Controls.Add(button2);
                    cell5.Cells.Add(cll5);
                    //tbl.Rows.Add(cell1);
                    tbl.Rows.Add(cell2);
                    tbl.Rows.Add(cell3);
                    tbl.Rows.Add(cell4);
                    tbl.Rows.Add(cell5);
                    tbl.Style.Add("align", "center");
                    NewControl.Controls.Add(tbl);
                    NewControl.Style.Add("float", "left");
                    NewControl.Style.Add("width", "33%");
                    NewControl.Attributes.Add("align", "center");
                    NewControl.Style.Add("text-align", "center");
                    NewControl.Attributes["class"] = "interns col-4";
                    NewControl.ID = i.ID.ToString();
                    interns.Controls.Add(NewControl);

                }
                
                }
            else if (Request.QueryString["Dep"] != null)
            {
                var eds = context.Educations.ToList().Where(x => x.Deptmnt == int.Parse(Request.QueryString["Dep"].ToString()));
                
                foreach (Education ed in eds)
                {
                    Intern1 i = new Intern1();
                    var t = context.Intern1.ToList().Where(XPath => XPath.ID == ed.InternID).First();
                    i = t;
                    HtmlGenericControl NewControl = new HtmlGenericControl("div");
                    NewControl.ID = i.ID.ToString();
                    HtmlTable tbl = new HtmlTable();
                    //HtmlTableRow cell1 = new HtmlTableRow();
                    //HtmlTableCell cll1 = new HtmlTableCell();
                    //cll1.InnerHtml = string.Format("<a href='/intern.aspx?id=" + i.ID + "'><img src='" + i.photo + "' width='25%' height='25%' align='center'/></a>");
                    //cell1.Cells.Add(cll1);
                    HtmlTableRow cell2 = new HtmlTableRow();
                    HtmlTableCell cll2 = new HtmlTableCell();
                    cll2.InnerHtml = string.Format("<a href='/intern.aspx?id=" + i.ID + "'>" + i.FirstName + " " + i.LastName + "</a>");
                    cell2.Cells.Add(cll2);
                    HtmlTableRow cell3 = new HtmlTableRow();
                    HtmlTableCell cll3 = new HtmlTableCell();
                    cll3.InnerHtml = i.Mobile.ToString();
                    cell3.Cells.Add(cll3);
                    HtmlTableRow cell4 = new HtmlTableRow();
                    HtmlTableCell cll4 = new HtmlTableCell();
                    cll4.InnerHtml = i.Email;
                    cell4.Cells.Add(cll4);
                    HtmlTableRow cell5 = new HtmlTableRow();
                    HtmlTableCell cll5 = new HtmlTableCell();
                    Button button2 = new Button();
                    button2.Text = "Delete";
                    button2.CssClass = i.ID.ToString();
                    button2.Click += Button2_Click;
                    button2.Attributes.Add("runat", "server");
                    //cll5.Controls.Add(button2);
                    cell5.Cells.Add(cll5);
                    //tbl.Rows.Add(cell1);
                    tbl.Rows.Add(cell2);
                    tbl.Rows.Add(cell3);
                    tbl.Rows.Add(cell4);
                    tbl.Rows.Add(cell5);
                    tbl.Style.Add("align", "center");
                    NewControl.Controls.Add(tbl);
                    NewControl.Style.Add("float", "left");
                    NewControl.Style.Add("width", "33%");
                    NewControl.Attributes.Add("align", "center");
                    NewControl.Style.Add("text-align", "center");
                    NewControl.Attributes["class"] = "interns col-4";
                    NewControl.ID = i.ID.ToString();
                    interns.Controls.Add(NewControl);

                }
            }
            else if (Request.QueryString["End"] != null)
            {
                var eds = context.Educations.ToList().Where(x => x.EndDate == null);

                foreach (Education ed in eds)
                {
                    Intern1 i = new Intern1();
                    var t = context.Intern1.ToList().Where(XPath => XPath.ID == ed.InternID).First();
                    i = t;
                    HtmlGenericControl NewControl = new HtmlGenericControl("div");
                    NewControl.ID = i.ID.ToString();
                    HtmlTable tbl = new HtmlTable();
                    //HtmlTableRow cell1 = new HtmlTableRow();
                    //HtmlTableCell cll1 = new HtmlTableCell();
                    //cll1.InnerHtml = string.Format("<a href='/intern.aspx?id=" + i.ID + "'><img src='" + i.photo + "' width='25%' height='25%' align='center'/></a>");
                    //cell1.Cells.Add(cll1);
                    HtmlTableRow cell2 = new HtmlTableRow();
                    HtmlTableCell cll2 = new HtmlTableCell();
                    cll2.InnerHtml = string.Format("<a href='/intern.aspx?id=" + i.ID + "'>" + i.FirstName + " " + i.LastName + "</a>");
                    cell2.Cells.Add(cll2);
                    HtmlTableRow cell3 = new HtmlTableRow();
                    HtmlTableCell cll3 = new HtmlTableCell();
                    cll3.InnerHtml = i.Mobile.ToString();
                    cell3.Cells.Add(cll3);
                    HtmlTableRow cell4 = new HtmlTableRow();
                    HtmlTableCell cll4 = new HtmlTableCell();
                    cll4.InnerHtml = i.Email;
                    cell4.Cells.Add(cll4);
                    HtmlTableRow cell5 = new HtmlTableRow();
                    HtmlTableCell cll5 = new HtmlTableCell();
                    Button button2 = new Button();
                    button2.Text = "Delete";
                    button2.CssClass = i.ID.ToString();
                    button2.Click += Button2_Click;
                    button2.Attributes.Add("runat", "server");
                    //cll5.Controls.Add(button2);
                    cell5.Cells.Add(cll5);
                    //tbl.Rows.Add(cell1);
                    tbl.Rows.Add(cell2);
                    tbl.Rows.Add(cell3);
                    tbl.Rows.Add(cell4);
                    tbl.Rows.Add(cell5);
                    tbl.Style.Add("align", "center");
                    NewControl.Controls.Add(tbl);
                    NewControl.Style.Add("float", "left");
                    NewControl.Style.Add("width", "33%");
                    NewControl.Attributes.Add("align", "center");
                    NewControl.Style.Add("text-align", "center");
                    NewControl.Attributes["class"] = "interns col-4";
                    NewControl.ID = i.ID.ToString();
                    interns.Controls.Add(NewControl);

                }
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        InternshipProgramEntities context = new InternshipProgramEntities();
        Button button = (Button)sender;
        string username = button.Parent.Parent.Parent.Parent.ID;
        Intern1 c = new Intern1() { ID = int.Parse(username) };

        context.Intern1.Attach(c);
        context.Intern1.DeleteObject(c);
        context.SaveChanges();

        Response.Redirect("./Interns.aspx");

    }



    protected void save_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition", "attachment;filename=FileName.pdf");
        Response.Cache.SetCacheability(HttpCacheability.NoCache);

        StringWriter sw = new StringWriter();

        HtmlTextWriter w = new HtmlTextWriter(sw);
        interns.RenderControl(w);


        string htmWrite = sw.GetStringBuilder().ToString();
        htmWrite = Regex.Replace(htmWrite, "</?(a|A).*?>", "");
        htmWrite = htmWrite.Replace("\r\n", "");
        StringReader reader = new StringReader(htmWrite);

        Document doc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
        string pdfFilePath = Server.MapPath(".") + "/";

        HTMLWorker htmlparser = new HTMLWorker(doc);
        PdfWriter.GetInstance(doc, Response.OutputStream);

        doc.Open();
        
            doc.NewPage();
            htmlparser.Parse(reader);
            doc.Close();
            Response.Write(doc);
            Response.End();
        
        
            doc.Close();
        
    }

    protected void Go_Search_Click(object sender, EventArgs e)
    {
        Response.Redirect("Interns.aspx?Name=" + srch.Text);
    }

    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("Interns.aspx?Dep=" + ddl.SelectedValue);
    }

    protected void still_Click(object sender, EventArgs e)
    {
        Response.Redirect("Interns.aspx?End=null");
    }
}
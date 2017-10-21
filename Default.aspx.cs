using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.IO;
using System.Text;
using System.Configuration;

using System.Net;
using System.Net.Mail;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static string sendApplication(string admision_name, string admision_email, string admision_phone, string admision_message)
    {
        string main1 = "hemachandru21@gmail.com";
        var un = "website@1migrate.net";
        var pass = "Welcome123!@#";
        MailMessage msg = new MailMessage();
        msg.From = new MailAddress(un, "User Application");
        msg.To.Add(main1);
        msg.Subject = "Mail From Site : Enquiry form";
        msg.Body = "<br><br><div style='background-color: white;padding: 25px;border: 2px solid navy;margin: 25px;color:black;'><center><h1>Application</h1><br><br><table border='1' style='border-collapse: collapse;'> " +
                   "<table border='1' style='border-collapse: collapse;'><tr><td style='padding-top:10px;padding-bottem:10px;'>Applicant Name : </td><td style='padding-top:10px;padding-bottem:10px;'>" + admision_name + " </td></tr>" +
                   "<tr><td style='padding-top:10px;padding-bottem:10px;'>Applicant Email  : </td><td style='padding-top:10px;padding-bottem:10px;'>" + admision_email + "  </td></tr>" +
                   "<tr><td style='padding-top:10px;padding-bottem:10px;'>Applicant Phone  : </td><td style='padding-top:10px;padding-bottem:10px;'>" + admision_phone + "  </td></tr>" +
                   "<tr><td style='padding-top:10px;padding-bottem:10px;'>Applicant Message : </td><td style='padding-top:10px;padding-bottem:10px;'>" + admision_message + "</td></tr>" +
                   "<table></center></div><br><br><br>";
        msg.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Credentials = new NetworkCredential(un, pass);
        smtp.EnableSsl = true;
        smtp.Port = 587;
        smtp.Send(msg);
        return "true";
    }
    //send mail end


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace ProyectoTorneo
{
    public class SnippetsUtiles
    {
        private void enviarCorreo() {
            SmtpClient SmtpServer = new SmtpClient("smtp.office365.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials =
            new System.Net.NetworkCredential("jprietoc@itam.mx", "XaviarToC551.");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send("jprietoc@itam.mx", "queveduo@gmail.com", "Alguien entró al login de tu página!", "Yo!");
        }
    }
}
using System;
using System.Net.Mail;

namespace Automailer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String Date = DateTime.Today.ToString("dd.MM");
                string Content = "Subject";
                
                MailMessage msg = new MailMessage();
                
                msg.Attachments.Add(new Attachment(@"C:\..."));
                
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.Host = "smtpserver";
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("LOGINNAME", "PASSWORD");
                msg.From = new MailAddress("SENDERADDRESS", "SENDER NAME");
                msg.To.Add(new MailAddress("RECIPIENT"));
                msg.Subject = "Subject";
                msg.IsBodyHtml = true;
                msg.Body = Content;
                client.Send(msg);
            }
            
            catch (Exception e)
            {
                String Date = DateTime.Today.ToString("dd.MM");
                string Content = "Errormessage";
                MailMessage errmsg = newMailMessage();
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.Host = "smtpserver";
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("LOGINNAME", "PASSWORD");
                errmsg.From = new MailAddress("SENDERADDRESS", "SENDER NAME");
                errmsg.To.Add(new MailAddress("RECIPIENT"));
                errmsg.Subject = "Error-Subject";
                errmsg.IsBodyHtml = true;
                errmsg.Body = Content;
                client.Send(errmsg);
            }
        }
    }
}

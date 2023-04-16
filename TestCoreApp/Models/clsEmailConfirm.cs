using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace TestCoreApp.Models
{
    public class clsEmailConfirm : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fMail = "yourmail";
            var fPassword = "yourpassword";

            var theMsg = new MailMessage();
            theMsg.From = new MailAddress(fMail);
            theMsg.Subject = subject;
            theMsg.To.Add(email);
            theMsg.Body = $"<html><body>{htmlMessage}</body></html>";
            theMsg.IsBodyHtml = true;

            var smtpClint = new SmtpClient("smtp-mail.outlook.com")
            { 
               EnableSsl = true ,
               Credentials = new NetworkCredential(fMail, fPassword), 
               Port= 587
            };

            smtpClint.Send(theMsg);
        }
    }
}

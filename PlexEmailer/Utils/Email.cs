using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace PlexEmailer.Utils
{
    public static class Email
    {
        public static void SendEmail(string from, string to, string password, string subject, string body)
        {
            var fromAddress = new MailAddress(from, "Plex Weekly Update");
            var toAddress = new MailAddress(to, "Plex Users");

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, password)
            };
            
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
            {
                smtp.Send(message);
            }

        }
    }
}
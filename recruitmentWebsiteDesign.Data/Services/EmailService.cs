using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using recruitmentWebsiteDesign.Data.Models;

namespace recruitmentWebsiteDesign.Data.Services
{
    public class EmailService
    {
        public Task<bool> SendEmail(ContactDao contactDao)
        {
            try
            {
                // pull the magic strings into config file 
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(contactDao.Email));
                email.To.Add(MailboxAddress.Parse("dedric.west@ethereal.email"));
                email.Subject = contactDao.Subject;
                email.Body = new TextPart(TextFormat.Html) { Text = contactDao.Message };

                var smtp = new SmtpClient();
                // the server / host of the provider 
                //"smtp.office365.com"
                // port 
                smtp.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
                // username & password 
                smtp.Authenticate("dedric.west@ethereal.email", "EDMP53zPH6u4wAgDnv");
                smtp.Send(email);
                smtp.Disconnect(true);

                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }
    }
}

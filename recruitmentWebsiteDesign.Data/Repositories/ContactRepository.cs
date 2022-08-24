using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Security;
using recruitmentWebsiteDesign.Data.Models;
using recruitmentWebsiteDesign.Data.Services;

namespace recruitmentWebsiteDesign.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly IEmailService _emailService;
        public ContactRepository(
            IEmailService emailService
            )
        {
            _emailService = emailService; 
        }

        public Task SendContactDetails(ContactDao contactDao)
        {
            // add async await 
            // add in error handling 
            var sendEmail = _emailService.SendEmail(contactDao); 
            
            return Task.FromResult(sendEmail);
        }
    }
}

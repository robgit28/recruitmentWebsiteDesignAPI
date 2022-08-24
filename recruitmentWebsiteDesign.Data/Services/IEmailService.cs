using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using recruitmentWebsiteDesign.Data.Models;

namespace recruitmentWebsiteDesign.Data.Services
{
    public interface IEmailService
    {
        Task<bool> SendEmail(ContactDao contactDao);
    }
}

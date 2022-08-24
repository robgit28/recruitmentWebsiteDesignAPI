using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using recruitmentWebsiteDesign.Data.Models;

namespace recruitmentWebsiteDesign.Data.Repositories
{
    public interface IContactRepository
    {
        // return type? 
        Task SendContactDetails(ContactDao contactDao);
    }
}

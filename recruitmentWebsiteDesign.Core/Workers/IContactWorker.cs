using System.Threading.Tasks;
using recruitmentWebsiteDesign.Core.Models;
using recruitmentWebsiteDesign.Data.Models;

namespace recruitmentWebsiteDesign.Core.Workers
{
    public interface IContactWorker
    {
        Task SendContactDetails(ContactDao contactDao);
    }
}

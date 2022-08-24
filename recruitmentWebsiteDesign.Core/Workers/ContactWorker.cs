using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using recruitmentWebsiteDesign.Data.Models;
using recruitmentWebsiteDesign.Data.Repositories;
//using AutoMapper;

namespace recruitmentWebsiteDesign.Core.Workers
{
    public class ContactWorker : IContactWorker
    {
        private readonly IContactRepository _contactRepo;
        //private readonly IMapper _mapper;

        public ContactWorker(
            IContactRepository contactRepository 
            //IMapper mapper
            )
        {
            _contactRepo = contactRepository;
           // _mapper = mapper;
        }

        public Task SendContactDetails(ContactDao contactDao)
        {
            var result = _contactRepo.SendContactDetails(contactDao);

            return result; 
        }
    }
    
}

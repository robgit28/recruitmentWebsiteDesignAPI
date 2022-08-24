using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using recruitmentWebsiteDesign.Core.Workers;
using recruitmentWebsiteDesign.Core.Models;
using recruitmentWebsiteDesign.Data.Models; 
    
namespace recruitmentWebsiteDesign.API.Controllers
{
    [ApiController]
    [Route("api/contact")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IMapper _mapper;
        private readonly IContactWorker _contactWorker; 

        public ContactController(
            ILogger<ContactController> logger, 
            IMapper mapper, 
            IContactWorker contactWorker)
        {
            _logger = logger;
            _mapper = mapper;
            _contactWorker = contactWorker; 
        }

        [HttpPost]
        [Route("contactdetails")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostContactDetails([FromBody] ContactDto contactDto)
        {
            try
            {
                var contactDetails = _mapper.Map<ContactDao>(contactDto);

                var result = _contactWorker.SendContactDetails(contactDetails);

                // do something 
               // if (!result == null)
                if (result == null)
                {
                    _logger.LogWarning("Failed to send contact details");
                    return new StatusCodeResult(StatusCodes.Status422UnprocessableEntity);
                }

                _logger.LogInformation("Contact details successfully sent");
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    };
}
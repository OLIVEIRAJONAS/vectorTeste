using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VectorTest.API.Models;
using VectorTest.API.Services;
using VectorTest.API.Services.InterfaceServices;

namespace VectorTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly IEmailService _emailsService;

        public EmailsController(IEmailService emailService)
        {
            _emailsService = emailService;
        }

        //busca lista de emails
        [HttpGet]
       
        [Authorize]
        public async Task<ActionResult<IEnumerable<Email>>> Get()
        {
            return  new ObjectResult( await _emailsService.GetAll());

        }

        //busca email por id

        [HttpGet("{id}", Name = "GetEmail")]
      
        [Authorize]
        public async Task<ActionResult<Email>> GetById(int id)
        {

            return new ObjectResult(await _emailsService.GetId(id));
                   
        }


       

    }
}

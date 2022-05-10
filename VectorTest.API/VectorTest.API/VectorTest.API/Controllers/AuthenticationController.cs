using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using VectorTest.API.Models;
using VectorTest.API.Repository;
using VectorTest.API.Services;
using VectorTest.API.Services.InterfaceServices;

namespace VectorTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private IUserService _userService;
        public AuthenticationController(ITokenService tokenService, IUserService userService)
        {
            _tokenService = tokenService;
            _userService = userService; 
        }

        //realiza login
        [HttpPost, Route("login")]
        public IActionResult Login([FromBody]  Users user)
        {
            var tokenString = _tokenService.GenerateToken(user.Username, user.Password);


            if (tokenString == null)
            {
                return BadRequest("Request do cliente inválido");
            }

            else
            {
                return Ok(new { Token = tokenString });
            }

        }

        //cadastrar usuario

        [HttpPost, Route("CadastrarUser")]
        public IActionResult User([FromBody] Users user)
        {
             var usuario = _userService.CreateUser(user);
               
              return Ok(new { User = usuario });
            

        }
    }


}



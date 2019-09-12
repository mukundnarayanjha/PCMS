using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PettyCash.API.Data.Interface;

namespace PettyCash.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration config;
        private IAuthenticationUser service;
        public AuthController(IConfiguration _config, IAuthenticationUser _service)
        {           
            config = _config;
            service = _service;
        }
        #region "Validate And Generate JWT For User"
        [AllowAnonymous]
        [HttpGet("{email}/{password}", Name = "AuthenticateUsers")]
        public async Task<IActionResult> Login([FromRoute] string email, [FromRoute]string password)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Cannot create token");
            }
            var result = await service.GetAuthenticatedUserAsync(email, password);
            if (result == null)
            {
                return Unauthorized();
            }
            var claims = new[]
           {
                new Claim(JwtRegisteredClaimNames.Email, email),
                new Claim(JwtRegisteredClaimNames.Sub,  "suject"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            //shared key between the token server and the resource server
            var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("condimentumvestibulumSuspendissesitametpulvinarorcicondimentummollisjusto"));
            var credentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);

            var SecurityToken = new JwtSecurityToken(
                issuer: config["AuthSection:JWtConfig:Issuer"],
                audience: config["AuthSection:JWtConfig:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(SecurityToken),
                expiration = SecurityToken.ValidTo
            });

        }

        #endregion
    }
}
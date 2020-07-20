using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using StudentModels;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IConfiguration _config;

        public LoginController(IConfiguration config)
        {
            _config = config;
        }
        [HttpPost("")]
        public IActionResult Login([FromBody] UserView userView)
        {
            string token = string.Empty;
            if (userView.Email == "tucson@tucson.com" && userView.Password == "1234")
            {
                var claims = new[] { new Claim(JwtRegisteredClaimNames.Email, userView.Email), };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var secureToken = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(double.Parse(_config["Jwt:ExpireTime"])),
                signingCredentials: creds);
                return Json(new JwtSecurityTokenHandler().WriteToken(secureToken));
            }
            return Unauthorized(userView);

        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TechnicalTestDotNet.Core.Interfaces;
using TechnicalTestDotNet.Core.Models;

namespace TechnicalTestDotNet.Core.Helpers.Token
{
    public class TokenService : ITokenService
    {

        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public UserToken BuildToken(User user)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:SecretKey"]));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                new Claim(ClaimTypes.Name, user.FullName),
                new Claim("User", user.UserName),
            };            

            var tiempoExpiracion = DateTime.Now.AddMinutes(double.Parse(_configuration["Authentication:TiempoExpiracion"])); // 480

            var token = new JwtSecurityTokenHandler().CreateJwtSecurityToken(
                issuer: _configuration["Authentication:Issuer"],
                audience: _configuration["Authentication:Audience"],
                subject: new ClaimsIdentity(claims),
                notBefore: DateTime.Now,
                expires: tiempoExpiracion,
                issuedAt: null,
                signingCredentials: signingCredentials
                );

            return new UserToken()
            {
                ExpirationToken = tiempoExpiracion,
                Token = new JwtSecurityTokenHandler().WriteToken(token)
            };
        }
    }
}

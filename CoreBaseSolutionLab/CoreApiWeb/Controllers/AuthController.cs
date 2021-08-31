using CoreApiWeb.Configuration;
using CoreApiWeb.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uibasoft.BaseLab.Services;

namespace CoreApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ITokenHandlerService _service;
        public AuthController(UserManager<IdentityUser> userManager, ITokenHandlerService service)
        {
            _userManager = userManager;
            _service = service;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserParamDto user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.Email);
                if (existingUser != null)
                {
                    return BadRequest("El correo electronico indicado ya existe.");
                }

                var isCreated = await _userManager.CreateAsync(new IdentityUser()
                {
                    Email = user.Email,
                    UserName = user.Email,
                }, user.Password);

                if (isCreated.Succeeded)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest(isCreated.Errors.Select(ele => ele.Description).ToList());
                }
            }
            else
            {
                return BadRequest("Se produjo algun error al registrar el usuario");
            }

        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginParamDto user)
        {
            //Usuario: uialberto
            //Email: uialberto@gmail.com
            //Pws: Abc123*

            if (ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.Email);
                if (existingUser == null)
                {
                    return BadRequest(new UserLoginResponseDto()
                    {
                        Login = false,
                        Errors = new List<string>()
                        {
                            "Usuario o contraseña incorrecta."
                        }
                    });
                }

                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.Password);

                if (isCorrect)
                {
                    var param = new TokenParameters()
                    {
                        Id = existingUser.Id,
                        PasswordHash = existingUser.PasswordHash,
                        UserName = existingUser.UserName
                    };

                    var jwtToken = _service.GenerateJwtToken(param);

                    return Ok(new UserLoginResponseDto()
                    {
                        Login = true,
                        Token = jwtToken
                    });

                }
                else
                {
                    return BadRequest(new UserLoginResponseDto()
                    {
                        Login = false,
                        Errors = new List<string>()
                        {
                            "Usuario o contraseña incorrecta."
                        }
                    });
                }
            }
            else
            {

                return BadRequest(new UserLoginResponseDto()
                {
                    Login = false,
                    Errors = new List<string>()
                        {
                            "Usuario o contraseña incorrecta."
                        }
                });

            }
        }

    }
}

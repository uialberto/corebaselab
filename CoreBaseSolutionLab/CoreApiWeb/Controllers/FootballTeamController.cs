using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uibasoft.BaseLab.Application;
using Uibasoft.BaseLab.Dominio;

namespace CoreApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballTeamController : ControllerBase
    {
        IApplication<FootbalTeam> _football;
        public FootballTeamController(IApplication<FootbalTeam> pFootball)
        {
            _football = pFootball;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new FootbalTeam()
            {
                Name = "Oriente Petrolero",
                Score = 100
            });
        }

    }
}

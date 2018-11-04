using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using game_logic.models;

namespace site.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {
       [HttpGet("[action]")]
       public IActionResult NewGame()
       {
           var game = new Game();
           return Ok(game);
       }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using game_logic.models;

namespace site.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controllers
    {
       [HttpGet("[action]")]
       public IAsyncResult NewGame()
       {
           var game = new Game();
           return Ok(game);
       }
    }
}
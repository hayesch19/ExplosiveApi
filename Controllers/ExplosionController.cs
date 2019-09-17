using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace explosiveapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class ExplosionController : ControllerBase
  {
    [HttpGet("{s}")]
    public ActionResult<string> Explosion(string number)
    {
      return string.Join("", number.Select(c => new String(c, int.Parse(c.ToString()))));
    }
  }
}
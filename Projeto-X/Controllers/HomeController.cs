using Microsoft.AspNetCore.Mvc;
using Projeto_X.Data;
using Projeto_X.Models;

namespace Projeto_X.Controllers
{
    [ApiController]
    [Route("/ChallengeBack-end/[Controller]")]
    public class HomeController : Controller
    {
        private DBModel _dbContext;
        public HomeController(DBModel context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult getVideos() {
            IEnumerable<Videos> videos = _dbContext.Videos.Take(50).ToList();
            return Ok(videos);
        }

        [HttpPost]
        public IActionResult postVideos([FromBody] string titulo, [FromBody] string descricao, ) { }


    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizApp.Server.Models;
using QuizApp.Server.Services;

namespace QuizApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizController : Controller
    {
        private readonly QuizService _service;

        public QuizController (QuizService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<IEnumerable<Question>> HacerCuestionario()
        {
            return _service.HacerCuestionario();
        }
    }
}

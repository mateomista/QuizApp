using Microsoft.EntityFrameworkCore;
using QuizApp.Server.Data;
using QuizApp.Server.Models;

namespace QuizApp.Server.Services
{
    public class QuizService
    {
        private readonly QuizDbContext _context;

        public QuizService (QuizDbContext context) { 
            _context = context;
        }

        public async Task<IEnumerable<Question>> HacerCuestionario()
        {
            int count = 10;

            var questions = await _context.Questions
                                          .OrderBy(r => Guid.NewGuid()) // Ordenar aleatoriamente
                                          .Take(count) // Obtener el número de preguntas deseado
                                          .ToListAsync();
            return questions;
        }
    }
}

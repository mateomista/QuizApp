namespace QuizApp.Server.Models
{
    public class Quiz
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
        public int Score { get; set; }

        public Quiz(int id, string name, List<Question> questions, int score)
        {
            Id = id;
            Name = name;
            Questions = questions;
            Score = 0;
        }


    }
}

namespace QuizApp.Server.Models
{
    public class Question
    {
        public int Id { get; set; }  // Identificador único de la pregunta
        public string Text { get; set; }  // El texto de la pregunta
        public string Option1 { get; set; }  // Primera opción
        public string Option2 { get; set; }  // Segunda opción
        public string Option3 { get; set; }  // Tercera opción
        public string Option4 { get; set; }  // Cuarta opción
        public int CorrectOption { get; set; }  // Opción correcta 

        public Question(int id, string text, string option1, string option2, string option3, string option4, int correctOption)
        {
            Id = id;
            Text = text;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            Option4 = option4;
            CorrectOption = correctOption;
        }

        public bool IsCorrect(int opcionElegida)
        {
            if (CorrectOption == opcionElegida) return true; return false;
        }
    }
}

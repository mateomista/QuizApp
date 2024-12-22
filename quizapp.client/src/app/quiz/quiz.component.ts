import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Question, QuizService } from './quiz.service'; 
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css'],
})
export class QuizComponent implements OnInit {
  questions: Question[] = [];
  selectedAnswers: number[] = []; // Almacena las respuestas seleccionadas por índice de pregunta
  score: number | null = null; // Puntaje del usuario
  incorrectAnswers: { question: Question; userAnswer: string }[] = []; // Respuestas incorrectas

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getQuestions();
  }

  getQuestions(): void {
    this.http.get<Question[]>('https://localhost:7120/Quiz').subscribe(
      (data) => {
        this.questions = data;
        this.selectedAnswers = Array(this.questions.length).fill(0);
      },
      (error) => console.error('Error al cargar las preguntas', error)
    );
  }

  getOptions(question: Question): string[] {
    return [question.option1, question.option2, question.option3, question.option4];
  }

  getCorrectOption(question: Question): string {
    const options = this.getOptions(question);
    return options[question.correctOption - 1];
  }

  finalizeQuiz(): void {
    this.score = 0;
    this.incorrectAnswers = [];

    this.questions.forEach((question, index) => {
      if (this.selectedAnswers[index] === question.correctOption) {
        this.score!++;
      } else {
        this.incorrectAnswers.push({
          question,
          userAnswer: this.getOptions(question)[this.selectedAnswers[index] - 1] || 'Ninguna',
        });
      }
    });
  }
}






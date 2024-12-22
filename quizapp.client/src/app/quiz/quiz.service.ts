import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Question {
  id: number;             // Identificador único de la pregunta
  text: string;           // El texto de la pregunta
  option1: string;        // Primera opción
  option2: string;        // Segunda opción
  option3: string;        // Tercera opción
  option4: string;        // Cuarta opción
  correctOption: number;  // Opción correcta
}


@Injectable({
  providedIn: 'root'
})
export class QuizService {

  private apiUrl = 'https://localhost:7120/Quiz'; // URL de tu API

  constructor(private http: HttpClient) { }

  
  getQuestions(): Observable<Question[]> {
    return this.http.get<Question[]>(this.apiUrl);
  }
}

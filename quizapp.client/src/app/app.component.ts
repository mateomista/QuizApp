import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { QuizComponent } from './quiz/quiz.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'quizapp.client';

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }
}

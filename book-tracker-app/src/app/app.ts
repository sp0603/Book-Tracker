import { Component} from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { BooksComponent } from './books/book-info';


@Component({
  selector: 'app-root',
  imports: [RouterOutlet, BooksComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
}
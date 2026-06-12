import { Component} from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { BooksComponent } from './books/book-info';
import { AddButtonComponent } from './buttons/add-button/add-button';


@Component({
  selector: 'app-root',
  imports: [RouterOutlet, BooksComponent, AddButtonComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
}
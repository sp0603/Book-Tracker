import { Component, OnInit } from "@angular/core";
import { BookService } from "../services/book";
import { Book, BookStatus } from "../models/book";
import { DropDownComponent } from "../buttons/drop-down/drop-down";

@Component({
  selector: 'app-books',
  imports: [DropDownComponent],
  templateUrl: './book-info.html',
  styleUrl: './book-info.css'
})


export class BooksComponent implements OnInit {

  BookStatus = BookStatus

  statusDisplay: Record<string, string> = {
    WantToRead: "Want to Read",
    Reading: "Reading",
    Completed: "Completed",
    DidNotFinish: "Did Not Finish"
  };

  books: Book[] = [];

  constructor(private bookService: BookService) {}

  ngOnInit(): void {
    this.loadBooks();
  }

  loadBooks() {
    this.bookService.getBooks().subscribe(data => {
      this.books = data;
    });
  }

  onStatusChanged(event: {id: number, status: BookStatus}) {

    const book = this.books.find(b => b.id === event.id);

    if (book) {
      book.status = event.status;
    }
  }
}
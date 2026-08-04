import { Component, OnInit } from "@angular/core";
import { BookService } from "../services/book";
import { Book, BookStatus } from "../models/book";
import { DropDownComponent } from "../buttons/drop-down/drop-down";
import { AddButtonComponent } from "../buttons/add-button/add-button";
import { DeleteButtonComponent } from "../buttons/delete-button/delete-button";
@Component({
  selector: 'app-books',
  imports: [DropDownComponent, AddButtonComponent, DeleteButtonComponent],
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

  // so the books will load immediatley
  ngOnInit(): void {
    this.loadBooks();
  }

  loadBooks() {
    this.bookService.getBooks().subscribe(data => {
      this.books = data;
    });
  }
  
  onStatusChanged(event: {id: number, status: BookStatus}) {

    // this goes through the books list matching id to book and event in drop down
    const book = this.books.find(b => b.id === event.id);

    // If the book is found, then that is when the status will be updated
    if (book) {
      book.status = event.status;
    }
  }

  //
  newBookAdded(book: Book){
    // this appends the new book to the already existing list of books
    this.books = this.books.concat(book);
  }

  onBookDeleted(id: number){
    // this is removing the book. Where the id isn't equal it will return the others id that don't match
    this.books = this.books.filter(book => book.id !== id);
  }


  
}
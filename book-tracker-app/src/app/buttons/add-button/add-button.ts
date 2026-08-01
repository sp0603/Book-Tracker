import { Component } from "@angular/core";
import { BookService } from "../../services/book";
import { FormsModule } from '@angular/forms';
import { Book, BookStatus } from "../../models/book";
import { Output, EventEmitter} from "@angular/core";
import { DeleteButtonComponent } from "../delete-button/delete-button";

@ Component({
    selector: 'add-book-button',
    imports: [FormsModule],
    standalone: true,
    templateUrl: './add-button.html',
    styleUrl: './add-button.css'
})

export class AddButtonComponent{

    showPopUp(id: string): void {
        const element = document.getElementById(id);
        if (element) {
            element.style.display = 'block';
        }
    }

    hidePopUp(id: string): void {
        const element = document.getElementById(id);
        if (element) {
            element.style.display = 'none';
        }
    }

    // this is so that the parent changes and the new book is displayed without reloading
    // page

    @Output() newBookAdded = new EventEmitter<Book>();

    BookStatus = BookStatus;
    
    // no id because posting will generate the id.
    newBook = {
        title: '',
        author: '',
        status: BookStatus.WantToRead
    };

    // accessing the API call

    constructor (private bookService: BookService) {}

    addBook() {
        //accessing the service
        // try using signals for connection to the form
        this.bookService.addBook(this.newBook).subscribe((createdBook: Book) => {
            this.newBookAdded.emit(createdBook);

            this.newBook = {
                title: '',
                author: '',
                status: BookStatus.WantToRead
            };

            this.hidePopUp('popup')
        });
    }
}
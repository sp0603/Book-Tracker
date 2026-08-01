import { Component } from "@angular/core";
import { Output, EventEmitter, Input} from "@angular/core";
import { Book } from "../../models/book";
import { BookService } from "../../services/book";

@Component({
    selector: 'delete-button',
    imports:[],
    standalone: true,
    templateUrl: './delete-button.html',
    styleUrl: './delete-button.css'
})

export class DeleteButtonComponent{

    @Input() book!: Book;
    // just need the id to remove the book
    @Output() bookDeleted = new EventEmitter<number>();

    constructor (private bookService: BookService){}

    deleteBook(id: number) {
        this.bookService.deleteBook(id).subscribe(() =>{
            this.bookDeleted.emit(id);
        });
    };
}
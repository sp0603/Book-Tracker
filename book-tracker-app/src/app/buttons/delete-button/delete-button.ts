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
    // Will always be non-null
    @Input() book!: Book;
    
    @Output() bookDeleted = new EventEmitter<number>();

    constructor (private bookService: BookService){}

    // just need the id to remove the book
    deleteBook(id: number) {
        this.bookService.deleteBook(id).subscribe(() =>{
            this.bookDeleted.emit(id);
        });
    };
}
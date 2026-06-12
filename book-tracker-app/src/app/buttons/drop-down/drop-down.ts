import { Component, Input, Output, EventEmitter} from "@angular/core";
import { BookService } from "../../services/book";
import { Book } from "../../models/book";
import { BookStatus } from "../../models/book";

@Component({
    selector: 'drop-drown-status',
    imports: [],
    templateUrl: './drop-down.html',
    styleUrl: './drop-down.html'
})

export class DropDownComponent{
    @Input() book!: Book;
    @Output() statusChanged = new EventEmitter<{ id: number, status: BookStatus }>();

    constructor(private bookService: BookService) {}

    updateStatus(book: Book, newStatus: string) {

        const status = newStatus as BookStatus;

        this.bookService.updateStatus(book.id, status)
            .subscribe(() => {

            this.statusChanged.emit({
                id: book.id,
                status: status
            });
        });
    }
}
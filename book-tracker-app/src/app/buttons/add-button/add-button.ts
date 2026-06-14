import { Component } from "@angular/core";

@ Component({
    selector: 'add-book-button',
    imports: [],
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
}
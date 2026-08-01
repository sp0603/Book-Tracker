import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Book } from '../models/book';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  private apiUrl = 'http://localhost:5126/api/books';

  constructor(private http: HttpClient) {}

  getBooks(): Observable<Book[]> {
    return this.http.get<Book[]>(this.apiUrl);
  }

  updateStatus(id: number, status: string): Observable<Book> {
    return this.http.put<Book>(
      `${this.apiUrl}/updatestatus?id=${id}&status=${status}`,
      {}
    );
  }

  // Omitting the id because post generates it for us
  addBook(book: Omit<Book, 'id'>): Observable<Book> {
    return this.http.post<Book>(`${this.apiUrl}/`, book);
  }

  deleteBook(id: number): Observable<Book> {
    return this.http.delete<Book>(
      `${this.apiUrl}/deletebook?id=${id}`,
      {}
    );
  }
}
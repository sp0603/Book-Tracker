export enum BookStatus {
    WantToRead = "WantToRead",
    Reading = "Reading",
    Completed = "Completed",
    DidNotFinish = "DidNotFinish"
}


export interface Book {
 id: number,
 title: string;
 author: string;
 status: BookStatus; 
}
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from  '@angular/common/http';
import { AddUserModel } from './models/add-user.model';
import { observable, Observable, of } from '../../node_modules/rxjs';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
base_url="http://localhost:51418";
httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};
  constructor(private  httpClient:  HttpClient) { }
  getUsers():Observable<AddUserModel[]>{
    return  this.httpClient.get<AddUserModel[]>(`${this.base_url}/Project/GetUsers`);
}

addUser (addUserModel:AddUserModel): Observable<boolean> {
  
  return this.httpClient.post<boolean>(`${this.base_url}/Project/AddUser`,JSON.stringify(addUserModel), this.httpOptions).pipe(
    tap((isAdded: boolean) => console.log(`added user : ${isAdded}`)),
    catchError(this.handleError<boolean>('addUser'))
  );
}

/**
 * Handle Http operation that failed.
 * Let the app continue.
 * @param operation - name of the operation that failed
 * @param result - optional value to return as the observable result
 */
private handleError<T> (operation = 'operation', result?: T) {
  return (error: any): Observable<T> => {

    // TODO: send the error to remote logging infrastructure
    console.error(error); // log to console instead

    // TODO: better job of transforming error for user consumption
    console.log(`${operation} failed: ${error.message}`);

    // Let the app keep running by returning an empty result.
    return of(result as T);
  };
}

}

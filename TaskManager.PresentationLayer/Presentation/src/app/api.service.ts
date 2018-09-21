import { Injectable } from '@angular/core';
import { HttpClient} from  '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
base_url="http://localhost:55602/api"
  constructor(private  httpClient:  HttpClient) { }
  getContacts(){
    return  this.httpClient.get(`${this.base_url}/Project`);
}



}

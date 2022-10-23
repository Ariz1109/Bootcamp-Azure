import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {environment} from "../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class ProductoxtiendaService {

  constructor(private httpClient:HttpClient) {

  }

  getAll():Observable<any>{
    return this.httpClient.get(`https://localhost:7267/api/productoxtienda`)
  }
  update(productoxtienda:any):Observable<any>{
    return this.httpClient.put(`https://localhost:7267/api/productoxtienda`,productoxtienda)
  }
  create(productoxtienda:any):Observable<any>{
    return this.httpClient.post(`https://localhost:7267/api/productoxtienda`,productoxtienda)
  }

}

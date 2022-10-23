import { Injectable } from '@angular/core';
import {Observable} from "rxjs";
import * as url from "url";
import {HttpClient} from "@angular/common/http";
import {environment} from "../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class ProductoService {

  constructor(private httpClient:HttpClient) {

  }

  getAll():Observable<any>{
    return this.httpClient.get(`https://localhost:7267/api/producto`)
  }

  update(producto:any):Observable<any>{
    return this.httpClient.put(`https://localhost:7267/api/producto`,producto)
  }

  create(producto:any):Observable<any>{
    return this.httpClient.post(`https://localhost:7267/api/producto`,producto)
  }

  delete(idProducto:any):Observable<any>{
    return this.httpClient.delete(`https://localhost:7267/api/producto/`,)
  }
}

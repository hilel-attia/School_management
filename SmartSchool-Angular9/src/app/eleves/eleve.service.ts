import { Eleve } from './../models/eleve';
import { environment } from './../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient  } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class EleveService {

  baseUrl = `${environment.mainUrlAPI}eleve`;

 constructor(private http: HttpClient) { }

getAll():Observable<Eleve[]>{
  return this.http.get<Eleve[]>(`${this.baseUrl}`);
}

getById(id :number):Observable<Eleve>{
  return this.http.get<Eleve>(`${this.baseUrl}/${id}`);
}

post(eleve:Eleve){
  return this.http.post(`${this.baseUrl}`,eleve);
}
put( eleve:Eleve){
  return this.http.put(`${this.baseUrl}/${eleve.id}`,eleve);
}
delete(id :number):Observable<Eleve>{
  return this.http.delete<Eleve>(`${this.baseUrl}/${id}`);
}
}

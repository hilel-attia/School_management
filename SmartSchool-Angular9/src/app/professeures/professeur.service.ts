import { Professeur } from './../models/professeur';

import { environment } from '../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient  } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ProfesseurService {

  baseUrl = `${environment.mainUrlAPI}professeur`;

 constructor(private http: HttpClient) { }

getAll():Observable<Professeur[]>{
  return this.http.get<Professeur[]>(`${this.baseUrl}`);
}

getById(id :number):Observable<Professeur>{
  return this.http.get<Professeur>(`${this.baseUrl}/${id}`);
}

post(professeur:Professeur){
  return this.http.post(`${this.baseUrl}`,professeur);
}
put( professeur:Professeur){
  return this.http.put(`${this.baseUrl}/${professeur.id}`,professeur);
}
delete(id :number):Observable<Professeur>{
  return this.http.delete<Professeur>(`${this.baseUrl}/${id}`);
}
}

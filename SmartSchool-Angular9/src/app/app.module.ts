import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ProfilComponent } from './profil/profil.component';
import { ProfesseuresComponent } from './professeures/professeures.component';
import { ElevesComponent } from './eleves/eleves.component';
import { NavComponent } from './nav/nav.component';
import { TitreComponent } from './titre/titre.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';
import{HttpClientModule} from '@angular/common/http';


@NgModule({
  declarations: [		
    AppComponent,
    DashboardComponent,
    ProfilComponent,
    ProfesseuresComponent,
    ElevesComponent,
      NavComponent,
      TitreComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    BsDropdownModule.forRoot(),
    FormsModule,
    ReactiveFormsModule,
    ModalModule.forRoot(),
    HttpClientModule
    
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

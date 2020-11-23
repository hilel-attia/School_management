import { ProfilComponent } from './profil/profil.component';
import { ProfesseuresComponent } from './professeures/professeures.component';
import { ElevesComponent } from './eleves/eleves.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {path:'', redirectTo: 'dashboard' , pathMatch:'full' },
  {path:'dashboard', component: DashboardComponent },
  {path:'professeures', component: ProfesseuresComponent },
  {path:'eleves', component: ElevesComponent },
  {path:'profil', component: ProfilComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

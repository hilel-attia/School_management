import { Professeur } from './../models/professeur';
import { ProfesseurService } from './professeur.service';

import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-professeures',
  templateUrl: './professeures.component.html',
  styleUrls: ['./professeures.component.css']
})
export class ProfesseuresComponent implements OnInit {

public titre = "Professeures";
public profSelected: Professeur;
public modalRef: BsModalRef;
public professeurForm: FormGroup;
public mode = 'post';

 public  professeures : Professeur[];
 constructor(private modalService: BsModalService,
             private professeurService :ProfesseurService,
             private fb : FormBuilder ) {

              this.createForm();
             }


  ngOnInit(): void {
    this.chargerProfesseurs();
  }

  chargerProfesseurs(){
    this.professeurService.getAll().subscribe(
      (professeures :Professeur[ ])=>{
        this.professeures = professeures;
       //console.log('ress',this.professeures);

      },
      (error :any)=>
      {
        console.log(error,'errrrrrrrroor');
      }


    );
  }

createForm(){
  this.professeurForm = this.fb.group({
    id: [''],
    nom: ['',Validators.required]
    // dicipilne: ['',Validators.required],

  });
}
saveProfesseur(professeur :Professeur){

  (professeur.id === 0) ? this.mode = 'post' : this.mode = 'put';
  this.professeurService[this.mode](professeur).subscribe(
    (res: Professeur)=>{
      console.log('res :', res);
      this.chargerProfesseurs();
    },
    (error :any) => {
      console.log(error);

    }



  );

}

professeurSubmit(){
  this.saveProfesseur(this.professeurForm.value);
  console.log(this.professeurForm.value);
}
//  profSelect(Professeure:Professeur){
//   this.profSelected= Professeure;
//   }
  Retour(){
    this.profSelected = null;
  }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  profSelect(professeur: Professeur){
    this.profSelected= professeur;
    this.professeurForm.patchValue(professeur);
  }
  nouveauProfesseur(){
    this.profSelected= new Professeur();
    this.professeurForm.patchValue(this.profSelected)
  }





}

// eleveSubmit(){
//   this.saveEleve(this.eleveForm.value);
 // console.log(this.eleveForm.value);

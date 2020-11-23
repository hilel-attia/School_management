import { EleveService } from './eleve.service';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Eleve } from '../models/eleve';


@Component({
  selector: 'app-eleves',
  templateUrl: './eleves.component.html',
  styleUrls: ['./eleves.component.css']
})
export class ElevesComponent implements OnInit {

public titre = "Eleves";
public modalRef: BsModalRef;
public eleveSlected: Eleve;

public textSimple:string;
public eleveForm :FormGroup;
public eleves : Eleve[];
public mode = 'post';

openModal(template: TemplateRef<any>) {
  this.modalRef = this.modalService.show(template);
}
constructor(private fb: FormBuilder,
            private modalService: BsModalService,
            private eleveService :EleveService) {
  this.createForm();
}

ngOnInit() {
  this.chargerEleve();
}

chargerEleve(){
 this.eleveService.getAll().subscribe(
   (eleves: Eleve[ ])=>{

     this.eleves = eleves;

  },
   (error :any)=>{
     console.log(error,'erroooooor');

   }
   );
}



createForm(){
  this.eleveForm = this.fb.group({
    id: [''],
    nom: ['',Validators.required],
    prenom: ['',Validators.required],
    telephone:['',Validators.required]
  });
}

saveEleve(eleve :Eleve){
    (eleve.id === 0) ? this.mode = 'post' : this.mode = 'put';
      this.eleveService[this.mode](eleve).subscribe(
      (res: Eleve)=>{
        console.log(res);
        this.chargerEleve();
      },
      (error :any) => {
        console.log(error);

      }
    );
}

eleveSubmit(){
  this.saveEleve(this.eleveForm.value);
 // console.log(this.eleveForm.value);

}

eleveSelect(eleve: Eleve){
this.eleveSlected= eleve;
this.eleveForm.patchValue(eleve);
}
nouveauEleve(){
  this.eleveSlected= new Eleve();
  this.eleveForm.patchValue(this.eleveSlected);
  }
Retour(){
  this.eleveSlected = null;
}
EffacerEleve(id :number){
  this.eleveService.delete(id).subscribe(
    (res:any)=>{
      console.log('res :',res);
      this.chargerEleve();

    },
    (error :any)=>{
      console.error('error',error);

    }
  );

}




}

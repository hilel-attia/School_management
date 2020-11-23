import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfesseuresComponent } from './professeures.component';

describe('ProfesseuresComponent', () => {
  let component: ProfesseuresComponent;
  let fixture: ComponentFixture<ProfesseuresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProfesseuresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProfesseuresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

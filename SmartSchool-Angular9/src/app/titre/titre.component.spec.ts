/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { TitreComponent } from './titre.component';

describe('TitreComponent', () => {
  let component: TitreComponent;
  let fixture: ComponentFixture<TitreComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TitreComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TitreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

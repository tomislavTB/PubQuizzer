import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChampionFormComponent } from './champion-form.component';

describe('ChampionFormComponent', () => {
  let component: ChampionFormComponent;
  let fixture: ComponentFixture<ChampionFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChampionFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChampionFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

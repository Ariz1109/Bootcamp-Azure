import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProductoxtiendaRoutingModule } from './productoxtienda-routing.module';
import { ListComponent } from './components/list/list.component';
import {MatTableModule} from "@angular/material/table";
import {MatButtonModule} from "@angular/material/button";
import {MatIconModule} from "@angular/material/icon";
import {HttpClientModule} from "@angular/common/http";
import {MatCardModule} from "@angular/material/card";
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatInputModule} from "@angular/material/input";
import {ReactiveFormsModule} from "@angular/forms";



@NgModule({
  declarations: [
    ListComponent
  ],
  imports: [
    CommonModule,
    ProductoxtiendaRoutingModule,
    MatTableModule,
    MatButtonModule,
    MatIconModule,
    HttpClientModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    ReactiveFormsModule
  ]
})
export class ProductoxtiendaModule { }

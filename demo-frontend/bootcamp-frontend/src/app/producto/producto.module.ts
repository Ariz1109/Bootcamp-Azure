import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProductoRoutingModule } from './producto-routing.module';
import { ListComponent } from './components/list/list.component';
import {MatTableModule} from "@angular/material/table";
import {MatButton, MatButtonModule} from "@angular/material/button";
import {MatIconModule} from "@angular/material/icon";
import {HttpClientModule} from "@angular/common/http";
import { CreateComponent } from './components/create/create.component';
import {MatCardModule} from "@angular/material/card";
import {MatFormField, MatFormFieldModule} from "@angular/material/form-field";
import {MatInputModule} from "@angular/material/input";
import {ReactiveFormsModule} from "@angular/forms";


@NgModule({
  declarations: [
    ListComponent,
    CreateComponent
  ],
  imports: [
    CommonModule,
    ProductoRoutingModule,
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
export class ProductoModule { }

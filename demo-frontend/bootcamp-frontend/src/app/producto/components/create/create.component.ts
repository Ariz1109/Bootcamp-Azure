import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {ProductoService} from "../../../services/producto.service";
import {ActivatedRoute, Router} from "@angular/router";

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {

  formProducto:FormGroup;

  constructor(
    private formBuilder:FormBuilder,
    private productoService:ProductoService,
    private router:Router,
    private activatedRoute:ActivatedRoute
  ) {
    this.formProducto = formBuilder.group({
      name:[{value:null,disabled:false},[Validators.required]],
      description:[{value:null,disabled:false},[Validators.required]],
      categoriaId:[{value:null,disabled:false},[Validators.required]],
      marcaId:[{value:null,disabled:false},[Validators.required]]
    })

  }

  ngOnInit(): void {

  }

  guardar():void{
    const producto = this.formProducto.getRawValue();
    this.productoService.create(producto).subscribe(x=>{
      alert('se crea correctamente');
      this.back();
    })
  }
  back():void{
    this.router.navigate(['..'], {
      relativeTo: this.activatedRoute
    })
  }
  cancelar():void{
    this.back();
  }
}

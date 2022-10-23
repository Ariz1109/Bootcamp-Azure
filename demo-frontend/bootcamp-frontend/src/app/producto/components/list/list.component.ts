import { Component, OnInit } from '@angular/core';
import {ProductoService} from "../../../services/producto.service";
import {MatTableDataSource} from "@angular/material/table";
import {ActivatedRoute, Router} from "@angular/router";

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  displayedColumns:string[]=['id','nombre','categoria','descripcion','marca','actions'];
  productoDataSource:MatTableDataSource<any>= new MatTableDataSource<any>();


  constructor(
    private productoService: ProductoService,
    private router:Router,
    private activateRoute:ActivatedRoute
  ) {
  }

  ngOnInit(): void {
    this.getProducto();
  }
  getProducto():void {
    this.productoService.getAll().subscribe(listProducto=>{
      this.productoDataSource.data = listProducto;
    })
  }
  editarProducto(producto:any):void{
    alert(`Editando producto: `+ producto.nombre)
  }

  eliminarProducto(producto:any):void{
    alert(`Eliminando producto: `+ producto.nombre)
  }

  agregarProducto():void{
    this.router.navigate(['./create'], {
      relativeTo: this.activateRoute
    })
  }
}

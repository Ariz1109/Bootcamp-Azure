import { Component, OnInit } from '@angular/core';
import {ProductoService} from "../../../services/producto.service";
import {ActivatedRoute, Router} from "@angular/router";
import {MatTableDataSource} from "@angular/material/table";
import {ProductoxtiendaService} from "../../../services/productoxtienda.service";

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  displayedColumns:string[]=['id','nombre','categoria','descripcion','marca','stock','precio','actions'];
  productoxtiendaDataSource:MatTableDataSource<any>= new MatTableDataSource<any>();

  constructor(
    private productoxtiendaService: ProductoxtiendaService,
    private router:Router,
    private activateRoute:ActivatedRoute
  ) {
  }

  ngOnInit(): void {
    this.getProductoxtienda();
  }
  getProductoxtienda():void {
    this.productoxtiendaService.getAll().subscribe(listProductoxtienda=>{
      this.productoxtiendaDataSource.data = listProductoxtienda;
    })
  }
  agregarProductoxtienda():void{
    this.router.navigate(['./create'], {
      relativeTo: this.activateRoute
    })
  }

}

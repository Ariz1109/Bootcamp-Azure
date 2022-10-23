import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {ProductoModule} from "./producto/producto.module";
import {ProductoxtiendaModule} from "./productoxtienda/productoxtienda.module";

const routes: Routes = [
  {
    path:'producto',
    loadChildren:()=>import('./producto/producto.module').then((x) => x.ProductoModule)
  },
  {
    path:'productoxtienda',
    loadChildren:()=>import('./productoxtienda/productoxtienda.module').then((x) => x.ProductoxtiendaModule)
  }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

}

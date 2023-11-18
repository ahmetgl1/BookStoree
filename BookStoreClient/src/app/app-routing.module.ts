import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LayoutsComponent } from './layouts/layouts.component';
import { ShoppingCartComponent } from './shopping-cart/shopping-cart.component';

const routes: Routes = [

{
  path: "",
  component: LayoutsComponent,
  children: [
    {
      path: "",
      component: HomeComponent
    },
    {
      path: "shopping",
      component: ShoppingCartComponent
    }
  ]
 






},





];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

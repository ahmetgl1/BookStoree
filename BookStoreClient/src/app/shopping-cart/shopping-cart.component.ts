import { Component } from '@angular/core';
import { ShoppingCartService } from '../../app/services/shopping-cart.service';
import { TranslateService } from '@ngx-translate/core';
import { PaymentModel } from '../models/payment.model';
import { Countries } from '../constants/countries';
import { Cities } from '../constants/cities';


@Component({
  selector: 'app-shopping-cart',
  templateUrl: './shopping-cart.component.html',
  styleUrls: ['./shopping-cart.component.css']
})
export class ShoppingCartComponent {

  language: string = "en"
  selectedTabs: number = 1
  request: PaymentModel = new PaymentModel()
  countries = Countries
  cities = Cities
  isSameAddress: boolean = false
  cartNumber1: string =""
  cartNumber2: string =""
  cartNumber3: string =""
  cartNumber4: string =""




  constructor(public shopping: ShoppingCartService,
    public translate: TranslateService) {



    if (localStorage.getItem('language')) {
      this.language = localStorage.getItem('language') as string

    }
    translate.setDefaultLang(this.language)

    this.shopping.totalCalc()
    this.request.books = this.shopping.shoppingCarts


  }

  changeTab(tabNumber: number) {

    this.selectedTabs = tabNumber

  }
  
  changeIsSame() {
    if (this.isSameAddress) {
      this.request.billingAddress = { ...this.request.shippingAddress };
    } 
  }
  









}


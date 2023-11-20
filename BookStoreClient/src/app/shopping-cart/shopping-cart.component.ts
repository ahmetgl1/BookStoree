import { Component } from '@angular/core';
import { ShoppingCartService } from '../../app/services/shopping-cart.service';
import { TranslateService } from '@ngx-translate/core';
import { PaymentModel } from '../models/payment.model';
import { Countries } from '../constants/countries';
import { Cities } from '../constants/cities';
import { SwalService } from '../services/swal.service';


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
  cartNumber1: string = ""
  cartNumber2: string = ""
  cartNumber3: string = ""
  cartNumber4: string = ""
  selectedCurrencyForPayment= "₺"




  constructor(public shopping: ShoppingCartService,
              public translate: TranslateService,
              private swal: SwalService) {



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


  payment() {
    this.request.paymentCard.cardNumber = this.cartNumber1 + this.cartNumber2 + this.cartNumber3 + this.cartNumber4
    this.request.buyer.registrationAddress = this.request.shippingAddress.description
    this.request.buyer.registrationAddress = this.request.shippingAddress.description
    this.request.buyer.city = this.request.shippingAddress.city
    this.request.buyer.country = this.request.shippingAddress.country

    this.shopping.payment(this.request, (res) => {
      const closeButton = document.getElementById('closeBtnPaymentModal')
      closeButton?.click()
      const remainShoppingCarts = this.shopping.shoppingCarts.filter(o => o.price.currency !== this.selectedCurrencyForPayment)
      localStorage.setItem('shoppingCarts' , JSON.stringify(remainShoppingCarts))
      

this.swal.callToast

      setTimeout(() => {
        
        location.reload()
      }, 3000);
      
      this.shopping.checkLocalStorageForShoppingCart()
      this.shopping.totalCalc()

    })
  }


  setSelectedCurrencyPayment(currency: string){

    this.selectedCurrencyForPayment =  currency
    const newBooks = this.shopping.shoppingCarts.filter(o => o.price.currency === this.selectedCurrencyForPayment)

    this.request.books = newBooks



  }









}


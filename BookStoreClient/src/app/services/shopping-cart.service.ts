import { Injectable } from '@angular/core';
import { SwalService } from './swal.service';
import { forkJoin } from 'rxjs';
import { TranslateService } from '@ngx-translate/core';
import { HttpClient } from '@angular/common/http';
import { PaymentModel } from '../models/payment.model';

@Injectable({
  providedIn: 'root'
})
export class ShoppingCartService {
  prices: { value: number, currency: string }[] = []
  shoppingCarts: any[] = []
  count: number = 0
  total: number = 0

  constructor(private swal: SwalService,
    private translate: TranslateService,
    private http: HttpClient) {

    this.checkLocalStorageForShoppingCart()
    this.totalCalc()
  }


  checkLocalStorageForShoppingCart() {

    if (localStorage.getItem('shoppingCarts')) {

      const carts: string | null = localStorage.getItem('shoppingCarts')

      if (carts != null) {
        this.shoppingCarts = JSON.parse(carts)
        this.count = this.shoppingCarts.length
      }

    }

  }


  totalCalc() {

    this.total = 0

    const sumMap = new Map<string, number>()

    this.prices = []
    for (let c of this.shoppingCarts) {
      this.prices.push(c.price)

      this.total += c.price.value
    }

    for (const item of this.prices) {

      const currentSum = sumMap.get(item.currency) || 0
      sumMap.set(item.currency, currentSum + item.value)
    }

    this.prices = []
    for (const [currency, sum] of sumMap) {

      this.prices.push({ value: sum, currency: currency })
      console.log(this.prices);

    }

  }

  removeByIndex(index: number) {

    forkJoin({

      douYouWantToDeleted: this.translate.get("remove.doYouWantToDeleted"),
      confirmBtn: this.translate.get("remove.cancelBtn"),
      cancelBtn: this.translate.get("remove.confirmBtn")

    }).subscribe(res => {


      this.swal.callSwal(res.douYouWantToDeleted, res.confirmBtn, res.cancelBtn, () => {


        this.shoppingCarts.splice(index, 1)
        localStorage.setItem('shoppingCarts', JSON.stringify(this.shoppingCarts))
        this.count = this.shoppingCarts.length
        this.totalCalc()
      })

    })



  }

  payment(data: PaymentModel, callBack: (res: any) => void) {


    this.http.post("https://localhost:7212/api/ShoppingCarts/Payment", data)
      .subscribe(res => {

        callBack(res)
      })




  }












}

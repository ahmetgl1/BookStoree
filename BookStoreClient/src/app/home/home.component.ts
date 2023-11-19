import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { RequestModel } from '../../app/models/request-model';
import { BookModel } from '../../app/models/book.model';
import { TranslateService } from '@ngx-translate/core';
import { ShoppingCartService } from '../../app/services/shopping-cart.service';
import { SwalService } from '../../app/services/swal.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  request: RequestModel = new RequestModel();
  books: BookModel[] = []
  pageNumbers: number[] = []
  categories: any = []
  searchCategory: string = ""



  constructor(private http: HttpClient,
    public translate: TranslateService,
    public shopping: ShoppingCartService,
    private swal: SwalService
   )  
    {

    this.GetAll()
    this.getCategories()

  }

  GetAll() {
    this.http.post<BookModel[]>(`https://localhost:7212/api/Books/GetAll`, this.request)

      .subscribe(res => {
        this.books = res
      })

  }


  getCategories() {

    this.http.get('https://localhost:7212/api/Categories/GetAll')
      .subscribe(res => {
        this.categories = res

      })

  }

  filterByCategory(categoryId: number | null) {
    this.request.categoryId = categoryId;
    this.onScroll();
  }

  onScroll() {

    this.request.PageSize += 6
    this.GetAll()

  }

  addShoppingCart(book: BookModel) {

    this.shopping.shoppingCarts.push(book)

    localStorage.setItem('shoppingCarts' , JSON.stringify(this.shopping.shoppingCarts))

    this.shopping.count++

    this.translate.get("addInBasket").subscribe(res =>{

      this.swal.callToast(res , 'success')
   
    })
    











  }





}







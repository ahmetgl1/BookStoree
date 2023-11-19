import { Component } from '@angular/core';
import { ShoppingCartService } from '../../app/services/shopping-cart.service';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-shopping-cart',
  templateUrl: './shopping-cart.component.html',
  styleUrls: ['./shopping-cart.component.css']
})
export class ShoppingCartComponent {

  language: string = "en"
constructor(public shopping: ShoppingCartService ,
            public translate: TranslateService) {
 


      if (localStorage.getItem('language')) {
          this.language = localStorage.getItem('language') as string
          
     }  
         translate.setDefaultLang(this.language)
            
}

}


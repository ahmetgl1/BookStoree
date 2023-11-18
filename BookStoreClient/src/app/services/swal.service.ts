import { Injectable } from '@angular/core';
import Swal from 'sweetalert2';


@Injectable({
  providedIn: 'root'
})
export class SwalService {

  constructor() { }


  callToast(title: string, icon: SweetAlertIcon) {
    const Toast = Swal.mixin({
      toast: true,
      position: 'bottom-end',
      timer: 3000,
      showConfirmButton: false,
      timerProgressBar: true
    })
    Toast.fire(title, '', icon)

  }


 callSwal(douYouWantToDeleted:string ,  cancelButtonText: string, confirmButtonText:string, callBack: () => void){

  Swal.fire({

  title: douYouWantToDeleted,
  icon: 'question',
  showCancelButton: true,
  cancelButtonText: cancelButtonText,
  showConfirmButton: true,
  confirmButtonText: confirmButtonText

  }).then(res =>{

    if(res.isConfirmed){

      callBack()
    }
  })
  


 }





}
export type SweetAlertIcon = 'success' | 'error' | 'warning' | 'info' | 'question'



export class BookModel{

    id: Number = 0
    title: string = ""
    author: string = ""
    summary: string = ""
    coverImageUrl:  string = ""
    price: Money = new Money()
    quantity: number = 0
    isbn: string =""
    createAt: string = ""
    updateAt :string = ""
    isActive: boolean = true
    isDelete: boolean = false

}
export class Money{

    value: number = 0
    currency: string ="₺"
   
   }
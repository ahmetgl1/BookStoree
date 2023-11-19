import { AddresModel } from "./address.model"
import { BookModel } from "./book.model"
import { BuyerModel } from "./buyer.model"
import { PaymentCardModel } from "./paymentcard.model"

export class PaymentModel{

    books: BookModel[] = []
    buyer: BuyerModel = new BuyerModel()
    shippingAddress: AddresModel = new AddresModel()
    billingAddress: AddresModel = new AddresModel()
    paymentCard: PaymentCardModel = new PaymentCardModel()

} 
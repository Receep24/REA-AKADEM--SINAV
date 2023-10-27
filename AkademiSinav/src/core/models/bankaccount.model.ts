import { Entity } from "./entity.model";

export class BankAccount extends Entity<number> {
  accountNumber?:number
  balance?:number
  userID?:number
  }

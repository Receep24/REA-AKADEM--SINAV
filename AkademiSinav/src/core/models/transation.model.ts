import { Entity } from "./entity.model";

export class Transation extends Entity<number> {
  accountId?:number ;
  transactionDate?:Date;
  description?:string;
  amount?:number;

  }

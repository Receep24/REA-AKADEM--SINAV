import { Time } from "@angular/common";

export interface TransationRequest {
  AccountID:number;
  TransactionDate:Date;
  Description:string;
  Amount:number;
}

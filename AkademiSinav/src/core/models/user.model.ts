
import { Entity } from './entity.model';



export class User extends Entity<number> {
  email: string = '';
  userName: string = '';
  firstName: string = '';
  lastName: string = '';
  age: number = 0;
  userImage: string = '';
  phoneNumber: string = '';
  password: string = '';
  gender?: Gender;
  userType?: UserType;

  }

export enum UserType {
  Admin,
  User,
  Employee,
}

export enum Gender {
  Male,
  Female,
}

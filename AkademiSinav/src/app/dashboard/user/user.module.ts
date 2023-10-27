import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserComponent } from './user.component';
import { AppRoutingModule } from 'src/app/app-routing.module';
import { LayoutsModule } from 'src/app/layouts/layouts.module';
import { UserProfileModule } from './user-profile/user-profile.module';
import { TransationComponent } from './transation/transation.component';

@NgModule({
  declarations: [
    UserComponent,
    TransationComponent,

  ],
  imports: [
    CommonModule,
    AppRoutingModule,
    LayoutsModule,
    UserProfileModule
  ],
  exports: [
    UserComponent
  ],
})
export class UserModule { }

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AnasayfaComponent } from './anasayfa/anasayfa.component';
import { SignComponent } from './sign/sign.component';
import { ContactComponent } from './contact/contact.component';

import { AuthGuard } from './auth-guard';
import { AdminComponent } from './dashboard/admin/admin.component';
import { UserComponent } from './dashboard/user/user.component';



const routes: Routes = [

  { path: '', component: AnasayfaComponent },
  { path: 'anasayfa', component: AnasayfaComponent },
  { path: 'sign', component: SignComponent },
  { path: 'contact', component: ContactComponent },
  {
    /*

const routes: Routes = [
  {
    path: 'admin',
    loadChildren: () =>
      import('./admin/admin.module').then((m) => m.AdminModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'all',
    loadChildren: () =>
      import('./all/all.module').then((m) => m.AllModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'student',
    loadChildren: () =>
      import('./student/student.module').then((m) => m.StudentModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'teacher',
    loadChildren: () =>
      import('./teacher/teacher.module').then((m) => m.TeacherModule),
    canActivate: [AuthGuard]
  }
  */

    path: 'admin',
    component: AdminComponent,
    canActivate: [AuthGuard],
    children: [
      {
        path: 'users',
        loadChildren: () =>
          import('src/app/dashboard/admin/admin-users/admin-users.module').then(
            (m) => m.AdminUsersModule
          ),
      },




    ],
  },
  {
    path: 'user',
    component: UserComponent,
    canActivate: [AuthGuard],
    children: [
      {
        path: 'profile',
        loadChildren: () =>
          import(
            'src/app/dashboard/user/user-profile/user-profile.module'
          ).then((m) => m.UserProfileModule),
      },

    ],
  },



    /*

const routes: Routes = [
  {
    path: 'admin',
    loadChildren: () =>
      import('./admin/admin.module').then((m) => m.AdminModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'all',
    loadChildren: () =>
      import('./all/all.module').then((m) => m.AllModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'student',
    loadChildren: () =>
      import('./student/student.module').then((m) => m.StudentModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'teacher',
    loadChildren: () =>
      import('./teacher/teacher.module').then((m) => m.TeacherModule),
    canActivate: [AuthGuard]
  }
  */



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

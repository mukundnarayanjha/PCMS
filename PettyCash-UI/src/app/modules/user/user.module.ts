import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddUserComponent, UserListComponent , EditUserComponent , UserDetailComponent} from '../user';
import { UserRoutingModule } from './user-routing.module';

@NgModule({
  declarations: [
    AddUserComponent,
    EditUserComponent,
    UserDetailComponent,
    UserListComponent
  ],
  imports: [
    CommonModule,
    UserRoutingModule
  ]
})
export class UserModule { }

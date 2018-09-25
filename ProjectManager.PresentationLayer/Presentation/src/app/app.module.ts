import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AddProjectComponent } from './add-project/add-project.component';
import { AddTaskComponent } from './add-task/add-task.component';
import { AddUserComponent } from './add-user/add-user.component';
import { ViewTaskComponent } from './view-task/view-task.component';

import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from  '@angular/common/http';
import { FilterPipe} from './filter.pipe';

const routes: Routes = [
  { path: 'AddProject', component: AddProjectComponent },
  { path: 'AddTask', component: AddTaskComponent },
  { path: 'AddUser', component: AddUserComponent },
  { path: 'ViewTask', component: ViewTaskComponent }

];

@NgModule({
  declarations: [
    AppComponent,
    AddProjectComponent,
    AddTaskComponent,
    AddUserComponent,
    ViewTaskComponent,
    FilterPipe
  ],
  exports: [ RouterModule ],
  imports: [
    BrowserModule,CommonModule,RouterModule.forRoot(routes),FormsModule,HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

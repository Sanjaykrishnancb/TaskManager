import { Component, OnInit } from '@angular/core';
import { AddUserModel } from '../models/add-user.model';
import { ApiService } from '../api.service'

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent implements OnInit {

  addUserModel:AddUserModel;
  UserModel:AddUserModel[];
  constructor(private apiService:ApiService) { 
    this.addUserModel = new AddUserModel();
  }

  ngOnInit() {
    this.getUsers();
  }

public getUsers(){
  this.apiService.getUsers().subscribe((data:AddUserModel[])=>{
    this.UserModel = data;
    console.log(data);
  })
}

  submitted = false;

  onSubmit() { 
    this.apiService.addUser(this.addUserModel).subscribe((data:boolean)=>{
      console.log("component :"+data);
      this.getUsers();
    })
   }

  // TODO: Remove this when we're done
  get diagnostic() { return JSON.stringify(this.addUserModel); 
}
}

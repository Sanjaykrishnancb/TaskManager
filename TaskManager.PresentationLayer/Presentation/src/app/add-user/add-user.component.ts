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
  constructor(private apiService:ApiService) { 
    this.addUserModel = new AddUserModel();
  }

  ngOnInit() {
    this.getContacts();
  }

public getContacts(){
  this.apiService.getContacts().subscribe((data:string)=>{
    console.log(data);
  })
}

  submitted = false;

  onSubmit() { this.submitted = true; }

  // TODO: Remove this when we're done
  get diagnostic() { return JSON.stringify(this.addUserModel); 
}
}

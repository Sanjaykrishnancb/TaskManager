import { Component, OnInit } from '@angular/core';
import { AddProjectModel } from '../models/add-project.model';
import { ApiService } from '../api.service';
import {formatDate } from '@angular/common';

@Component({
  selector: 'app-add-project',
  templateUrl: './add-project.component.html',
  styleUrls: ['./add-project.component.css']
})
export class AddProjectComponent implements OnInit {

  addProjectModel: AddProjectModel;
  ProjectModel: AddProjectModel[];
  ProjectListCount: number;
  isUpdate: boolean;
  isSetDateEnabled: boolean;
  managerData:string;
  tmpDate:Date;
  constructor(private apiService: ApiService) {
    this.addProjectModel = new AddProjectModel();

    this.isUpdate = false;
    this.isSetDateEnabled = false;
  }

  ngOnInit() {

    this.getProjects();
    this.addProjectModel.Priority = 0;
  }

public toggleSetDate(){
  debugger;
  this.isSetDateEnabled = this.isSetDateEnabled?false:true;
  if(this.isSetDateEnabled){
    this.addProjectModel.Start_Date = new Date();
     this.tmpDate  = new Date();
     this.tmpDate.setDate(this.tmpDate.getDate()+1);
     this.addProjectModel.End_Time = this.tmpDate;
  }
}

  public getProjects() {
    this.apiService.getProjects().subscribe((data: AddProjectModel[]) => {
      debugger;
      this.ProjectModel = data;
      console.log(data);
      this.ProjectListCount = data.length;
    })
  }

  submitted = false;

  onSubmit() {
    this.apiService.addProject(this.addProjectModel).subscribe((data: boolean) => {
      console.log("component :" + data);
      this.getProjects();
      this.addProjectModel.Project_ID = null;
      this.isUpdate = false;
    })
  }

  editUser(project: AddProjectModel) {
    this.addProjectModel.Project_ID = project.Project_ID;
    this.addProjectModel.Start_Date = project.Start_Date;
    this.addProjectModel.End_Time = project.End_Time;
    this.addProjectModel.Priority = project.Priority;
    this.isUpdate = true;
  }

  public deleteProject(project: AddProjectModel) {
    this.apiService.deleteProject(project).subscribe((data: boolean) => {
      console.log(data);
      this.getProjects();
    })
  }

}

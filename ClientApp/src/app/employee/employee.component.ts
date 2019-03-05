import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector : 'employee-component',
    templateUrl : './employee.component.html'
})

export class EmployeeComponent {
    public employeelist: Employee[];
  
    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      http.get<Employee[]>(baseUrl + 'api/Employee/EmployeeListGet').subscribe(result => {
        this.employeelist = result;
      }, error => console.error(error));
    }
  }
  
  interface Employee {
    EmployeeName: string;
    Age: number;
    Course: string;
  }  
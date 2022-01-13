import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { Role } from '../models/role.model';

@Component({
  selector: 'app-role',
  templateUrl: './role.component.html',
  styleUrls: ['./role.component.scss']
})
export class RoleComponent implements OnInit {

  constructor(private dataServices: DataService) { }

  public roles: Role[] = []
  ngOnInit(): void {
    this.dataServices.getAllRole().subscribe(data => {
      this.roles = data;
      console.log(this.roles);
    })
  }

}

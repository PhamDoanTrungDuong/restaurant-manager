import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { Role } from '../models/role.model';
import { ConfirmationService, MessageService } from 'primeng/api';

@Component({
  selector: 'app-role',
  templateUrl: './role.component.html',
  styleUrls: ['./role.component.scss'],
})
export class RoleComponent implements OnInit {

  public roles: Role[] = [];
  public roleDialog: boolean = false;
  public submitted = true;
  private newRole: Role = {
    id: 0,
    name: '',
    description: '',
    created: new Date(),
    updated: new Date(),
    deleted: false,
  };

  public role: Role = Object.assign({}, this.newRole);
  ngOnInit(): void {
   this.Loaddata()
  }
  constructor(
    private dataServices: DataService,
    private messageServices: MessageService,
    private confirmationServics: ConfirmationService
  ) {}

  Loaddata(): void {
    this.dataServices.getAllRole().subscribe((data) => {
      this.roles = data;
      console.log(this.roles);
    });
  }

  public hideDialog(cancel = true, success = true): void {
    console.log('hide Dialog');
    this.roleDialog = false;
    if (cancel) {
      this.messageServices.add({
        severity: 'info',
        summary: 'Hủy',
        detail: 'Không muốn thêm nữa',
        life: 3000,
      });
    } else if (success) {
      this.messageServices.add({
        severity: 'success',
        summary: 'Thành Công',
        detail: 'Thêm mới thành công',
        life: 3000,
      });
    } else {
      this.messageServices.add({
        severity: 'error',
        summary: 'Lỗi',
        detail: 'Thao tác lỗi',
        life: 3000,
      });
    }
  }

  public saveRole(): void {
    if (this.role.id === 0) {
      console.log('save Role', this.role);
      this.dataServices.postRole(this.role).subscribe((data) => {
        console.log('data', data);
        this.roles.push(data);
        this.hideDialog(false, true);
      });
    } else {
      console.log('change Role', this.role);
      this.dataServices.putRole(this.role).subscribe((data) => {
        console.log('data', data);
        this.Loaddata();
        this.hideDialog(false, true);
      });
    }
  }

  public openNew() {
    console.log('open Role');
    this.role = Object.assign({}, this.newRole);
    //console.log('obj', this.role)
    this.roleDialog = true;
  }

  public editRole(role: Role): void {
    console.log('edit Role');
    this.role = role;
    this.roleDialog = true;
  }

  public deleteRole(role: Role) {
    console.log('Delete Role');
    this.confirmationServics.confirm({
      message:
        'Are you sure you want to delete the selected Role: ' +
        role.name +
        ' ?',
      header: 'Confirm',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.messageServices.add({
          severity: 'success',
          summary: 'Successful',
          detail: 'Role Deleted',
          life: 3000,
        });
      },
    });
  }
}

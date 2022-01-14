import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import {MenuItem} from 'primeng/api';
import { DataService } from './data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  constructor(private router: Router, private route: ActivatedRoute, private data: DataService) { }

  title = 'RM_admin';
  items: MenuItem[] = [];

  ngOnInit() {
      this.items = [
          {
              label: 'Nhà Hàng',
              icon: 'pi pi-fw pi-home',
              command: () => this.router.navigate(['/restaurant']),
          },
          {
              label: 'Quyền',
              icon: 'pi pi-fw pi-user-edit',
              command: () => this.router.navigate(['/role']),
          },
          {
              label: 'Tình Trạng',
              icon: 'pi pi-fw pi-flag',
              command: () => this.router.navigate(['/role']),
          },
          {
              label: 'Khu Vực',
              icon: 'pi pi-fw pi-align-justify',
              command: () => this.router.navigate(['/role']),
          },
          {
              label: 'Đơn Vị',
              icon: 'pi pi-fw pi-filter',
              command: () => this.router.navigate(['/role']),
          },
          {
              label: 'Thể Loại',
              icon: 'pi pi-fw pi-user-edit',
              command: () => this.router.navigate(['/role']),
          },
          {
              label: 'Nhân Sự',
              icon: 'pi pi-fw pi-user-edit',
              command: () => this.router.navigate(['/role']),
          },
          {
              label: 'Bàn Ăn',
              icon: 'pi pi-fw pi-table',
              command: () => this.router.navigate(['/role']),
          },
          {
              label: 'Thức Ăn',
              icon: 'pi pi-fw pi-cloud',
              command: () => this.router.navigate(['/role']),
          },
          {
              label: 'Logout',
              icon: 'pi pi-fw pi-sign-out',
              command: () => this.router.navigate(['/role']),
          }
      ];
  }
}

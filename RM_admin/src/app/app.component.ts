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
              routerLink: ['/restaurant'],
              routerLinkActiveOptions: {
                  exact: true
              }
              //command: () => this.router.navigate(['/restaurant']),
          },
          {
              label: 'Quyền',
              icon: 'pi pi-fw pi-user-edit',
              routerLink: ['/role'],
              routerLinkActiveOptions: {
                  exact: true
              }
          },
          {
              label: 'Tình Trạng',
              icon: 'pi pi-fw pi-flag',
              routerLink: ['/status'],
              routerLinkActiveOptions: {
                  exact: true
              }
          },
          {
              label: 'Khu Vực',
              icon: 'pi pi-fw pi-align-justify',
              routerLink: ['/area'],
              routerLinkActiveOptions: {
                  exact: true
              }
          },
          {
              label: 'Đơn Vị',
              icon: 'pi pi-fw pi-filter',
              command: () => this.router.navigate(['/role']),
          },
          {
              label: 'Thể Loại',
              icon: 'pi pi-fw pi-user-edit',
              routerLink: ['/category'],
              routerLinkActiveOptions: {
                  exact: true
              }
          },
          {
              label: 'Nhân Sự',
              icon: 'pi pi-fw pi-user-edit',
              routerLink: ['/user'],
              routerLinkActiveOptions: {
                  exact: true
              }
          },
          {
              label: 'Bàn Ăn',
              icon: 'pi pi-fw pi-table',
              routerLink: ['/table'],
              routerLinkActiveOptions: {
                  exact: true
              }
          },
          {
              label: 'Thức Ăn',
              icon: 'pi pi-fw pi-cloud',
              routerLink: ['/food'],
              routerLinkActiveOptions: {
                  exact: true
              }
          },
          {
              label: 'Logout',
              icon: 'pi pi-fw pi-sign-out',
              routerLink: ['/logout'],
              routerLinkActiveOptions: {
                  exact: true
              }
          }
      ];
  }
}

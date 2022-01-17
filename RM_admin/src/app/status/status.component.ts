import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { ConfirmationService, MessageService } from 'primeng/api';
import { Status } from '../models/status.model';
import { Restaurant } from '../models/restaurant.model';

@Component({
  selector: 'app-status',
  templateUrl: './status.component.html',
  styleUrls: ['./status.component.scss'],
})
export class StatusComponent implements OnInit {
  constructor(
    private dataServices: DataService,
    private messageServices: MessageService,
    private confirmationServics: ConfirmationService
  ) {}


  public restaurants: Restaurant[] = [];
  public selectedRestaurant: Restaurant | undefined;

  public statuses: Status[] = [];
  public displayStatuses: Status[] = [];
  public statusDialog: boolean = false;
  public submitted = true;
  public status: Status = Object.assign({}, this.dataServices.newStatus);
  public loading = true;
  
  ngOnInit(): void {
    this.Loaddata();
    this.LoadDataRestaurant();
  }
  Loaddata(): void {
    this.loading = true;
    this.dataServices.getAllStatuses().subscribe((data) => {
      this.loading = false;
      this.statuses = data;
      console.log(this.statuses);
    });
  }

  LoadDataRestaurant(): void {
    this.loading = true;
    this.dataServices.getAllRestaurants().subscribe(data => {
      this.loading = false;
      this.restaurants = data;
      console.log(this.restaurants);
    })
  }

  public hideDialog(cancel = true, success = true): void {
    console.log('hide Dialog');
    this.statusDialog = false;
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

  public saveStatus(): void {
    if (this.status.id === 0) {
      this.status.createdUser.id = this.dataServices.loginUserId;
      this.status.updatedUser.id = this.dataServices.loginUserId;

      console.log('save status', this.status);
      this.dataServices.postStatus(this.status).subscribe((data) => {
        console.log('data', data);
        //this.statuses.push(data);
        this.displayStatuses = this.statuses.filter(status => 
          status.restaurant.id === this.selectedRestaurant?.id
        );
        this.hideDialog(false, true);
      });
    } else {
      this.status.updatedUser.id = this.dataServices.loginUserId;
      console.log('change status', this.status);
      this.dataServices.putStatus(this.status).subscribe((data) => {
        console.log('data', data);
        this.Loaddata();
        this.hideDialog(false, true);
      });
    }
  }

  public openNew() {
    if(!this.selectedRestaurant){
      this.messageServices.add({
        severity: 'error',
        summary: 'Lỗi',
        detail: 'Hãy chọn nhà hàng',
        life: 3000,
      });
      return
    }
    console.log('open status');
    this.status = Object.assign({}, this.dataServices.newStatus);
    this.status.restaurant.id = this.selectedRestaurant.id;
    //console.log('obj', this.status)
    this.statusDialog = true;
  }

  public editStatus(status: Status): void {
    console.log('edit status');
    this.status = status;
    this.statusDialog = true;
  }

  public deleteStatus(status: Status) {
    console.log('Delete Status');
    this.confirmationServics.confirm({
      message:
        'Are you sure you want to delete the selected status: ' +
        status.name +
        ' ?',
      header: 'Confirm',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        status.deleted = true;
        console.log('xoa', status);
        this.dataServices.putStatus(this.status).subscribe((data) => {
          console.log('data', data);
          this.Loaddata();
        });
        this.messageServices.add({
          severity: 'success',
          summary: 'Successful',
          detail: 'Status Deleted',
          life: 3000,
        });
      },
    });
  }

  public recoverStatus(status: Status) {
    console.log('Recover Status');
    this.confirmationServics.confirm({
      message:
        'Are you sure you want to recover the selected status: ' +
        status.name +
        ' ?',
      header: 'Confirm',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        status.deleted = false;
        console.log('thu', status);
        this.dataServices.putStatus(this.status).subscribe((data) => {
          console.log('data', data);
          this.Loaddata();
        });
        this.messageServices.add({
          severity: 'success',
          summary: 'Successful',
          detail: 'Status Recover',
          life: 3000,
        });
      },
    });
  }

  onRestaurantChange(event: any){
    const restaurant: Restaurant = event;
    console.log('onChange: ', restaurant);
    this.displayStatuses = this.statuses.filter(status => 
      status.restaurant.id === restaurant.id
    );
    this.Loaddata()
  }
}

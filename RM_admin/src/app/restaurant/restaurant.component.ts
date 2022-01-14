import { JsonPipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ConfirmationService, MessageService } from 'primeng/api';
//import { triggerAsyncId } from 'async_hooks';
import { DataService } from '../data.service';
import { Restaurant } from '../models/restaurant.model';

@Component({
  selector: 'app-restaurant',
  templateUrl: './restaurant.component.html',
  styleUrls: ['./restaurant.component.scss']
})
export class RestaurantComponent {

  constructor( private dataServices: DataService
              ,private messageServices: MessageService
              ,private confirmationServics: ConfirmationService 
    ) { }
  
  public restaurants: Restaurant[] =[]
  public restaurantDialog: boolean = false
  public submitted = true;
  private newRestaurant: Restaurant = {
    id: 0,
    name: '',
    description: '',
    phone: '',
    address: '',
    created: new Date(),
    updated: new Date(),
    deleted: false,
    createdUser: {
      id: 1,
      userName: '',
      created: new Date(),
      updated: new Date(),
      createdUserId: 0,
      updateUserId: 0
    },
    updatedUser: {
      id: 1,
      userName: '',
      created: new Date(),
      updated: new Date(),
      createdUserId: 0,
      updateUserId: 0
    }
  }

  public restaurant: Restaurant = Object.assign({}, this.newRestaurant);
  public loading = true;
  ngOnInit(): void {
    this.Loaddata()
  }
  Loaddata(): void {
    this.loading = true;
    this.dataServices.getAllRestaurants().subscribe(data => {
      this.loading = false;
      this.restaurants = data;
      console.log(this.restaurants);
    })
  }

  public hideDialog(cancel = true, success = true): void{
    console.log('hide Dialog')
    this.restaurantDialog = false;
    if(cancel){
      this.messageServices.add(
        {
          severity:'info', 
          summary: 'Hủy', 
          detail: 'Không muốn thêm nữa', 
          life: 3000
        });
    }else if(success) {
      this.messageServices.add(
        {
          severity:'success', 
          summary: 'Thành Công', 
          detail: 'Thêm mới thành công', 
          life: 3000
        });
    }else{
      this.messageServices.add(
        {
          severity:'error', 
          summary: 'Lỗi', 
          detail: 'Thao tác lỗi', 
          life: 3000
        });
    }
  }

  public saveRestaurant(): void{
   if(this.restaurant.id === 0){
    this.restaurant.createdUser.id = this.dataServices.loginUserId;
    this.restaurant.updatedUser.id = this.dataServices.loginUserId;

    console.log("save restaurant", this.restaurant)
    this.dataServices.postRestaurant(this.restaurant).subscribe( data => {
      console.log('data', data);
      this.restaurants.push(data)
      this.hideDialog(false, true)
    });
   }else{
    this.restaurant.updatedUser.id = this.dataServices.loginUserId;
    console.log("change restaurant", this.restaurant)
    this.dataServices.putRestaurant(this.restaurant).subscribe( data => {
      console.log('data', data);
      this.Loaddata()
      this.hideDialog(false, true)
    });
   }
  }

  public openNew(){
    console.log("open restaurant")
    this.restaurant = Object.assign({}, this.newRestaurant); 
    //console.log('obj', this.restaurant)
    this.restaurantDialog = true;
  }

  public editRestaurant(restaurant: Restaurant): void{
    console.log("edit restaurant")
    this.restaurant = restaurant;
    this.restaurantDialog = true;
  }

  public deleteRestaurant(restaurant: Restaurant){
    console.log('Delete Restaurant')
    this.confirmationServics.confirm({
      message: 'Are you sure you want to delete the selected restaurant: ' + restaurant.name + ' ?',
      header: 'Confirm',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
          restaurant.deleted = true;
          console.log("xoa", restaurant);
          this.dataServices.putRestaurant(this.restaurant).subscribe( data => {
            console.log('data', data);
            this.Loaddata()
          });
          this.messageServices.add(
            {
              severity:'success', 
              summary: 'Successful', 
              detail: 'Restaurant Deleted', 
              life: 3000
            });
      }
  });
  }

  public recoverRestaurant(restaurant: Restaurant){
    console.log('Recover Restaurant')
    this.confirmationServics.confirm({
      message: 'Are you sure you want to recover the selected restaurant: ' + restaurant.name + ' ?',
      header: 'Confirm',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
          restaurant.deleted = false;
          console.log("thu", restaurant);
          this.dataServices.putRestaurant(this.restaurant).subscribe( data => {
            console.log('data', data);
            this.Loaddata()
          });
          this.messageServices.add(
            {
              severity:'success', 
              summary: 'Successful', 
              detail: 'Restaurant Recover', 
              life: 3000
            });
      }
  });
  }

}

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
    deleted: false
  }

  public restaurant: Restaurant = Object.assign({}, this.newRestaurant);

  ngOnInit(): void {
    this.Loaddata()
  }
  Loaddata(): void {
    this.dataServices.getAllRestaurants().subscribe(data => {
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
    console.log("save restaurant", this.restaurant)
    this.dataServices.postRestaurant(this.restaurant).subscribe( data => {
      console.log('data', data);
      this.restaurants.push(data)
      this.hideDialog(false, true)
    });
   }else{
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

}

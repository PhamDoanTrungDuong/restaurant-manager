import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Restaurant } from './models/restaurant.model';
import { Role } from './models/role.model';
import { Status } from './models/status.model';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  public loginUserId = 1;
  private REST_API_SERVER = environment.api
  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json',
     // Authorization: 'my-auth-token'
    })
  };
  public newRestaurant: Restaurant = {
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

  public newStatus = {
    id: 0,
    name: '',
    description: '',
    phone: '',
    address: '',
    created: new Date(),
    updated: new Date(),
    deleted: false,
    restaurant: this.newRestaurant,
    createdUser: {
      id: 1,
      userName: '',
      created: new Date(),
      updated: new Date(),
      createdUserId: 0,
      updateUserId: 0,
    },
    updatedUser: {
      id: 1,
      userName: '',
      created: new Date(),
      updated: new Date(),
      createdUserId: 0,
      updateUserId: 0,
    },
  };
  
  constructor(private httpClient: HttpClient) { }

  //Retaurant
  public getAllRestaurants(): Observable<Restaurant[]> {
    const url = `${this.REST_API_SERVER}/restaurant`;
    return this.httpClient.get<Restaurant[]>(url, this.httpOptions);
  }

  public postRestaurant(payload: Restaurant): Observable<Restaurant> {
    const url = `${this.REST_API_SERVER}/restaurant`;
    return this.httpClient.post<Restaurant>(url, payload, this.httpOptions);
  }

  public putRestaurant(payload: Restaurant): Observable<Restaurant> {
    const url = `${this.REST_API_SERVER}/restaurant`;
    return this.httpClient.put<Restaurant>(url, payload, this.httpOptions);
  }

  //Role
  public getAllRole(): Observable<Role[]> {
    const url = `${this.REST_API_SERVER}/role`;
    return this.httpClient.get<Role[]>(url, this.httpOptions);
  }

  public postRole(payload: Role): Observable<Role> {
    const url = `${this.REST_API_SERVER}/role`;
    return this.httpClient.post<Role>(url, payload, this.httpOptions);
  }

  public putRole(payload: Role): Observable<Role> {
    const url = `${this.REST_API_SERVER}/role`;
    return this.httpClient.put<Role>(url, payload, this.httpOptions);
  }

  //Status

  public getAllStatuses(): Observable<Status[]> {
    const url = `${this.REST_API_SERVER}/status`;
    return this.httpClient.get<Status[]>(url, this.httpOptions);
  }

  public postStatus(payload: Status): Observable<Restaurant> {
    const url = `${this.REST_API_SERVER}/status`;
    return this.httpClient.post<Status>(url, payload, this.httpOptions);
  }

  public putStatus(payload: Restaurant): Observable<Status> {
    const url = `${this.REST_API_SERVER}/status`;
    return this.httpClient.put<Status>(url, payload, this.httpOptions);
  }
}

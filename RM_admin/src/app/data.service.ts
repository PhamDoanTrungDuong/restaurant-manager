import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Restaurant } from './models/restaurant.model';
import { Role } from './models/role.model';

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

  constructor(private httpClient: HttpClient) { }

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
}

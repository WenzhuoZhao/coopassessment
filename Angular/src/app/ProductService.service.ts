import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Product} from './Product';


@Injectable({
    providedIn: 'root'
  })

export class ProductService{
    private apiURL : string = "http://localhost:4201/api/Products";
  
    constructor(private httpClient: HttpClient){}
    
    public Get(ID : number){
        return this.httpClient.get<Product>(`${this.apiURL}/Get/${ID}`);
    } 

    public GetAll(){
        return this.httpClient.get<Product[]>(`${this.apiURL}/GetAll`);
    } 

    public Edit(product:Product){
        return this.httpClient.post(`${this.apiURL}/Edit/`,product);
    } 
    public Delete(ID : number){
        return this.httpClient.post(`${this.apiURL}/Delete/`,ID);
    } 
    public Add(product : Product){
        return this.httpClient.post(`${this.apiURL}/Add/`,product);
    } 
}

  

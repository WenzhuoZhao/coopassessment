import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { ProductService } from '../ProductService.service';
import { Product } from '../Product';

@Component({
  selector: 'app-product-component',
  templateUrl: './product-component.component.html',
  styleUrls: ['./product-component.component.css'],
  providers:[ProductService]
})
export class ProductComponentComponent implements OnInit {

  constructor(private productService:ProductService){}
  products: Product[] = [];
  product : Product;
  ngOnInit(){
      this.productService.GetAll().subscribe((products)=>{
        this.products = products;
        console.log(this.products);
      });
  }
  onAddProduct(product : Product){
      this.productService.Add(product).subscribe((res)=>{});
  }

  onDeleteProduct(ID:number){
      this.productService.Delete(ID).subscribe((res)=>{});
  }

  onGetProduct(ID:number){
      this.productService.Get(1).subscribe((res)=>{
        this.product = res;
        console.log(this.product);
      });
  }

  OnEditProduct(product : Product){
      this.productService.Edit(product).subscribe((res)=>{
      });
  }

@ViewChild('id') id:ElementRef;
  GetProductByiD(){
    console.log(this.id.nativeElement.value);
    this.onGetProduct(parseInt(this.id.nativeElement.value));
  }
  }

  









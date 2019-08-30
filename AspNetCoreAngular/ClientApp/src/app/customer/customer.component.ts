import { Component } from '@angular/core';

@Component({
  selector: 'app-customer-component',
  templateUrl: './customer.component.html'
})
export class CustomerComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}

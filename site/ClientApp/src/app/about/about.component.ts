import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit {

  public versionNumber: Version;
  constructor() {
    this.versionNumber = new Version('1.0.0');
   }

  ngOnInit() {
  }

}

class Version {
  constructor(n: String) {
    this.apiVersion = n;
  }
  apiVersion: String;
}

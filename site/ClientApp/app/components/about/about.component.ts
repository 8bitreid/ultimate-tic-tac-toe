import { Component, Inject, PLATFORM_ID } from '@angular/core';
import { ApiService } from '../../service/api.service';
import { isPlatformBrowser, isPlatformServer } from '@angular/common';

@Component({
    selector: 'about',
    templateUrl: './about.component.html'
})
export class AboutComponent {
    public versionNumber: Version;

    constructor(private api: ApiService, 
        @Inject(PLATFORM_ID) private platformId: any,
        @Inject('LOCALSTORAGE') private localStorage: any) {
            this.api.version().subscribe(res =>
                // console.log(JSON.stringify(res))
                this.versionNumber = res
            )
         }

    onInit() {
        if (isPlatformBrowser(this.platformId)) {
            // localStorage will be available: we can use it.
            console.log("in the browser")
            
        }
        if (isPlatformServer(this.platformId)) {
            // localStorage will be null.
            console.log("[INFO]: server")
        }
       
    }
}
interface Version {
    apiVersion: String;
}
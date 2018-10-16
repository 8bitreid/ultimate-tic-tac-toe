import { Http, ResponseType, RequestOptions, Headers } from "@angular/http";
import { Injectable, Inject } from "@angular/core";
import { getBaseUrl } from "../app.browser.module";
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs';
import { PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser, isPlatformServer } from '@angular/common';

@Injectable()
export class ApiService {
    private baseUrl: String;
    constructor(private http: Http,
        @Inject('BASE_URL') baseUrl: string,
        @Inject(PLATFORM_ID) private platformId: any){
            this.baseUrl = baseUrl;
    }
    
    public version(): Observable<Version> {
        let url = this.baseUrl + "api/About/ApiVersion"
         return this.http.get(url).map(
            res => res.json() as Version
        )
    }
}

interface Version {
    apiVersion: String;
}
import { Component } from "@angular/core";
import { ApiService } from "../../service/api.service";

@Component({
    selector: "board",
    templateUrl: "./board.component.html",
    styleUrls: ["./coard.component.css"]
})
export class BoardComponent {
    constructor(private apiService: ApiService){
    }
}
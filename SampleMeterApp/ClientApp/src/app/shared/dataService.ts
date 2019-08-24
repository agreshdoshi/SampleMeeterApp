import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from "rxjs"
import { map } from "rxjs/operators";
import { Meters } from '../shared/meters';


@Injectable()
export class DataService {

  public meters: Meters[]
  private baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  loadMeters(): Observable<boolean> {
    return this.http.get(this.baseUrl + 'api/SampleData/Products')
      .pipe(
        map((data: any[]) => {
          this.meters = data;
          return true;
        }));
  }
}


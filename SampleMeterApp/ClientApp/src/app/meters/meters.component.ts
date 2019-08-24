import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DataService } from '../shared/dataService';
import { Meters } from '../shared/meters';

@Component({
  selector: 'app-meters',
  templateUrl: './meters.component.html'
})

export class MetersComponent implements OnInit {
  public meters: Meters[]
  constructor(private data: DataService) {
  }

  ngOnInit(): void {
    this.data.loadMeters()
      .subscribe(success => {
        if (success) {
          this.meters = this.data.meters;
        }
      })
  }
}


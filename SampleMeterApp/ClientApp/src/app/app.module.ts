import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { MetersComponent } from './meters/meters.component';
import { DataService } from './shared/dataService';

@NgModule({
  declarations: [
    AppComponent,
    MetersComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'meters', component: MetersComponent, pathMatch: 'full' },
    ])
  ],
  providers: [
    DataService
  ],

  bootstrap: [AppComponent]
})
export class AppModule { }

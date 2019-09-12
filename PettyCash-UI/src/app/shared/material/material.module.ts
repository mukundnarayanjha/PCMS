import { NgModule } from '@angular/core';
// tslint:disable-next-line:max-line-length
import { MatButtonModule, MatCheckboxModule, MatToolbarModule, MatChipsModule, MatOptionModule,
   MatGridListModule, MatProgressBarModule, MatSliderModule, MatSlideToggleModule, MatMenuModule,
   MatDialogModule, MatSnackBarModule, MatSelectModule, MatInputModule, MatSidenavModule, MatCardModule,
   MatIconModule, MatRadioModule, MatProgressSpinnerModule, MatTabsModule, MatListModule
  } from '@angular/material';

@NgModule({
  imports: [
    MatButtonModule, MatCheckboxModule, MatToolbarModule, MatChipsModule, MatOptionModule, MatGridListModule,
     MatProgressBarModule, MatSliderModule, MatSlideToggleModule, MatMenuModule, MatDialogModule,
     MatSnackBarModule, MatSelectModule, MatInputModule, MatSidenavModule, MatCardModule, MatIconModule,
     MatRadioModule, MatProgressSpinnerModule, MatTabsModule, MatListModule
  ],
  exports: [
    MatButtonModule, MatCheckboxModule, MatToolbarModule, MatChipsModule, MatOptionModule, MatGridListModule,
     MatProgressBarModule, MatSliderModule, MatSlideToggleModule, MatMenuModule, MatDialogModule,
     MatSnackBarModule, MatSelectModule, MatInputModule, MatSidenavModule, MatCardModule, MatIconModule,
     MatRadioModule, MatProgressSpinnerModule, MatTabsModule, MatListModule
  ],
})
export class MaterialModule { }

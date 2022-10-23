import { TestBed } from '@angular/core/testing';

import { ProductoxtiendaService } from './productoxtienda.service';

describe('ProductoxtiendaService', () => {
  let service: ProductoxtiendaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProductoxtiendaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

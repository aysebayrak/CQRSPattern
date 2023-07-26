﻿namespace CQRS_Casgem.CQRSPatern.Commands
{
    public class CreateProductCommand
    {
       
      
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
    }
}
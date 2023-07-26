﻿namespace CQRS_Casgem.CQRSPatern.Commands
{

    public class UpdateProductCommand
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
    }
}

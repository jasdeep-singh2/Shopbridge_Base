﻿namespace Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get;set; }
        public DateTime Date { get; set; }
    }
}

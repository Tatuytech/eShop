﻿using eShop.Data.Domain;

namespace eShop.ViewModels
{
    public class OrderViewModel
    {
        private const string DEFAULT_STATUS = "Pending";

        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public string Status => DEFAULT_STATUS;
        public Address ShippingAddress { get; set; }
        public List<OrderItemViewModel> OrderItems { get; set; } = new List<OrderItemViewModel>();
    }
}

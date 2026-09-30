using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal productsTotal = 0m;
        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalCost();
        }

        // $5 shipping for USA customers, $35 for international
        decimal shippingCost = _customer.LivesInUsa() ? 5.00m : 35.00m;

        return productsTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- PACKING LABEL ---\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- SHIPPING LABEL ---\n";
        label += $"Customer: {_customer.GetName()}\n";
        label += _customer.GetAddress().GetFormattedAddress() + "\n";
        return label;
    }
}
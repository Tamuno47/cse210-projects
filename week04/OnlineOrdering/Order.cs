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

    public int GetTotalCost()
    {
        int totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            totalCost += 5;
        }

        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packLabel = "";
        
        foreach (Product product in _products)
        {
           packLabel += $"{product.GetName()} ({product.GetProductId()})\n"; 
        }
        
        return packLabel;
    }

    public string GetShippingLabel()
    {
        string shiplabel = "";

        shiplabel += _customer.GetName() + "\n";

        shiplabel += _customer.GetAddress().GetAddress();

        return shiplabel;
    }



}
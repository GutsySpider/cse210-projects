using System;

class Order
{
    private List<Product> _products = new List<Product>();

    private string _customer;
    private double _cost;
    private double _shippingCost;
    private const double UsaShippingCost = 5.50;
    private const double InternationalShippingCost = 15.99;
    private Order(string customer, double shippingCost)
    {
        _customer = customer;
        _cost = 0.00;
        _shippingCost = shippingCost;
    }

    public static Order CreateOrder(Customer customer)
    {
        double shippingCost;
        string country = customer.GetAddress().GetCountry().ToLower();
        if (country == "usa")
        {
            shippingCost = UsaShippingCost;
        }
        else
        {
            shippingCost = InternationalShippingCost;
        }
        return new Order(customer.GetName(), shippingCost);
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
        _cost += product.ProductCost();
    }
    public double GetBaseCost()
    {
        return _cost;
    }
    public double GetShippingCost()
    {
        return _shippingCost;
    }

    public double TotalPrice()
    {
        return _cost + _shippingCost;
    }

    public void CreatePackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.Display());
        }
    }
    public string CreateShippingLabel(Customer customer)
    {
        return $"Customer - {customer.GetName()} Address - {customer.GetAddress().DisplayAll()}";
    }
    
}
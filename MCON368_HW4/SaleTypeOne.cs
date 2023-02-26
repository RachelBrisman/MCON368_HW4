using System.Collections;
using System.Text;

namespace MCON368_HW4;

public class SaleTypeOne
{
    public String Item { get; set; }
    public String Customer { get; set; }
    public double PricePerItem { get; set; }
    public int Quantity { get; set; }
    public String Address { get; set; }
    public bool ExpeditedShipping { get; set; }

    public SaleTypeOne(String item, String customer, double ppItem, int quantity, String address, bool eShipping)
    {
        Item = item;
        Customer = customer;
        PricePerItem = ppItem;
        Quantity = quantity;
        Address = address;
        ExpeditedShipping = eShipping;
    }

    public String ToString()
    {
        StringBuilder sale = new StringBuilder();
        sale.Append("Item: " + Item);
        sale.Append(" Customer: " + Customer);
        sale.Append(" Quantity: " + Quantity);
        sale.Append(" Price Per Item: " + PricePerItem);
        sale.Append(" Address: " + Address);
        sale.Append(" Expedited Shipping: " + ExpeditedShipping);
        return sale.ToString();
    }
}
public class GetTypeOneCollections
{
    private SaleTypeOne[] salesArray { get; set; }

    public GetTypeOneCollections(SaleTypeOne[] sales)
    {
        salesArray = sales;
    }

    public ArrayList GetPricePerItemOver10()
    {
        ArrayList result_array = new ArrayList();
        foreach (var sale in salesArray)
        {
            if (sale.PricePerItem > 10.0)
            {
                result_array.Add(sale);
            }
        }
        return result_array;
    }
    
    public ArrayList GetQuantityIs1()
    {
        ArrayList result_array = new ArrayList();
        foreach (var sale in salesArray)
        {
            if (sale.Quantity == 1)
            {
                result_array.Add(sale);
            }
        }
        result_array.Sort(new SalesTypeOneComparer());
        return result_array;
    }
    
    public ArrayList GetTeaNoExpShipping()
    {
        ArrayList result_array = new ArrayList();
        foreach (var sale in salesArray)
        {
            if (sale.Item == "tea" && !sale.ExpeditedShipping)
            {
                result_array.Add(sale);
            }
        }
        return result_array;
    }
    
    public ArrayList GetAddressesWhereOrderOver100()
    {
        ArrayList result_array = new ArrayList();
        var order_total = 0.0;
        foreach (var sale in salesArray)
        {
            order_total += sale.PricePerItem * sale.Quantity;
        }
        if (order_total >= 100.0)
        {
            foreach (var sale in salesArray)
            {
                result_array.Add(sale.Address);
            }
        }
        return result_array;
    }
} 

public class SalesTypeOneComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        try
        {
            var sale1 = x as SaleTypeOne;
            var sale2 = y as SaleTypeOne;
            return sale2.PricePerItem.CompareTo(sale1.PricePerItem);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return -100;
    }
}
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

    public SaleTypeOne[] GetPricePerItemOver10()
    {
        SaleTypeOne[] result_array = {};
        foreach (var sale in salesArray)
        {
            if (sale.PricePerItem > 10.0)
            {
                Array.Resize(ref result_array, result_array.Length + 1);
                result_array[result_array.Length - 1] = sale;
            }
        }
        return result_array;
    }
    
    public SaleTypeOne[] GetQuantityIs1()
    {
        SaleTypeOne[] result_array = {};
        foreach (var sale in salesArray)
        {
            if (sale.Quantity == 1)
            {
                Array.Resize(ref result_array, result_array.Length + 1);
                result_array[result_array.Length - 1] = sale;
            }
        }
        Array.Sort(result_array, new SalesComparer());
        return result_array;
    }
    
    public SaleTypeOne[] GetTeaNoExpShipping()
    {
        SaleTypeOne[] result_array = {};
        foreach (var sale in salesArray)
        {
            if (sale.Item == "tea" && !sale.ExpeditedShipping)
            {
                Array.Resize(ref result_array, result_array.Length + 1);
                result_array[result_array.Length - 1] = sale;
            }
        }
        return result_array;
    }
    
    public string[] GetAddressesWhereOrderOver100()
    {
        string[] result_array= {};
        var order_total = 0.0;
        foreach (var sale in salesArray)
        {
            order_total += sale.PricePerItem * sale.Quantity;
        }
        if (order_total >= 100.0)
        {
            foreach (var sale in salesArray)
            {
                Array.Resize(ref result_array, result_array.Length + 1);
                result_array[result_array.Length - 1] = sale.Address;
            }
        }
        return result_array;
    }
} 

public class SalesComparer : IComparer
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
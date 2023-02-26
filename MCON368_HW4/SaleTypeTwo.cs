using System.Collections;
using System.Text;

namespace MCON368_HW4;

public class SaleTypeTwo
{
    public String Item { get; set; }
    public double TotalPrice { get; set; }
    public String Address { get; set; } = "";
    public String Customer { get; set; }

    public SaleTypeTwo(SaleTypeOne sale)
    {
        Item = sale.Item;
        TotalPrice = sale.PricePerItem * sale.Quantity;
        Customer = sale.Customer;
        if (sale.ExpeditedShipping)
            Address = sale.Address + " EXPEDITE";
        else
            Address = sale.Address;
    }


public override String ToString()
    {
        StringBuilder sale = new StringBuilder();
        sale.Append("Item: " + Item);
        sale.Append(" Customer: " + Customer);
        sale.Append(" Total Price: " + TotalPrice);
        sale.Append(" Address: " + Address);
        return sale.ToString();
    }
}

public class GetTypeTwoCollections
{
    private SaleTypeTwo[] SalesArray { get; set; }

    public GetTypeTwoCollections(SaleTypeTwo[] sales)
    {
        SalesArray = sales;
    }

    public SaleTypeTwo[] GetLLCs()
    {
        SaleTypeTwo[] result_array = {};
        foreach (var sale in SalesArray)
        {
            if (sale.Customer.ToUpper().Contains("LLC"))
            {
                Array.Resize(ref result_array, result_array.Length + 1);
                result_array[result_array.Length - 1] = sale;
            }
        }
        Array.Sort(result_array, new SalesTypeTwoComparer());
        return result_array;
    }
}

public class SalesTypeTwoComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        try
        {
            var sale1 = x as SaleTypeTwo;
            var sale2 = y as SaleTypeTwo;
            return sale1.TotalPrice.CompareTo(sale2.TotalPrice);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return -100;
    }
}
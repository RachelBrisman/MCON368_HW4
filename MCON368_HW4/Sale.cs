namespace MCON368_HW4;

public class Sale
{
    public String Item { get; set; }
    public String Customer { get; set; }
    public double PricePerItem { get; set; }
    public int Quantity { get; set; }
    public String Address { get; set; }
    public bool ExpeditedShipping { get; set; }

    public Sale(String item, String customer, double ppItem, int quantity, String address, bool eShipping)
    {
        Item = item;
        Customer = customer;
        PricePerItem = ppItem;
        Quantity = quantity;
        Address = address;
        ExpeditedShipping = eShipping;
    }
}
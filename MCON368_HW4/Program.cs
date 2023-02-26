/*
 * Rachel Brisman
 * T00437337
 * MCON 368 Spring 2023
 * HW 4
 * 
 */

using System.Collections;
using MCON368_HW4;

SaleTypeOne sale1 = new SaleTypeOne("tea", "bob llc", 4.45, 1, "Paran 14", true);
SaleTypeOne sale2 = new SaleTypeOne("candy", "joe", 7.99, 40, "paran 1", false);
SaleTypeOne sale3 = new SaleTypeOne("chicken", "henry llc", 40.00, 5, "paran 7", true);
SaleTypeOne sale4 = new SaleTypeOne("meat", "abe", 69.99, 2, "paran 12", false);
SaleTypeOne sale5 = new SaleTypeOne("tea", "gary llc", 3.69, 1, "paran 16", false);

SaleTypeTwo sale6 = new SaleTypeTwo(sale1);
SaleTypeTwo sale7 = new SaleTypeTwo(sale2);
SaleTypeTwo sale8 = new SaleTypeTwo(sale3);
SaleTypeTwo sale9 = new SaleTypeTwo(sale4);
SaleTypeTwo sale0 = new SaleTypeTwo(sale5);

SaleTypeOne[] sales_array_one = {sale1, sale2, sale3, sale4, sale5};
GetTypeOneCollections get_collections_one = new GetTypeOneCollections(sales_array_one);

SaleTypeTwo[] sales_array_two = {sale6, sale7, sale8, sale9, sale0};
GetTypeTwoCollections get_collections_two = new GetTypeTwoCollections(sales_array_two);


// Question 1 
ArrayList array_1 = get_collections_one.GetPricePerItemOver10();
Console.WriteLine("\nPrice per Item is over 10:");
foreach (SaleTypeOne sale in array_1)
 Console.WriteLine(sale.ToString());

// Question 2
ArrayList array_2 = get_collections_one.GetQuantityIs1();
Console.WriteLine("\nQuantity is 1:");
foreach (SaleTypeOne sale in array_2)
{ 
 Console.WriteLine(sale.ToString());
}


// Question 3
ArrayList array_3 = get_collections_one.GetTeaNoExpShipping();
Console.WriteLine("\nTea w/o expedited shipping:");
foreach (SaleTypeOne sale in array_3)
{ 
 Console.WriteLine(sale.ToString());
}

// Question 4
ArrayList array_4 = get_collections_one.GetAddressesWhereOrderOver100();
Console.WriteLine("\nAddresses where order is over 100:");
foreach (var add in array_4)
{ 
 Console.WriteLine(add);
}

// Question 5
ArrayList array_5 = get_collections_two.GetLLCs();
Console.WriteLine("\nLLCs ordered by price:");
foreach (SaleTypeTwo sale in array_5)
{ 
 Console.WriteLine(sale.ToString());
}
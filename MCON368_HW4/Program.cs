/*
 * Rachel Brisman
 * T00437337
 * MCON 368 Spring 2023
 * HW 4
 * 
 */

using System.Collections;
using MCON368_HW4;

SaleTypeOne sale1 = new SaleTypeOne("tea", "bob", 4.45, 1, "14 Paran", true);
SaleTypeOne sale2 = new SaleTypeOne("candy", "joe", 7.99, 40, "paran 1", false);
SaleTypeOne sale3 = new SaleTypeOne("chicken", "henry", 40.00, 5, "paran 7", true);
SaleTypeOne sale4 = new SaleTypeOne("meat", "abe", 69.99, 2, "paran 12", false);
SaleTypeOne sale5 = new SaleTypeOne("tea", "gary", 3.69, 1, "paran 16", false);

SaleTypeOne[] sales_array = {sale1, sale2, sale3, sale4, sale5};

GetTypeOneCollections get_collections = new GetTypeOneCollections(sales_array);

ArrayList arr = get_collections.GetQuantityIs1();

foreach (SaleTypeOne c in arr)
{ 
 Console.WriteLine(c.ToString());
}
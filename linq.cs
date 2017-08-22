// David Wright 
// Linq Lab

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Lab
{
    class Program
    {
        static void Main(string[] args)
        {      // initialize array of invoices
            Invoice[] invoices = {
         new Invoice( 83, "Electric sander", 7, 57.98M ),
         new Invoice( 24, "Power saw", 18, 99.99M ),
         new Invoice( 7, "Sledge hammer", 11, 21.5M ),
         new Invoice( 77, "Hammer", 76, 11.99M ),
         new Invoice( 39, "Lawn mower", 3, 79.5M ),
         new Invoice( 68, "Screwdriver", 106, 6.99M ),
         new Invoice( 56, "Jig saw", 21, 11M ),
         new Invoice( 3, "Wrench", 34, 7.5M ) }; // end initializer list

            // Sort by parts description (alphabetically)
            var partsDescriptionList =
                from description in invoices
                orderby description.PartDescription
                select description;

            // Print out invoice in alphabetical order of parts description
            Console.WriteLine("\na) Sorted by description:");
            foreach (var item in partsDescriptionList)
                Console.WriteLine(" {0}",item.ToString());

            // Sort by price 
            var partsPriceList =
                from price in invoices
                orderby price.Price
                select price;

            // Print out invoice in order of price from lowest to highest
            Console.WriteLine("\nb) Sorted by price:");
            foreach (var item in partsPriceList)
                Console.WriteLine(" {0}", item.ToString());

            //Select the PartDescription and Quantity and sort the results by Quantity.
            var quantityList =
                from quantity in invoices
                orderby quantity.Quantity
                select new { quantity.PartDescription, Quantity = quantity.Quantity };

            //Print out list with PartDescription and Quantity that is sorted by Quantity
            Console.WriteLine("\nc) Select description and quantity, sort by quantity:");
            foreach (var item in quantityList)
                Console.WriteLine(item);

            // Select the PartDescription and calculate the value of the invoice. Then sort by that value
            var valueList =
                from item in invoices
                let value = item.Quantity * item.Price
                orderby value
                select new { item.PartDescription, InvoiceTotal = value };

            //Print out list with PartDescription and value that is sorted by value from low to high
            Console.WriteLine("\nd) Select description and invoice total, sort by invoice total:");
            foreach (var item in valueList)
                Console.WriteLine(item);

            //Select the InvoiceTotals in the range $200 to $500.
            var rangeTotals =
                from item in valueList
                where item.InvoiceTotal >= 200 && item.InvoiceTotal <= 500
                select item;

            // Print Out InvoiceTotals in the range $200 to $500.
            Console.WriteLine("\ne) Invoice totals between $200.00 and $500.00: ");
            foreach (var item in rangeTotals)
                Console.WriteLine(item);
        }
    }
}

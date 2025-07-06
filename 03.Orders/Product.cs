/*
 * 03.Orders
 */

namespace _03.Orders
{
    class Product
    {
        //Product name
        public string? Name { get; set; }

        //Product price
        public decimal Price { get; set; }

        //Quantity
        public short Quantity { get; set; }

        //Get the price of the products
        public decimal GetTotal()
            => Quantity * Price;
    }
}

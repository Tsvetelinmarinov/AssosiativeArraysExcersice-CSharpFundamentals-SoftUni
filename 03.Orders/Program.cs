/*
 * 03.Orders
 */

namespace _03.Orders;

class Program
{
    static void Main()
    {
        List<Product> products = new();
        List<string> productDef = Console.ReadLine()!
            .Split()
            .ToList();

        while (productDef[0] != "buy")
        {
            Product currentProduct = new()
            {
                Name = productDef[0],
                Price = decimal.Parse(s: productDef[1]),
                Quantity = short.Parse(s: productDef[2])
            };

            if (!ContainsProduct(products, currentProduct))
            {
                products.Add(currentProduct);
            }
            else if (ContainsProduct(products, currentProduct))
            {
                int indexOfExisting = GetIndexOf(products, currentProduct);
                products[indexOfExisting].Quantity += currentProduct.Quantity;
                if (!products[indexOfExisting].Price.Equals(currentProduct.Price))
                {
                    products[indexOfExisting].Price = currentProduct.Price;
                }
            }

            productDef = Console.ReadLine()!
               .Split()
               .ToList();
        }

        products.ForEach(product => Console.WriteLine($"{product.Name} -> {product.GetTotal()}"));
    }

    static bool ContainsProduct(List<Product> productList, Product product)
    {
        foreach (Product item in productList)
        {
            if (item.Name!.Equals(product.Name))
            {
                return true;
            }
        }

        return false;
    }

    static int GetIndexOf(List<Product> productList, Product product)
    {
        for (int i = 0; i < productList.Count; ++i)
        {
            if (productList[i].Name!.Equals(product.Name))
            {
                return i;
            }
        }

        return -1;
    }
}
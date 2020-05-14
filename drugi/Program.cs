using System;
using System.Collections.Generic;

namespace drugi
{
    class Program
    {
        static void Main(string[] args)
        {
            var myProducts = new List<Product>() {
                new Product("prvi proizvod", 1.23),
                new Product("drugi proizvod", 4.56),
            };
            Box myBox = new Box(myProducts);
            Product myNewProduct = new Product("treci proizvod", 7.89);
            myBox.AddProduct(myNewProduct);
            IAbstractIterator iterator = myBox.GetIterator();
            Product toPrint;
            for (toPrint = iterator.First(); iterator.IsDone == false; toPrint = iterator.Next())
            {
                Console.WriteLine(toPrint.ToString()); 
            }

        }
    }
}

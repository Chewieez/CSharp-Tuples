using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>()
            {
            ("nails", 1.00, 10),
            ("wood", 7.00, 5),
            ("paint", 15.00, 9),
            ("paint brush", 5.00, 7),
            ("glue", 3.00, 4),
            ("pencil", 1.00, 25)
            };

            int totalQuantity = 0;
            double totalRevenue = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                totalQuantity += t.quantity;
                totalRevenue += t.amount;
            }
            Console.WriteLine($@"
            Items sold today: {totalQuantity}
            Total Revenue: ${totalRevenue}
            ");
        }
    }
}
 
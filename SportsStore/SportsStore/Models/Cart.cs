using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Cart
    {
        private List<CartLine> lineConnection = new List<CartLine>();
        public virtual void AddItem(Product product, int quantity)
        {
            CartLine line = lineConnection.Where(p => p.Product.ProductId == product.ProductId).FirstOrDefault();

            if(line == null)
            {
                lineConnection.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product)
        {
            lineConnection.RemoveAll(l => l.Product.ProductId == product.ProductId);
        }

        public virtual decimal ComputeTotalValue() => lineConnection.Sum(e => e.Product.Price * e.Quantity);
        public virtual void Clear() => lineConnection.Clear();
        public virtual IEnumerable<CartLine> Lines => lineConnection;
    }

    public class CartLine
    {
        public int CartLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}

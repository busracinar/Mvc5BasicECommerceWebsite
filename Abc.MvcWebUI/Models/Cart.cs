using Abc.MvcWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class Cart
    {
        private List<CartLine> _cardLines = new List<CartLine>();
        public List<CartLine> CardLines
        {
            get { return _cardLines; }
        }
        public void AddProduct(Product product, int quantity)
        {
            var line = _cardLines.FirstOrDefault(i => i.Product.ID == product.ID);
            if (line == null)
            {
                _cardLines.Add(new CartLine() { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void DeleteProduct ( Product product)
        {
            _cardLines.RemoveAll(i => i.Product.ID == product.ID);
        }
        public double Total()
        {
            return _cardLines.Sum(i => i.Product.Price * i.Quantity);
        }
        public void Clear()
        {
            _cardLines.Clear();
        }
    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
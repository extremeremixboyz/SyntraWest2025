using System;
using System.Collections.Generic;

namespace Winkelwagen
{
    internal class ShoppingCart
    {
        // Delegate met void-returntype en een Product-parameter
        public delegate void ProductAddedHandler(Product product);

        // Event op basis van de delegate
        public event ProductAddedHandler? ProductAdded;

        // Veld (met publieke getter) om het totaalbedrag bij te houden
        public decimal Total { get; private set; }

        // Optionele interne opslag van toegevoegde producten (niet strikt gevraagd, maar vaak nuttig)
        private readonly List<Product> _products = new();

        // Methode om een product toe te voegen, total bijwerken en event activeren
        public void AddProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));

            // Voeg toe aan interne lijst
            _products.Add(product);

            // Update totaal
            Total += product.Price;

            // Activeer het event (thread-safe patroon)
            var handler = ProductAdded;
            if (handler != null)
            {
                handler(product);
            }
        }
    }

    // Voorbeeld van een Product-klasse:
    public class Product
    {
        public string Naam { get; set; }
        public decimal price { get; set; }

        public Product(string naam, decimal Price)
        {
            Naam = naam;
            Price = price;
        }
    }
}

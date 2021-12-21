namespace DotNetCoreDemoWebApiApplication.Data
{
    using System;
    using System.Linq;
    using DotNetCoreDemoWebApiApplication.Models;

    public static class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            if (context == null)
            {
                return;
            }

            context.Database.EnsureCreated();

            var client = new Client();

            if (!context.Client.Any())
            {
                client.ClientId = 1;
                context.Client.Add(client);
                context.SaveChanges();
            }

            var authors = new Author[] {
                new Author() { AuthorId = 1, FirstName = "Snoop", MiddleNames = string.Empty, LastName = "Dogg" },
                new Author() { AuthorId = 2, FirstName = "Tomson", MiddleNames = string.Empty, LastName = "Highway" },
                new Author() { AuthorId = 3, FirstName = "George", MiddleNames = string.Empty, LastName = "Orwell" },
            };

            var products = new Product[] {
                new Book { ProductId = 1, Name = "From Crook to Cook - Hardcover",
                    Description = "Platinum Recipes from Tha Boss Dogg's Kitchen (Snoop Dogg Cookbook, Celebrity Cookbook with Soul Food Recipes) Hardcover – Illustrated, Oct. 23 2018",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/5160yyObJrL._SX417_BO1,204,203,200_.jpg",
                    Price = 24.71,
                    Authors = new Author[] { authors.ElementAt(0) },
                    Isbn = "1452179611", Title = "From Crook to Cook" },

                new Book { ProductId = 2, Name = "Permanent Astonishment: A Memoir - Hardcover",
                    Description = "Permanent Astonishment: A Memoir Hardcover – Sept. 28 2021",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/418cjMxS5uL._SX331_BO1,204,203,200_.jpg",
                    Price = 23.05,
                    Authors = new Author[] { authors.ElementAt(1) },
                    Isbn = "0385696205", Title = "Permanent Astonishment: A Memoir" },

                new Book { ProductId = 3, Name = "Kiss of the Fur Queen - Paperback",
                    Description = "Kiss of the Fur Queen Paperback – Sept. 14 1999",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/418a3sz-BxL._SX322_BO1,204,203,200_.jpg",
                    Price = 21.27,
                    Authors = new Author[] { authors.ElementAt(1) },
                    Isbn = "0385258801", Title = "Kiss of the Fur Queen" }
            };

            if (!context.Products.Any())
            {
                context.Products.AddRangeAsync(products);

                context.SaveChanges();
            }

            var cart = new ShoppingCart();

            if (!context.ShoppingCart.Any())
            {
                cart.Client = client;
                //cart.Products = products;

                context.ShoppingCart.Add(cart);
                context.SaveChanges();
            }

            if (!context.Order.Any())
            {
                var order = new Order()
                {
                    ShoppingCartId = cart.ShoppingCartId
                };

                context.Order.Add(order);
                context.SaveChanges();
            }

            Console.WriteLine("cart items");
            context.Products?.ToList().ForEach(x => Console.WriteLine("product: " + x.Name));
            context.Order?.ToList().ForEach(x => Console.WriteLine("order: " + x.OrderId));
            context.Authors?.ToList().ForEach(x => Console.WriteLine("author: " + x.LastName));
            context.Books?.ToList().ForEach(x => Console.WriteLine("book: " + x.Title));
        }
    }
}

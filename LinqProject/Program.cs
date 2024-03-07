namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ (Language Integrated Query — Dil ile Tümleşik Sorgu)

            List<Category> categories = new List<Category>
            {
                new Category(){CategoryId = 1, CatogoryName = "Bilgisayar"},
                new Category(){CategoryId = 2,CatogoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                  new Product(){ProductId = 1,ProductName = "Acer Laptop", QuantityPerUnit ="32 GB", UnitPrice = 10000,UnitInStock = 10 },
                  new Product(){ProductId = 2,ProductName = "Asus Laptop", QuantityPerUnit ="16 GB", UnitPrice = 8000,UnitInStock = 15 },
                  new Product(){ProductId = 3,ProductName = "HP Laptop", QuantityPerUnit ="8 GB", UnitPrice = 6000,UnitInStock = 8 },
                  new Product(){ProductId = 4,ProductName = "Samsung Telefon", QuantityPerUnit ="4 GB", UnitPrice = 2000 ,UnitInStock = 15 },
                  new Product(){ProductId = 5,ProductName = "Apple Telefon", QuantityPerUnit ="4 GB", UnitPrice = 8000,UnitInStock =0 }
            };

            Console.WriteLine("Algoritmik ------------------------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 5)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("Linq------------------------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 5);
            foreach (var product1 in result)
            {
                Console.WriteLine(product1.ProductName);
            }

        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 5)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 5).ToList(); //yeni liste oluşturur
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CatogoryName { get; set; }
    }
}

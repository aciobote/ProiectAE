namespace Seminar_2.Models
{
    public class Product
    {
        public Product()
        {
            Name = string.Empty;
            Description = string.Empty;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string? ImagePath { get; set; }

        public static List<Product> GetAll()
        {
            var products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "CUTIE 9 MACARONS SWEET MOMENTS", Description = "INGREDIENTE: Zahar pudra, faina de migdale, cacao Callebaut, albus de ou, umpluturi cu ganache de ciocolata belgiana diverse arome.\r\n", ImagePath = "img/praji1.PNG", IsAvailable = true, Price = 10 });
            products.Add(new Product { Id = 2, Name = "PAHAR DESERT CHEESECAKE", Description = "INGREDIENTE: Blat de biscuiți, cremă fină de brânză, frișcă, coajă de portocale, zahăr, glazură, sos de fructe\r\n", ImagePath = "img/praji2.PNG", IsAvailable = true, Price = 6 });
            products.Add(new Product { Id = 3, Name = "MINI PAHAR CHEESECAKE CU FRUCTE DE PADURE", Description = "INGREDIENTE: Blat de biscuiți, cremă fină de brânză, frișcă, coajă de portocale, zahăr, glazură, sos de fructe\r\n", ImagePath = "img/praji3.PNG", IsAvailable = true, Price = 7});
            products.Add(new Product { Id = 4, Name = "BERRIES CAKE", Description = "INGREDIENTE: blat de cacao, sirop din esenta de vanilie si rom, mousse de ciocolata alba, mousse fructe de padure, decor de fructe proaspete.\r\n", ImagePath = "img/praji4.PNG", IsAvailable = true, Price = 5 });

            return products;
        }
    }
}

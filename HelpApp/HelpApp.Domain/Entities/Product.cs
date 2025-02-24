namespace HelpApp.Domain.Entities
{
    public class Product
    {
        #region Atributos
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Descripcion{ get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public string CategoryId{ get; set; }
        #endregion

        #region Construtores
        public Product(string name, string description, decimal price, int stock, string image)
        {
            Name = name;
            Descripcion = description;
            Price = price;
            Stock = stock;
            Image = image;
        }

        public Category category { get; set; }
        #endregion
    }
}

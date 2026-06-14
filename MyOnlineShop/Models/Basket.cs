namespace MyOnlineShop.Models
{
    public class Basket
    {
        public Guid Id { get; set; }
        public string NameProduct { get; set; }
        public int CountProduct {  get; set; }
        public int CostProduct {  get; set; }

        public Basket(string nameProduct,int countProduct,int costProduct)
        {
            Id= Guid.NewGuid();
            NameProduct = nameProduct; 
            CountProduct = countProduct;
            CostProduct = costProduct;
        }
    }
}

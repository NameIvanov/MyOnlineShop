namespace MyOnlineShop.Models
{
    public class Basket
    {
        public string NameProduct { get; set; }
        public int CountProduct {  get; set; }
        public int CostProduct {  get; set; }

        public Basket(string nameProduct,int countProduct,int costProduct)
        {
            NameProduct = nameProduct; 
            CountProduct = countProduct;
            CostProduct = costProduct;
        }
    }
}

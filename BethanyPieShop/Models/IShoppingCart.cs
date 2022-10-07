namespace BethanyPieShop.Models
{
    public interface IShoppingCart
    {
        void AddToCart(Pie pie);
        int RemoveFromCart(Pie pie);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        Decimal GetShoppingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}

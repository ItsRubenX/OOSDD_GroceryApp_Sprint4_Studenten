
namespace Grocery.Core.Models
{
    public class BoughtProducts
    {
        public Product Product { get; set; }
        public Client Client { get; set; }
        public string ClientName { get; set; }
        public GroceryList GroceryList { get; set; }
        public BoughtProducts(Client client, GroceryList groceryList, Product product)
        {
            Client = client;
            ClientName = client.Name;
            GroceryList = groceryList;
            Product = product;
        }
    }
}

namespace SignifydCore.Client.Model
{
    public class Product
    {
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public bool ItemIsDigital { get; set; }
        public string ItemCategory { get; set; }
        public string ItemSubCategory { get; set; }
        public string ItemUrl { get; set; }
        public string ItemImage { get; set; }
        public int ItemQuantity { get; set; }
        public double ItemPrice { get; set; }
        public int ItemWeight { get; set; }
    }
}
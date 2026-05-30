namespace PharmacyProjectPhase2.Models
{
    public class Medicines
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public int Quantity { get; set; }
        public double  Price { get; set; }
        public DateTime ExpiryDate { get; set; }

    }
}

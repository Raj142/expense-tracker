namespace ExpenseTracker.API.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Type { get; set; } = "expense"; // "income" or "expense"
        public DateTime Date { get; set; }
    }
}
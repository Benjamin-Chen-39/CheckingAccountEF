namespace lib
{
    public class Log
    {
        public int LogId { get; set; }  // primary key
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public CheckingAccount CheckingAccount { get; set; } // allows you to reference the CheckingAccount object associated with this Log
    }
}
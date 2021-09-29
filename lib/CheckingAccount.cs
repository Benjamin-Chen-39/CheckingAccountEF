using System;
using System.Collections.Generic;

namespace lib
{
    public class CheckingAccount
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public List<Log> Logs { get; } = new List<Log>();

    }
}
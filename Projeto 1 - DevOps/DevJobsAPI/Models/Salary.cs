using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Salary
    {
        public int Id { get; set; }
        public decimal Amount { get; set; } 
        public string Currency { get; set; } 
        public string Frequency { get; set; } 
    
    }
}
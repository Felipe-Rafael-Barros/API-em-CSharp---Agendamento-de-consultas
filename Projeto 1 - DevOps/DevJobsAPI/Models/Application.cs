using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Application
    {
        public int Id { get; set; } 
        public int JobId { get; set; } 
        public int CandidateId { get; set; } 
        public DateTime ApplicationDate { get; set; } 
        public string Status { get; set; } 
    

    }
}
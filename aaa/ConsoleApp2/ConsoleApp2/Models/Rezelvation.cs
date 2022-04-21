using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    internal class Rezelvation
    {
       public int Id  { get; set; }
        public int StadionId { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

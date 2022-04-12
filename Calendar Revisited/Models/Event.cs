using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Revisited.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string EventName { get; set; }
        public string Location { get; set; }
        public int Duration { get; set; }
        public DateTime Date { get; set; }
    }
}

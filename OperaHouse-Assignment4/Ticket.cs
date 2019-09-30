using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouse_Assignment5
{
    public class Ticket
    {
        public int SeatNumber {get;set;}
        public double Price { get; set; }
        public bool Sold { get; set; }

        public Ticket(int seatNumber, double price)
        {
            this.SeatNumber = seatNumber;
            this.Price = price;
            this.Sold = false;
        }
        public override string ToString()
        {
            return string.Format("#{0} {1:c}. Sold: {2}", SeatNumber, Price, (Sold) ? "Yes" : "No");

        }
    }
}

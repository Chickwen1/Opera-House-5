using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperaHouse_Assignment5
{
    public partial class TicketSales : Form
    {
        private Event theEvent;
        public TicketSales(Event anEvent)
        {
            this.theEvent = anEvent;
            InitializeComponent();
            lstTickets.Items.AddRange(theEvent.tickets.ToArray());
        }

        private void btnSell_Click_1(object sender, EventArgs e)
        {
            int numTickets = 0;
            int.TryParse(txtNumTickets.Text, out numTickets);
            theEvent.SellTickets(numTickets);
            lstTickets.Items.Clear();
            lstTickets.Items.AddRange(theEvent.tickets.ToArray());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            List<int> ticketNums = new List<int>();

            foreach (Ticket t in lstTickets.SelectedItems)
                ticketNums.Add(t.SeatNumber);
            theEvent.ReturnTickets(ticketNums);
            lstTickets.Items.Clear();
            lstTickets.Items.AddRange(theEvent.tickets.ToArray());
        }
    }
}

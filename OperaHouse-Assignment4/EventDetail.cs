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
    public partial class EventDetail : Form
    {
        EventListForm parent;

        public EventDetail(EventListForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            int duration = 0;
            int.TryParse(txtDuration.Text, out duration);
            Performer p = new Performer(txtPerformerName.Text, 0);
            DateTime eventDate = dtpDate.Value;
            DateTime eventTime = dtpTime.Value;
            DateTime comboTime = new DateTime(eventDate.Year, eventDate.Month, eventDate.Day, eventTime.Hour, eventTime.Minute, 0);
            int numTickets = 0;
            int.TryParse(txtNumTickets.Text, out numTickets);
            double ticketPrice = 0;
            double.TryParse(txtPrice.Text, out ticketPrice);

            parent.SaveEvent(new Event("", title, p, numTickets, ticketPrice, comboTime, duration, chkConcession.Checked));
            this.Close();
        }
    }
}

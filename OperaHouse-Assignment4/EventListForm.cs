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
    public partial class EventListForm : Form
    {
        private EventList events;
        public List<Event> displayedEvents;
        //private List<Event> openShows;
        private Event selectedEvent;

		public EventListForm(EventList events)
        {
            InitializeComponent();
            this.events = events;
            events.SortByDate();
            displayedEvents = events.Events;
            displayEvents();
            populatePerformer();
        }
		public void displayEvents()
		{
			lstEvents.Items.Clear();
			lstEvents.Items.AddRange(displayedEvents.ToArray());
		}
		private void populatePerformer()
        {
            HashSet<Performer> performers = new HashSet<Performer>();

            foreach (Event e in displayedEvents)
            {
                performers.Add(e.Performer);
            }
            cmbPerformers.Items.AddRange(performers.ToArray());
        }
        public void UpdateForm()
        {
			if (selectedEvent != null)
			{
				txtTitle.Text = selectedEvent.Title;
				lblPerformer.Text = selectedEvent.Performer.ToString();
				lblTickets.Text = selectedEvent.NumAvailableTickets.ToString();
				dtpDate.Value = selectedEvent.EventTime;
				dtpTime.Value = selectedEvent.EventTime;
				grpEventDetail.Visible = true;
			}
			else
				displayedEvents = events.Events;
			if (rbtDate.Checked)
                events.SortByDate();
            else if (rbtTitle.Checked)
                events.SortByTitle();
           

            string performerName = null;
            if (cmbPerformers.SelectedIndex >= 0)
            {
                performerName = cmbPerformers.SelectedItem.ToString();

                displayedEvents = events.SearchByPerformer(performerName);
            }
			else
				displayedEvents = events.Events;
			displayEvents();
		}

        public void SaveEvent(Event e)
        {
            events.AddEvent(e);
            UpdateForm();
            populatePerformer();
        }

        public void DeleteEvent(Event e)
        {
            events.RemoveEvent(e);
            UpdateForm();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            new EventDetail(this).Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            displayedEvents = events.Events;
            events.Sort();
            cmbPerformers.SelectedIndex = -1;
            chkOpenShows.Checked = false;
            rbtDate.Checked = false;
            rbtTitle.Checked = false;
            grpEventDetail.Visible = false;
            selectedEvent = null;
            displayEvents();
        }

        private void rbtDate_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void rbtTitle_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void chkOpenShows_CheckedChanged_1(object sender, EventArgs e)
        {
            if(chkOpenShows.Checked == true)
            {
                lstEvents.Items.Clear();
                displayedEvents = events.OpenShows();
                displayEvents();
            }
            else if(chkOpenShows.Checked == false)
            {
                lstEvents.Items.Clear();
                displayedEvents = events.Events;
                displayEvents();
            }
            
        }

        private void cmbPerformers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void btnSellTicket_Click_1(object sender, EventArgs e)
        {
            if (selectedEvent != null)
            {
                TicketSales sellTickets = new TicketSales(selectedEvent);
                sellTickets.Visible = true;
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedEvent != null)
            {
                selectedEvent.Title = txtTitle.Text;
                DateTime eventDate = dtpDate.Value;
                DateTime eventTime = dtpTime.Value;

                selectedEvent.EventTime = new DateTime(eventDate.Year, eventDate.Month, eventDate.Day, eventTime.Hour, eventTime.Minute, 0);
                UpdateForm();
            }
        }

        private void lstEvents_SelectedIndexChanged_1(object sender, EventArgs e)
        {
			if (lstEvents.SelectedIndex >= 0)
				selectedEvent = (Event)lstEvents.SelectedItem;
			else
				selectedEvent = null;
			UpdateForm();
		}

        private void grpEventDetail_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new Delete(this, events).Visible = true;
        }

		private void EventListForm_Load(object sender, EventArgs e)
		{

		}
	}
    
}

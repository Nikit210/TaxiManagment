using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiManagment
{
    public partial class FilterForm : Form
    {
        bool m_setFilter;
        public FilterForm()
        {
            InitializeComponent();
            m_setFilter = false;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.filter32;
            Filter flt = Program.m_filter;

            clientPhone_textBox.Text = flt.client_phone;
            driver_textBox.Text = flt.driver_name;
            placeFrom_textBox.Text = flt.place_from;
            placeTo_textBox.Text = flt.place_to;

        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            Filter flt = Program.m_filter;

            flt.client_phone = clientPhone_textBox.Text;
            flt.driver_name = driver_textBox.Text;
            flt.place_from = placeFrom_textBox.Text;
            flt.place_to = placeTo_textBox.Text;
            m_setFilter = true;
            Close();
        }

        private void reject_button_Click(object sender, EventArgs e)
        {
            Filter flt = Program.m_filter;

            flt.Clear();
            clientPhone_textBox.Text = flt.client_phone;
            driver_textBox.Text = flt.driver_name;
            placeFrom_textBox.Text = flt.place_from;
            placeTo_textBox.Text = flt.place_to;

            m_setFilter = true;
            Close();
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            DialogResult = m_setFilter ? DialogResult.OK : DialogResult.Cancel;
        }
    }
}

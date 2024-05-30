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
    public partial class DriverChoiceForm : Form
    {
        private DriverViewRecord m_driver;
        public DriverViewRecord freeDriver { get { return m_driver;} }
        public DriverChoiceForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.taxi_driver32;
            var lst = await Program.m_helper.GetFreeDriversLists();
            drivers_dataGridView.DataSource = lst;
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            var row = drivers_dataGridView.CurrentRow; 
            if (row == null) { DialogResult = DialogResult.Cancel; return; }
            m_driver = new DriverViewRecord
            {
                id = Convert.ToInt64(row.Cells["id"].Value),
                driver_name = row.Cells["driver_name"].Value.ToString(),
                driver_phone = row.Cells["driver_phone"].Value.ToString(),
                car = row.Cells["car"].Value.ToString()
            };
        }
    }
}

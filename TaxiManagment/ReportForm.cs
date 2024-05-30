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
    public partial class ReportForm : Form
    {
        Filter m_filter;
        public ReportForm()
        {
            InitializeComponent();
            m_filter = new Filter();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.report32;
            bool isAdmin = Program.m_currentUser.admin;
            m_filter.responsible = !isAdmin ? Program.m_currentUser.name : string.Empty;
            responsible_label.Visible = isAdmin;
            responsible_textBox.Visible = isAdmin;

            var lst = await Program.m_helper.GetOrdersLists(m_filter);
            var lstf = lst.Where(el => el.order_date >= dateFrom_dateTimePicker.Value && el.order_date <= dateTo_dateTimePicker.Value).ToList();
            orders_dataGridView.DataSource = lstf;
            SetSum(lstf);

        }
        /// <summary>
        /// Применить фильтры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void filter_button_Click(object sender, EventArgs e)
        {
            m_filter.driver_name = driver_textBox.Text.Trim();
            m_filter.client_phone = clientPhone_textBox.Text.Trim();
            m_filter.place_from = placeFrom_textBox.Text.Trim();
            m_filter.place_to = placeTo_textBox.Text.Trim();
            m_filter.status = status_textBox.Text.Trim();
            if(Program.m_currentUser.admin)
                m_filter.responsible =  responsible_textBox.Text.Trim();

            var lst = await Program.m_helper.GetOrdersLists(m_filter);
            var lstf = lst.Where(el => el.order_date >= dateFrom_dateTimePicker.Value && el.order_date <= dateTo_dateTimePicker.Value).ToList();
            orders_dataGridView.DataSource = lstf;
            SetSum(lstf);

        }
        /// <summary>
        /// Рассчитать сумму по заказам
        /// </summary>
        /// <param name="lst"></param>
        private void SetSum(List<OrderViewRecord> lst)
        {
            double sum = lst.Sum(el => el.price);
            sum_label.Text = $"Сумма по заказам: {sum} руб.";
        }
        /// <summary>
        /// Показать карточку заказам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showCard_button_Click(object sender, EventArgs e)
        {
            var row = orders_dataGridView.CurrentRow;
            if (row != null)
            {
                long id = Convert.ToInt64(row.Cells["id"].Value);
                OrderCardForm frm = new OrderCardForm(id, false);
                frm.ShowDialog();
            }

        }
        /// <summary>
        /// Применить фильтры, нажимая ENTER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPressKey(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
                filter_button_Click(sender, e);
        }
    }
}

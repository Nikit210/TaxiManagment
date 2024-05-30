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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Первоначальная загрузка главной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.car32;

            var lst = await Program.m_helper.GetOrdersLists();
            bool isAdmin = Program.m_currentUser.admin;
            orders_dataGridView.DataSource = isAdmin ? lst : lst.Where(el => el.iduser == Program.m_currentUser.id).ToList();

            reference_ToolStripMenuItem.Visible = isAdmin;
            users_StripMenuItem.Visible = isAdmin;
        }
        /// <summary>
        /// Закрытие главной формы. Программа прекращает работу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Program.m_helper.Dispose();
            Application.Exit();
        }
        /// <summary>
        /// Управление справочником транспортных средств
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cars_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarsForm frm = new CarsForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Управление справочником водителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drivers_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriversForm frm = new DriversForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Управление списком пользователей. Доступно пользователю с полномочиями администратора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void users_StripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.ShowDialog();
        }
        /// <summary>
        /// Добавить заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addOrder_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderCardForm frm = new OrderCardForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var lst = await Program.m_helper.GetOrdersLists(Program.m_filter);
                orders_dataGridView.DataSource = Program.m_currentUser.admin ? lst : 
                    lst.Where(el => el.iduser == Program.m_currentUser.id).ToList();
            }
        }
        /// <summary>
        /// Изменить данные по закзазу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void changeOrder_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = orders_dataGridView.CurrentRow;
            if(row != null) 
            {
                long id = Convert.ToInt64(row.Cells["id"].Value);
                OrderCardForm frm = new OrderCardForm(id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var lst = await Program.m_helper.GetOrdersLists(Program.m_filter);
                    orders_dataGridView.DataSource = Program.m_currentUser.admin ? lst :
                        lst.Where(el => el.iduser == Program.m_currentUser.id).ToList();
                }

            }
        }
        /// <summary>
        /// Удалить заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void deleteOrder_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранную запись о заказе?", "Внимание!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;
            var row = orders_dataGridView.CurrentRow;
            if (row != null)
            {
                long id = Convert.ToInt64(row.Cells["id"].Value);
                if (Program.m_helper.DeleteOrder(id) > 0)
                {
                    var lst = await Program.m_helper.GetOrdersLists(Program.m_filter);
                    orders_dataGridView.DataSource = Program.m_currentUser.admin ? lst :
                        lst.Where(el => el.iduser == Program.m_currentUser.id).ToList();
                }

            }

        }

        /// <summary>
        /// Показать карточку заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showOrderCard_ToolStripMenuItem_Click(object sender, EventArgs e)
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
        ///  Установка фильтров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void filter_button_Click(object sender, EventArgs e)
        {
            FilterForm frm = new FilterForm();
            if(frm.ShowDialog() == DialogResult.OK) 
            {
                var lst = await Program.m_helper.GetOrdersLists(Program.m_filter);
                orders_dataGridView.DataSource = Program.m_currentUser.admin ? lst :
                    lst.Where(el => el.iduser == Program.m_currentUser.id).ToList();

            }
        }

        /// <summary>
        /// Вывод отчёта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ordersByPeriod_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.ShowDialog();
        }

        /// <summary>
        /// Изменение своего пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changePassword_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm frm = new ChangePasswordForm();
            frm.ShowDialog();
        }
    }
}

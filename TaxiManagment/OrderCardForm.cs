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
    public partial class OrderCardForm : Form
    {
        const string empty_phone = "+7 (   )    -  -";
        long m_id;
        long m_driverId;
        Order m_order;
        bool m_editMode;
        public OrderCardForm(long id = 0, bool edimode = true)
        {
            InitializeComponent();
            m_id = id;
            m_driverId = 0;
            m_editMode = edimode;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.order32;
            if(m_id > 0)
            {
                m_order = Program.m_helper.GetOrderById(m_id);
                if(m_order != null)
                {
                    orderdate_dateTimePicker.Value = m_order.order_date;
                    phone_maskedTextBox.Text = m_order.client_phone;
                    placeFrom_textBox.Text = m_order.place_from;
                    placeTo_textBox.Text = m_order.place_to;
                    if(m_order.iddriver.HasValue)
                    {
                        DriverViewRecord drv = Program.m_helper.GetDriverById(m_order.iddriver.Value);
                        if (drv != null)
                        {
                            driver_textBox.Text = drv.ToString();
                            m_driverId = drv.id;
                        }
                    }
                    price_textBox.Text = m_order.price.ToString();
                    status_comboBox.SelectedIndex = m_order.status;
                }
            }
            else
            { 
                status_comboBox.SelectedIndex = 0;
                m_order = new Order();
            }

            responsible_label.Text = $"Ответственный: {Program.m_currentUser.name}";

            if(!m_editMode)
            {
                accept_button.Visible = false;
                reject_button.Text = "Закрыть";
                choiceDriver_button.Visible = false;
            }

        }

        private void reject_button_Click(object sender, EventArgs e)
        {
            if(m_editMode && m_driverId > 0)
                Program.m_helper.FreeDriver(m_driverId);
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            if (m_editMode && m_driverId > 0)
                Program.m_helper.FreeDriver(m_driverId);

            string pfrom = placeFrom_textBox.Text;
            if (string.IsNullOrEmpty(pfrom.Trim()))
            {
                Program.ShowErrorMessage("Не задан пункт отправления");
                DialogResult = DialogResult.Cancel;
                return;
            }
            m_order.place_from = pfrom;

            string pto = placeTo_textBox.Text;
            if (string.IsNullOrEmpty(pto.Trim()))
            {
                Program.ShowErrorMessage("Не задан пункт назначения");
                DialogResult = DialogResult.Cancel;
                return;
            }
            m_order.place_to = pto;

            string clphone = phone_maskedTextBox.Text;
            if (clphone == empty_phone)
            {
                Program.ShowErrorMessage("Не задан номер телефона заказчика");
                DialogResult = DialogResult.Cancel;
                return;
            }
            m_order.client_phone = clphone;

            m_order.order_date = orderdate_dateTimePicker.Value;

            if (m_driverId > 0)
                m_order.iddriver = m_driverId;
            else
                m_order.iddriver = null;

            double price = 0.0;
            try
            {
                price = Convert.ToDouble(price_textBox.Text);
            }
            catch (Exception) 
            {
                Program.ShowErrorMessage("Ошибка задания значения стоимости заказа");
                DialogResult = DialogResult.Cancel;
                return;
            }
            m_order.price = price;

            m_order.status = status_comboBox.SelectedIndex;

            m_order.iduser = Program.m_currentUser.id;

            m_order.id = m_id;
            int recs = -1;
            recs = m_id > 0 ? Program.m_helper.UpdateOrder(m_order) : Program.m_helper.AddOrder(m_order);
            if(recs < 1)
            {
                Program.DBErrorMessage();
                DialogResult = DialogResult.Cancel;
            }

        }
        /// <summary>
        /// Выбор свободного водителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void choiceDriver_button_Click(object sender, EventArgs e)
        {
            DriverChoiceForm frm = new DriverChoiceForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                if(m_driverId > 0)
                    Program.m_helper.FreeDriver(m_driverId);
                var drv = frm.freeDriver;
                driver_textBox.Text = drv.ToString();
                m_driverId = drv.id;
                Program.m_helper.ReserveDriver(m_driverId);
            }
        }
    }
}

using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiManagment
{
    public partial class DriversForm : Form
    {
        const string empty_phone = "+7 (   )    -  -";
        List<Car> m_carList;
        long m_idx;
        public DriversForm()
        {
            InitializeComponent();
            m_idx = 0;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.taxi_driver32;

            m_carList = await Program.m_helper.GetCarsLists();
            vehicle_comboBox.DataSource = m_carList;

            var lst = await Program.m_helper.GetDriversLists();
            name_comboBox.DataSource = lst;
            if(!lst.IsNullOrEmpty())
            { 
                name_comboBox.SelectedIndex = 0;   
            }
        }

        private void OnDriverNameChanged(object sender, EventArgs e)
        {
            int idx = name_comboBox.SelectedIndex;
            if (idx < 0) return;
            Driver driver = name_comboBox.Items[idx] as Driver;
            if (driver == null) return;
            m_idx = driver.id;
            phone_maskedTextBox.Text = driver.phone;
            telegram_textBox.Text = driver.telegram;
            if(!m_carList.IsNullOrEmpty())
            {
                idx = m_carList.FindIndex(el => el.number == driver.auto_number);
                if (idx >= 0)
                    vehicle_comboBox.SelectedIndex=idx;
            }
        }

        private async void add_button_Click(object sender, EventArgs e)
        {
            string _phone = phone_maskedTextBox.Text;
            if(_phone == empty_phone)
            {
                Program.ShowErrorMessage("Нужно задать номер телефона водителя");
                return;
            }

            string _name = name_comboBox.Text;
            if(string.IsNullOrEmpty(_name.Trim()))
            { 
                Program.ShowErrorMessage("Нужно задать номер телефона водителя");
                return;
            }

            string tel = telegram_textBox.Text;  
            int idx = vehicle_comboBox.SelectedIndex;
            if(idx < 0) return;
            Car car = vehicle_comboBox.Items[idx] as Car;
            if (car == null) return;

            // проверка, прикреплено ли ТС к водителю
            var lstc = await Program.m_helper.GetCarsLists(true);
            if (lstc.Any(el => el.number == car.number))
            {
                Program.ShowErrorMessage($"Транспортное средство {car.ToString()} закреплено за водителем");
                return;
            }

            Driver drv = new Driver
            {
                id = 0,
                name = _name,
                phone = _phone,
                telegram = tel,
                auto_number = car.number
            };

            if (Program.m_helper.AddDriver(drv) < 1)
                Program.DBErrorMessage();
            else 
            {
                var lst = await Program.m_helper.GetDriversLists();
                name_comboBox.DataSource = lst;
                if (!lst.IsNullOrEmpty())
                {
                    idx = lst.FindIndex(el => el.name == _name);
                    if (idx >= 0)
                        name_comboBox.SelectedIndex = idx;
                }

            }
        }

        private async void edit_button_Click(object sender, EventArgs e)
        {
            string _phone = phone_maskedTextBox.Text;
            if (_phone == empty_phone)
            {
                Program.ShowErrorMessage("Нужно задать номер телефона водителя");
                return;
            }

            string _name = name_comboBox.Text;
            if (string.IsNullOrEmpty(_name.Trim()))
            {
                Program.ShowErrorMessage("Нужно задать номер телефона водителя");
                return;
            }

            string tel = telegram_textBox.Text;

            int idx = vehicle_comboBox.SelectedIndex;
            if (idx < 0) return;
            Car car = vehicle_comboBox.Items[idx] as Car;
            if (car == null) return;

            // проверка, прикреплено ли ТС к водителю
            var lstc = await Program.m_helper.GetCarsLists(true);
            if(lstc.Any(el => el.number == car.number))
            {
                Program.ShowErrorMessage($"Транспортное средство {car.ToString()} закреплено за водителем");
                return;
            }

            Driver drv = new Driver();
            drv.id = m_idx;
            drv.name = _name;
            drv.phone = _phone;
            drv.telegram = tel;
            drv.auto_number = car.number;

            if (Program.m_helper.UpdateDriver(drv) < 1)
                Program.DBErrorMessage();
            else
            {
                var lst = await Program.m_helper.GetDriversLists();
                name_comboBox.DataSource = lst;
                if (!lst.IsNullOrEmpty())
                {
                    idx = lst.FindIndex(el => el.name == _name);
                    if (idx >= 0)
                        name_comboBox.SelectedIndex = idx;
                }

            }

        }

        private async void delete_button_Click(object sender, EventArgs e)
        {
            if (Program.m_helper.DeleteDriver(m_idx) < 1)
                Program.DBErrorMessage();
            else
            {
                var lst = await Program.m_helper.GetDriversLists();
                name_comboBox.DataSource = lst;
                if (!lst.IsNullOrEmpty())
                {
                    name_comboBox.SelectedIndex = 0;
                }

            }

        }
    }
}

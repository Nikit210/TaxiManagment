using Microsoft.IdentityModel.Tokens;
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
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.car32;
            var lst = await Program.m_helper.GetCarsLists();
            vehicle_comboBox.DataSource = lst;
            if(!lst.IsNullOrEmpty())
                vehicle_comboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Выбор ТС из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCarInListChanged(object sender, EventArgs e)
        {
            int idx = vehicle_comboBox.SelectedIndex;
            if(idx < 0) return;
            Car car = vehicle_comboBox.Items[idx] as Car;
            if(car != null ) 
            {
                number_maskedTextBox.Text = car.number;
                mark_textBox.Text = car.model;
                idx = color_comboBox.FindString(car.color);
                if( idx < 0 ) 
                    color_comboBox.Text = car.color;
                else
                    color_comboBox.SelectedIndex = idx;

            }
        }

        private async void add_button_Click(object sender, EventArgs e)
        {
            string _number = number_maskedTextBox.Text;
            if(string.IsNullOrEmpty(_number) )
            {
                Program.ShowErrorMessage("Не задан номер транспортного средства");
                return;
            }

            string _model = mark_textBox.Text;
            if (string.IsNullOrEmpty(_model.Trim()))
            {
                Program.ShowErrorMessage("Не задана марка авто");
                return;
            }

            string _color = color_comboBox.Text;

            Car car = new Car
            {
                number = _number,
                model = _model,
                color = _color
            };

            if (Program.m_helper.AddCar(car) < 1)
                Program.DBErrorMessage();
            else 
            {
                var lst = await Program.m_helper.GetCarsLists();
                vehicle_comboBox.DataSource = lst;
               
                if (!lst.IsNullOrEmpty())
                {
                    int idx = lst.FindIndex( c => c.number == _number );
                    if( idx >= 0 )
                        vehicle_comboBox.SelectedIndex = idx; 
                }

            }

        }

        private async void edit_button_Click(object sender, EventArgs e)
        {
            Car car = vehicle_comboBox.SelectedItem as Car;
            if (car == null) return;
            string old_num = car.number;

            string _number = number_maskedTextBox.Text;
            if (string.IsNullOrEmpty(_number))
            {
                Program.ShowErrorMessage("Не задан номер транспортного средства");
                return;
            }

            string _model = mark_textBox.Text;
            if (string.IsNullOrEmpty(_model.Trim()))
            {
                Program.ShowErrorMessage("Не задана марка авто");
                return;
            }

            string _color = color_comboBox.Text;

            car = new Car
            {
                number = _number,
                model = _model,
                color = _color
            };

            if (Program.m_helper.UpdateCar(car, old_num) < 1)
                Program.DBErrorMessage();
            else
            {
                var lst = await Program.m_helper.GetCarsLists();
                vehicle_comboBox.DataSource = lst;

                if (!lst.IsNullOrEmpty())
                {
                    int idx = lst.FindIndex(c => c.number == _number);
                    if (idx >= 0)
                        vehicle_comboBox.SelectedIndex = idx;
                }

            }

        }

        private async void delete_button_Click(object sender, EventArgs e)
        {
            Car car = vehicle_comboBox.SelectedItem as Car;
            if (car == null) return;
            string old_num = car.number;

            if (Program.m_helper.DeleteCar(old_num) < 1)
                Program.DBErrorMessage();
            else
            {
                var lst = await Program.m_helper.GetCarsLists();
                vehicle_comboBox.DataSource = lst;

                if (!lst.IsNullOrEmpty())
                {
                    vehicle_comboBox.SelectedIndex = 0;
                }

            }

        }
    }
}

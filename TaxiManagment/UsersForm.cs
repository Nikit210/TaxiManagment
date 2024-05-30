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
    public partial class UsersForm : Form
    {
        long m_idx;
        public UsersForm()
        {
            InitializeComponent();
            m_idx = 0;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.user;
            var lst = await Program.m_helper.GetUsersLists();
            name_comboBox.DataSource = lst;
        }

        private void OnChangeUser(object sender, EventArgs e)
        {
            int idx = name_comboBox.SelectedIndex;
            if (idx < 0) return;
            User usr = name_comboBox.Items[idx] as User;
            m_idx = usr.id;
            password_textBox.Text = usr.password;
            isadmin_checkBox.Checked = usr.admin;
        }

        private async void add_button_Click(object sender, EventArgs e)
        {
            string _name = name_comboBox.Text;
            if (string.IsNullOrEmpty(_name.Trim()))
            {
                Program.ShowErrorMessage("Нужно задать ФИО пользователя");
                return;
            }

            User usr = new User
            {
                id = 0,
                name = _name.Trim(),
                password = password_textBox.Text.Trim(),
                admin = isadmin_checkBox.Checked
            };
            if (Program.m_helper.AddUser(usr) < 1)
                Program.DBErrorMessage();
            else
            {
                var lst = await Program.m_helper.GetUsersLists();
                name_comboBox.DataSource = lst;
                if(!lst.IsNullOrEmpty())
                {
                    int idx = lst.FindIndex(el => el.name == _name);
                    if(idx >= 0)
                        name_comboBox.SelectedIndex = idx; 
                }
            }

        }

        private async void edit_button_Click(object sender, EventArgs e)
        {
            string _name = name_comboBox.Text;
            if (string.IsNullOrEmpty(_name.Trim()))
            {
                Program.ShowErrorMessage("Нужно задать ФИО пользователя");
                return;
            }

            User usr = new User
            {
                id = m_idx,
                name = _name.Trim(),
                password = password_textBox.Text.Trim(),
                admin = isadmin_checkBox.Checked
            };
            if (Program.m_helper.UpdateUser(usr) < 1)
                Program.DBErrorMessage();
            else
            {
                var lst = await Program.m_helper.GetUsersLists();
                name_comboBox.DataSource = lst;
                if (!lst.IsNullOrEmpty())
                {
                    int idx = lst.FindIndex(el => el.name == _name);
                    if (idx >= 0)
                        name_comboBox.SelectedIndex = idx;
                }
            }

        }

        private async void delete_button_Click(object sender, EventArgs e)
        {
            if (Program.m_helper.DeleteUser(m_idx) < 1)
                Program.DBErrorMessage();
            else
            {
                var lst = await Program.m_helper.GetUsersLists();
                name_comboBox.DataSource = lst;
                if (!lst.IsNullOrEmpty())
                {
                  name_comboBox.SelectedIndex = 0;
                }
            }

        }
    }
}

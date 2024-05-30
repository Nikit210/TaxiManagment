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
    public partial class AutorizationForm : Form
    {
        public int m_count;
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.password32;
            List<User> lst = await Program.m_helper.GetUsers();
            usersComboBox.DataSource = lst;

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string pwd = passwordTextBox.Text;
            User suser = usersComboBox.SelectedItem as User;
            if (suser == null) return;

            string msg = string.Empty;
            m_count++;
            if (pwd != suser.password)
            {
                if (m_count >= 3)
                    msg = $"Пользователь {suser.name} не авторизован в системе.";
                else
                    msg = $"Неверный пароль";
                MessageBox.Show(msg);
                if (m_count >= 3)
                {
                    Program.m_helper.Dispose();
                    Application.Exit();
                }
            }
            else
            {
                Program.m_currentUser.id = suser.id;
                Program.m_currentUser.name = suser.name;
                Program.m_currentUser.admin = suser.admin;

                MainForm frm = new MainForm();
                frm.Text = $"Диспетчерская такси ({Program.m_currentUser.name})";
                frm.Show(this);
                Hide();

            }

        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            Program.m_helper.Dispose();
            Application.Exit();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                acceptButton_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Escape)
                rejectButton_Click(sender, e);
        }
    }
}

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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.password32;

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string newPass = newPassword_TextBox.Text;
            string repPass = repeatPassword_textBox.Text;
            if (newPass != repPass) 
            {
                Program.ShowErrorMessage("Новый пароль не подтверждён.\nПовторите ввод пароля");
            }
            else 
            {
                if (Program.m_helper.UpdateUserPassword(Program.m_currentUser.id, newPass) < 1)
                    Program.DBErrorMessage();
                else
                    MessageBox.Show("Вы изменили  свой пароль,\nкоторый будет запрашиваться при повторном входе в систему", 
                        "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

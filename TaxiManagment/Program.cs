using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiManagment
{
    internal static class Program
    {
        public static DBHelper m_helper;
        public static User m_currentUser;
        public static Filter m_filter;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            m_helper = new DBHelper();
            m_currentUser = new User(); 
            m_filter = new Filter();
            if (!m_helper.isOpened)
            {
                ShowErrorMessage("Не удалось соединиться с базой данных");
                Application.Exit();
            }
            else
               Application.Run(new AutorizationForm());
        }

        /// Сообщения об ошибках
        /// </summary>
        public static void DBErrorMessage()
        {
            ShowErrorMessage(m_helper.errorText);
        }
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

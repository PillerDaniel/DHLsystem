using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DhlSystem.Model;

namespace DhlSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginWindow loginWindow = null;
        public MainWindow()
        {
            InitializeComponent();
            CheckDataBaseConnection();
        }
        private void CheckDataBaseConnection()
        {
            try
            {
                DhlSystemContext dbcontext = new();
                if (!dbcontext.Database.CanConnect())
                {
                    MessageBox.Show("Database connection failed!");
                    Environment.Exit(1);
                }
            }
            catch
            {
                MessageBox.Show("Database connection failed!");
                Environment.Exit(1);
            }
        }
        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (this.loginWindow == null || !this.loginWindow.IsLoaded)
            {
                this.loginWindow = new LoginWindow();
                this.Close();
                this.loginWindow.Show();
            }
            else { this.loginWindow.Show(); }
        }
    }
}

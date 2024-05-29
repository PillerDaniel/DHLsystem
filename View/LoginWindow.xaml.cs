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
using System.Windows.Shapes;
using DhlSystem.Repository;
using DhlSystem.Model;
using MySqlX.XDevAPI.Common;
using System.Linq.Expressions;
using DhlSystem.View;
using Microsoft.VisualBasic;

namespace DhlSystem
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private ManageWindow manageWindow = null;
        private AdminManageWindow adminManageWindow = null;
        private UserRepository userRepository;
        private List<User> users;
        private User LoggedInUser;

        public LoginWindow()
        {
            LoggedInUser = null;
            InitializeComponent();
        }

        private bool Authenticate(string username, string password)
        {
            DhlSystemContext userContext = new DhlSystemContext();
            User dbEntry = userContext.Users.Where(b => b.UserName == username).FirstOrDefault();
            if (dbEntry != null) 
            {
                if (dbEntry.Password == password)
                {
                    LoggedInUser = dbEntry;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
           if(!Authenticate(username_box.Text, password_box.Password))
            {
                MessageBox.Show("Incorrect username or password!");
            }
           else
            {
                if (LoggedInUser != null && LoggedInUser.permission == "admin") 
                {
                    if (this.adminManageWindow == null || !this.adminManageWindow.IsLoaded)
                    {
                        this.adminManageWindow = new AdminManageWindow();
                        this.Close();
                        this.adminManageWindow.Show();
                    }
                    else { this.adminManageWindow.Show(); }
                }
                if (LoggedInUser != null && LoggedInUser.permission=="user")
                {
                    if (this.manageWindow == null || !this.manageWindow.IsLoaded)
                    {
                        this.manageWindow = new ManageWindow();
                        this.Close();
                        this.manageWindow.Show();
                    }
                    else { this.manageWindow.Show(); }
                }
            }
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btn_login_Click(sender, e);
            }
        }
    }
}

using DhlSystem.Repository;
using DhlSystem.Model;
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

namespace DhlSystem.View
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        private UserRepository userRepository;
        private List<User> Users;
        private Op operation = Op.No;

        enum Op
        {
            Add,
            Upd,
            No
        }
        public UserView()
        {
            InitializeComponent();
            userRepository = new UserRepository(new DhlSystemContext());
            LoadUsersGrid();
        }
        private void LoadUsersGrid()
        {
            Cursor = Cursors.Wait;
            Users = userRepository.GetUsers();
            UsersGrid.DataContext = Users;
            Cursor = Cursors.Arrow;
            box_username.IsEnabled = false;
            box_password.IsEnabled = false;
            box_permission.IsEnabled = false;
        }
        private void newClick(object sender, RoutedEventArgs e)
        {
            operation = Op.Add;
            box_username.IsEnabled = true;
            box_password.IsEnabled = true;
            box_permission.IsEnabled = true;
        }
        private void saveClick(object sender, RoutedEventArgs e)
        {
            if (operation == Op.Add && box_username.Text != "" && box_password.Text != "" && box_permission.Text != "")
            {
                box_username.IsEnabled = true;
                box_password.IsEnabled = true;
                box_permission.IsEnabled = true;
                userRepository.InsertUser(new User(box_username.Text, box_password.Text, box_permission.Text));
                MessageBox.Show("Successful operation.");
                userRepository.Save();
                LoadUsersGrid();
            }
            else
            {
                MessageBox.Show("Something went wrong, operation failed.");
            }
        }
        private void deleteClick(object sender, RoutedEventArgs e)
        {
            User deleteUser = userRepository.GetUserById(Users[UsersGrid.SelectedIndex].Id);
            if (operation == Op.Upd)
            {
                box_username.IsEnabled = true;
                box_password.IsEnabled = true;
                box_permission.IsEnabled = true;
                userRepository.DeleteUser(deleteUser.Id);
                MessageBox.Show("Successful operation.");
                userRepository.Save();
                LoadUsersGrid();
                operation = Op.No;
            }
            else
            {
                MessageBox.Show("Something went wrong, operation failed.");
            }
        }
        private void updateClick(object sender, RoutedEventArgs eventArgs)
        {
            if (operation == Op.Upd)
            {
                box_username.IsEnabled = true;
                box_password.IsEnabled = true;
                box_permission.IsEnabled = true;
                User updateUser = userRepository.GetUserById(Users[UsersGrid.SelectedIndex].Id);
                updateUser.UserName = box_username.Text;
                updateUser.Password = box_password.Text;
                updateUser.permission = box_permission.Text;
                MessageBox.Show("Successful operation.");
                userRepository.Save();
                LoadUsersGrid();
                operation = Op.No;
            }
            else
            {
                MessageBox.Show("Something went wrong, operation failed.");
            }
        }
        private void DataGrind_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var cell = e.OriginalSource as DependencyObject;
            while (cell != null && !(cell is DataGridCell))
            {
                cell = VisualTreeHelper.GetParent(cell);
            }

            if (cell == null)
            {
                MessageBox.Show("Empty Cell");
                return;
            }

            if (Users.Count != 0 && UsersGrid.SelectedIndex < Users.Count)
            {
                box_username.IsEnabled = true;
                box_password.IsEnabled = true;
                box_permission.IsEnabled = true;

                box_username.Text = Users[UsersGrid.SelectedIndex].UserName;
                box_password.Text = Users[UsersGrid.SelectedIndex].Password;
                box_permission.Text = Users[UsersGrid.SelectedIndex].permission;
                operation = Op.Upd;
                userRepository.Save();
            }
        }
    }
}

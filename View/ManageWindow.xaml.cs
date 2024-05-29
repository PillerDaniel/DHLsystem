using DhlSystem.View;
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
using DhlSystem.Model;

namespace DhlSystem.View
{
    /// <summary>
    /// Interaction logic for ManageWindow.xaml
    /// </summary>
    public partial class ManageWindow : Window
    {
        private LoginWindow loginWindow;
        private CarView carView;
        private EmployeeView employeeView;
        private HomeView  homeView;
        private SelectedCarView selectedCarView;
        public ManageWindow()
        {
            InitializeComponent();
            this.carView = new CarView();
            this.employeeView = new EmployeeView();
            this.homeView = new HomeView();
            this.selectedCarView = new SelectedCarView();
            contentControl.Content = this.homeView;
        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            if (this.loginWindow == null || !this.loginWindow.IsLoaded)
            {
                this.loginWindow = new LoginWindow();
                this.Close();
                this.loginWindow.Show();
            }
            else { this.loginWindow.Show(); }
        }
        private void HomeMenuClick (object sender, RoutedEventArgs e)
        {
            contentControl.Content = homeView;
        }
        private void CarMenuClick(object sender, RoutedEventArgs e)
        {
            contentControl.Content = carView;
        }
        private void EmployeeMenuClick(object sender, RoutedEventArgs e)
        {
            contentControl.Content = employeeView;
        }
        private void SelectedCarsMenuClick(object sender, RoutedEventArgs e)
        {
            contentControl.Content = selectedCarView;
        }
    }
}

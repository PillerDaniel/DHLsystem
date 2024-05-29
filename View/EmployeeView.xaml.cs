using System;
using DhlSystem.Repository;
using DhlSystem.Model;
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
    /// Interaction logic for EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : UserControl
    {
        private EmployeeRepository employeeRepository;
        private List<Employee> employees;
        private Op operation = Op.No;

        enum Op
        {
            Add,
            Upd,
            No
        }
        public EmployeeView()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository(new DhlSystemContext());
            LoadEmployyeGrid();
        }
        private void LoadEmployyeGrid()
        {
            Cursor = Cursors.Wait;
            employees = employeeRepository.GetEmployees();
            EmployeeGrid.DataContext = employees;
            Cursor = Cursors.Arrow;
            box_name.IsEnabled = false;
            box_position.IsEnabled = false;
            box_tourid.IsEnabled = false;
        }
        private void newClick(object sender, RoutedEventArgs e)
        {
            operation = Op.Add;
            box_name.IsEnabled = true;
            box_position.IsEnabled = true;
            box_tourid.IsEnabled = true;
        }
        private void saveClick(object sender, RoutedEventArgs e)
        {
            if (operation == Op.Add && box_name.Text != "" && box_position.Text != "" && box_tourid.Text != "")
            {
                box_name.IsEnabled = true;
                box_position.IsEnabled = true;
                box_tourid.IsEnabled = true;
                employeeRepository.InsertEmployee(new Employee(box_name.Text, box_position.Text, int.Parse(box_tourid.Text)));
                MessageBox.Show("Successful operation.");
                employeeRepository.Save();
                LoadEmployyeGrid();
            }
            else
            {
                MessageBox.Show("Something went wrong, operation failed.");
            }
        }
        private void deleteClick(object sender, RoutedEventArgs e)
        {
            Employee deleteEmployee = employeeRepository.GetEmployeeById(employees[EmployeeGrid.SelectedIndex].Id);
            if (operation == Op.Upd)
            {
                box_name.IsEnabled = true;
                box_position.IsEnabled = true;
                box_tourid.IsEnabled = true;
                employeeRepository.DeleteEmployee(deleteEmployee.Id);
                MessageBox.Show("Successful operation.");
                employeeRepository.Save();
                LoadEmployyeGrid();
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
                box_name.IsEnabled = true;
                box_position.IsEnabled = true;
                box_tourid.IsEnabled = true;
                Employee updateEmployee = employeeRepository.GetEmployeeById(employees[EmployeeGrid.SelectedIndex].Id);
                updateEmployee.Name = box_name.Text;
                updateEmployee.Position = box_position.Text;
                updateEmployee.TourId = int.Parse(box_tourid.Text);
                MessageBox.Show("Successful operation.");
                employeeRepository.Save();
                LoadEmployyeGrid();
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

            if (employees.Count != 0 && EmployeeGrid.SelectedIndex < employees.Count)
            {
                box_name.IsEnabled = true;
                box_position.IsEnabled = true;
                box_tourid.IsEnabled = true;

                box_name.Text = employees[EmployeeGrid.SelectedIndex].Name;
                box_position.Text = employees[EmployeeGrid.SelectedIndex].Position;
                box_tourid.Text = Convert.ToString(employees[EmployeeGrid.SelectedIndex].TourId);
                operation = Op.Upd;
                employeeRepository.Save();
            }
        }
    }
}

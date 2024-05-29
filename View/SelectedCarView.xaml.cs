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
    /// Interaction logic for SelectedCarView.xaml
    /// </summary>
    public partial class SelectedCarView : UserControl
    {
        private SelectedCarsRepository selectedCarRepository;
        private List<SelectedCars> selectedCars;
        private Op operation = Op.No;
        enum Op
        {
            Add,
            Upd,
            No
        }
        public SelectedCarView()
        {
            InitializeComponent();
            this.selectedCarRepository = new SelectedCarsRepository(new DhlSystemContext());
            LoadSelectedCarsGrid();
            LoadComboBoxEmployees();
            LoadComboBoxVehicles();
        }
        private void LoadSelectedCarsGrid()
        {
            Cursor = Cursors.Wait;
            selectedCars = selectedCarRepository.GetSelectedCars();
            SelectedCarsGrid.DataContext = selectedCars;
            Cursor = Cursors.Arrow;
            EmployeesComboBox.IsEnabled = false;
            VehiclesComboBox.IsEnabled = false;
        }

        private void LoadComboBoxEmployees()
        {
            Cursor = Cursors.Wait;
            List<Employee> lstEmployees = new List<Employee>();
            EmployeeRepository employeeRep = new EmployeeRepository(new DhlSystemContext());
            lstEmployees = employeeRep.GetEmployees();
            EmployeesComboBox.ItemsSource = lstEmployees;
            EmployeesComboBox.SelectedValue = lstEmployees;
            EmployeesComboBox.DisplayMemberPath = "Name";
            EmployeesComboBox.SelectedValuePath = "Id";
            lstEmployees = null;
            employeeRep.Dispose();
            Cursor = Cursors.Arrow;
        }
        private void LoadComboBoxVehicles()
        {
            Cursor = Cursors.Wait;
            List<Car> lstCars = new List<Car>();
            CarRepository carRep = new CarRepository(new DhlSystemContext());
            lstCars = carRep.GetCars();
            VehiclesComboBox.ItemsSource = lstCars;
            VehiclesComboBox.SelectedValue = lstCars;
            VehiclesComboBox.DisplayMemberPath = "Plate";
            VehiclesComboBox.SelectedValuePath = "Id";
            lstCars = null;
            carRep.Dispose();
            Cursor = Cursors.Arrow;
        }
        private void newClick(object sender, RoutedEventArgs e)
        {
            operation = Op.Add;
            EmployeesComboBox.IsEnabled = true;
            VehiclesComboBox.IsEnabled = true;
        }
        private void saveClick(object sender, RoutedEventArgs e)
        {
            EmployeesComboBox.IsEnabled = true;
            VehiclesComboBox.IsEnabled = true;
            if (operation == Op.Add && VehiclesComboBox.SelectedValue != "" && EmployeesComboBox.SelectedValue !="")
             {
                selectedCarRepository.InsertSelectedCar(new SelectedCars(Convert.ToInt32(EmployeesComboBox.SelectedValue), Convert.ToInt32(VehiclesComboBox.SelectedValue)));
                MessageBox.Show("Successful operation.");
                selectedCarRepository.Save();
                LoadSelectedCarsGrid();
                operation = Op.No;
            }
            else
            {
                MessageBox.Show("Something went wrong, operation failed.");
            }
        }
        private void deleteClick(object sender, RoutedEventArgs e)
        { 
            if(operation == Op.Upd)
            {
                SelectedCars delete = selectedCarRepository.GetSelectedCarsById(selectedCars[SelectedCarsGrid.SelectedIndex].Id);
                EmployeesComboBox.IsEnabled = true;
                VehiclesComboBox.IsEnabled = true;
                selectedCarRepository.DeleteSelectedCar(delete.Id);
                MessageBox.Show("Successful operation.");
                selectedCarRepository.Save();
                LoadSelectedCarsGrid();
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
                SelectedCars update = selectedCarRepository.GetSelectedCarsById(selectedCars[SelectedCarsGrid.SelectedIndex].Id);
                EmployeesComboBox.IsEnabled = true;
                VehiclesComboBox.IsEnabled = true;
                update.CarId = Convert.ToInt32(VehiclesComboBox.SelectedValue);
                update.DriverId = Convert.ToInt32(EmployeesComboBox.SelectedValue);
                MessageBox.Show("Successful operation.");
                selectedCarRepository.Save();
                LoadSelectedCarsGrid();
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

            if (selectedCars.Count != 0 && SelectedCarsGrid.SelectedIndex < selectedCars.Count)
            {
                EmployeesComboBox.IsEnabled = true;
                VehiclesComboBox.IsEnabled = true;

                VehiclesComboBox.SelectedValue = selectedCars[SelectedCarsGrid.SelectedIndex].CarId;
                EmployeesComboBox.SelectedValue = selectedCars[SelectedCarsGrid.SelectedIndex].DriverId;
                operation = Op.Upd;
                selectedCarRepository.Save();
            }
        }
    }
}

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
    /// Interaction logic for CarView.xaml
    /// </summary>
    public partial class CarView : UserControl
    {
        private CarRepository carRepository;
        private List<Car> Cars;
        private Op operation = Op.No;

        enum Op
        {
            Add,
            Upd,
            No
        }

        public CarView()
        {
            InitializeComponent();
            carRepository = new CarRepository(new DhlSystemContext());
            LoadCarsGrid();
        }

        private void LoadCarsGrid()
        {
            Cursor = Cursors.Wait;
            Cars = carRepository.GetCars();
            CarsGrid.DataContext = Cars;
            Cursor = Cursors.Arrow;
            box_brand.IsEnabled = false;
            box_km.IsEnabled = false;
            box_plate.IsEnabled = false;
            box_type.IsEnabled = false;
        }
        private void newClick(object sender, RoutedEventArgs e)
        {
            operation = Op.Add;
            box_brand.IsEnabled = true;
            box_km.IsEnabled = true;
            box_plate.IsEnabled = true;
            box_type.IsEnabled = true;
        }
        private void saveClick(object sender, RoutedEventArgs e)
        {
            if (operation == Op.Add && box_brand.Text != "" && box_km.Text != "" && box_plate.Text != "" && box_type.Text != "")
            {
                box_brand.IsEnabled = true;
                box_km.IsEnabled = true;
                box_plate.IsEnabled = true;
                box_type.IsEnabled = true;
                carRepository.InsertCar(new Car(box_brand.Text, box_type.Text, box_plate.Text, int.Parse(box_km.Text)));
                MessageBox.Show("Successful operation.");
                carRepository.Save();
                LoadCarsGrid();
            }
            else
            {
                MessageBox.Show("Something went wrong, operation failed.");
            }
        }
        private void deleteClick(object sender, RoutedEventArgs e)
        {
            Car deleteCar = carRepository.GetCarById(Cars[CarsGrid.SelectedIndex].Id);
            if (operation == Op.Upd)
            {
                box_brand.IsEnabled = true;
                box_km.IsEnabled = true;
                box_plate.IsEnabled = true;
                box_type.IsEnabled = true;
                carRepository.DeleteCar(deleteCar.Id);
                MessageBox.Show("Successful operation");
                carRepository.Save();
                LoadCarsGrid();
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
                box_brand.IsEnabled = true;
                box_km.IsEnabled = true;
                box_plate.IsEnabled = true;
                box_type.IsEnabled = true;
                Car updateCar = carRepository.GetCarById(Cars[CarsGrid.SelectedIndex].Id);
                updateCar.Brand = box_brand.Text;
                updateCar.Type = box_type.Text;
                updateCar.Plate = box_plate.Text;
                updateCar.Km = int.Parse(box_km.Text);
                MessageBox.Show("Successful operation.");
                carRepository.Save();
                LoadCarsGrid();
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

            if (Cars.Count != 0 && CarsGrid.SelectedIndex < Cars.Count)
            {
                box_brand.IsEnabled = true;
                box_km.IsEnabled = true;
                box_plate.IsEnabled = true;
                box_type.IsEnabled = true;

                box_brand.Text = Cars[CarsGrid.SelectedIndex].Brand;
                box_type.Text = Cars[CarsGrid.SelectedIndex].Type;
                box_plate.Text = Cars[CarsGrid.SelectedIndex].Plate;
                box_km.Text = Convert.ToString(Cars[CarsGrid.SelectedIndex].Km);
                operation = Op.Upd;
                carRepository.Save();
            }
        }
    }
}


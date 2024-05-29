using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DhlSystem.Model;

namespace DhlSystem.Repository
{
    class SelectedCarsRepository
    {
        private DhlSystemContext dhlContext;

        public SelectedCarsRepository( DhlSystemContext context)
        {
            this.dhlContext = context;
        }
        public List<SelectedCars> GetSelectedCars() 
        {
            return dhlContext.SelectedCars.ToList();
        }
        public SelectedCars GetSelectedCarsById(int id)
        {
            return dhlContext.SelectedCars.Find(id);
        }
        public void InsertSelectedCar(SelectedCars selectedcar)
        {
            dhlContext.SelectedCars.Add(selectedcar);
        }
        public void DeleteSelectedCar(int id)
        {
            dhlContext.SelectedCars.Remove(dhlContext.SelectedCars.Find(id));
        }
        public void UpdateSelectedCar(SelectedCars selectedcar) 
        {
            dhlContext.SelectedCars.Find(selectedcar.Id).CarId = selectedcar.CarId;
            dhlContext.SelectedCars.Find(selectedcar.Id).DriverId = selectedcar.DriverId;
        }
        public void Save()
        {
            dhlContext.SaveChanges();
        }
        public void Dispose()
        {
            dhlContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

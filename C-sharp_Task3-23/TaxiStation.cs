using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Task3_23
{
    class TaxiStation
    {
        private List<Car> carList = new List<Car>();

        public List<Car> CarList
        {
            get { return carList; }
            set { carList = value; }
        }

        public void AddCar(Car car)
        {
            carList.Add(car);
        }

        public void RemoveCar(Car car)
        {
            carList.Remove(car);
        }

        public void RemoveCarAt(int index)
        {
            carList.RemoveAt(index);
        }

        public double CalculateCostOfVehicleFleet()
        {
            double sum = 0;
            foreach (Car car in carList)
            {
                sum += car.Price;
            }
            return sum;
        }

        public void SortByFuelConsumptionAscending()
        {
            carList.Sort(new CarComparerByFuelConsumptionAscending());
        }

        public void SortByFuelConsumptionDescending()
        {
            carList.Sort(new CarComparerByFuelConsumptionDescending());
        }

        public List<Car> FindCarsBySpeed(double minSpeed, double maxSpeed)
        {
            List<Car> result = new List<Car>();
            foreach (Car car in carList)
            {
                if (minSpeed <= car.MaxSpeed && maxSpeed >= car.MaxSpeed)
                {
                    result.Add(car);
                }
            }
            if (result.Count == 0)
            {
                return null;
            }
            return result;
        }

        class CarComparerByFuelConsumptionAscending : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                if (x.FuelConsumption > y.FuelConsumption)
                    return 1;
                else if (x.FuelConsumption < y.FuelConsumption)
                    return -1;
                else
                    return 0;
            }
        }

        class CarComparerByFuelConsumptionDescending : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                if (x.FuelConsumption < y.FuelConsumption)
                    return 1;
                else if (x.FuelConsumption > y.FuelConsumption)
                    return -1;
                else
                    return 0;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Task3_23
{
    class Car
    {
        private string brend;
        private string model;
        private Body bodyType;
        private string registrationNumber;
        private double maxSpeed;
        private int numberOfPassengerSeats;
        private double fuelConsumption;
        private double price;

        public Car(string brend, string model, Body bodyType, string registrationNumber, double maxSpeed, int numberOfPassengerSeats, double fuelConsumption, double price)
        {
            this.brend = brend;
            this.model = model;
            this.bodyType = bodyType;
            this.registrationNumber = registrationNumber;
            this.maxSpeed = maxSpeed;
            this.numberOfPassengerSeats = numberOfPassengerSeats;
            this.fuelConsumption = fuelConsumption;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Brend: {Brend}; Model: {Model}; BodyType: {BodyType}; RegistrationNumber: {RegistrationNumber}; MaxSpeed: {MaxSpeed}; " +
                $"NumberOfPassengerSeats: {NumberOfPassengerSeats}; FuelConsumption: {FuelConsumption}; Price: {Price}.";
        }

        public string ToDataString()
        {
            return $"{Brend} {Model} {BodyType} {RegistrationNumber} {MaxSpeed} {NumberOfPassengerSeats} {FuelConsumption} {Price}";
        }

        public Body BodyType
        {
            get { return bodyType; }
            set { bodyType = value; }
        }

        public string Brend
        {
            get { return brend; }
            set { brend = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        public double MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public int NumberOfPassengerSeats
        {
            get { return numberOfPassengerSeats; }
            set { numberOfPassengerSeats = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        public enum Body
        {
            Sedan,
            Minivan,
            SUV,
            Hatchback,
            Coupe,
            Pickup,
            Van,
        }
    }
}

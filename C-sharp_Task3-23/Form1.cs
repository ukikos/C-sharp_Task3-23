using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C_sharp_Task3_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Текстовые документы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые документы(*.txt)|*.txt|Все файлы(*.*)|*.*";
        }

        TaxiStation taxiStation;
        string path;

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            path = openFileDialog1.FileName;
            pathTextBox.Text = path;

            taxiStation = new TaxiStation();
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splLine = line.Split(' ');
                    taxiStation.AddCar(new Car(splLine[0], splLine[1], (Car.Body)Enum.Parse(typeof(Car.Body), splLine[2]), splLine[3], Convert.ToDouble(splLine[4]), Convert.ToInt32(splLine[5]), Convert.ToDouble(splLine[6]), Convert.ToDouble(splLine[7])));
                }
            }
            DataTable table = new DataTable();
            table.Columns.Add("Бренд", typeof(string));
            table.Columns.Add("Модель", typeof(string));
            table.Columns.Add("Тип кузова", typeof(Car.Body));
            table.Columns.Add("Рег.номер", typeof(string));
            table.Columns.Add("Макс.скорость", typeof(double));
            table.Columns.Add("Кол-во пассажирских мест", typeof(int));
            table.Columns.Add("Расход топлива", typeof(double));
            table.Columns.Add("Цена", typeof(double));

            foreach (Car car in taxiStation.CarList)
            {
                table.Rows.Add(car.Brend, car.Model, car.BodyType, car.RegistrationNumber, car.MaxSpeed, car.NumberOfPassengerSeats, car.FuelConsumption,
                    car.Price);
            }
            dataGridView1.DataSource = table;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            taxiStation = new TaxiStation();

            int countOfEmptyRows = 0;
            for (int j = 0; j < dataGridView1.RowCount - 1; j++)
            {
                if (dataGridView1[0, j].Value.ToString() == "" || dataGridView1[1, j].Value.ToString() == ""
                    || dataGridView1[2, j].Value.ToString() == ""
                    || dataGridView1[3, j].Value.ToString() == "" || dataGridView1[4, j].Value.ToString() == "" || dataGridView1[5, j].Value.ToString() == ""
                    || dataGridView1[6, j].Value.ToString() == "" || dataGridView1[7, j].Value.ToString() == "")
                {
                    countOfEmptyRows += 1;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount - countOfEmptyRows - 1; i++)
            {
                taxiStation.AddCar(new Car(dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString(),
                    (Car.Body) Enum.Parse(typeof(Car.Body), dataGridView1[2, i].Value.ToString()), dataGridView1[3, i].Value.ToString(),
                    Convert.ToDouble(dataGridView1[4, i].Value.ToString()), Convert.ToInt32(dataGridView1[5, i].Value.ToString()),
                    Convert.ToDouble(dataGridView1[6, i].Value.ToString()), Convert.ToDouble(dataGridView1[7, i].Value.ToString())));
            }
            File.WriteAllText(path, String.Empty);
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                foreach (Car car in taxiStation.CarList)
                {
                    sw.WriteLine(car.ToDataString());
                }
            }
        }

        private void saveHowButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = saveFileDialog1.FileName;

            taxiStation = new TaxiStation();

            int countOfEmptyRows = 0;
            for (int j = 0; j < dataGridView1.RowCount - 1; j++)
            {
                if (dataGridView1[0, j].Value.ToString() == "" || dataGridView1[1, j].Value.ToString() == ""
                    || dataGridView1[2, j].Value.ToString() == "" || dataGridView1[3, j].Value.ToString() == ""
                    || dataGridView1[4, j].Value.ToString() == "" || dataGridView1[5, j].Value.ToString() == ""
                    || dataGridView1[6, j].Value.ToString() == "" || dataGridView1[7, j].Value.ToString() == "")
                {
                    countOfEmptyRows += 1;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount - countOfEmptyRows - 1; i++)
            {
                taxiStation.AddCar(new Car(dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString(),
                    (Car.Body)Enum.Parse(typeof(Car.Body), dataGridView1[2, i].Value.ToString()), dataGridView1[3, i].Value.ToString(),
                    Convert.ToDouble(dataGridView1[4, i].Value.ToString()), Convert.ToInt32(dataGridView1[5, i].Value.ToString()),
                    Convert.ToDouble(dataGridView1[6, i].Value.ToString()), Convert.ToDouble(dataGridView1[7, i].Value.ToString())));
            }
            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
            {
                foreach (Car car in taxiStation.CarList)
                {
                    sw.WriteLine(car.ToDataString());
                }
            }
            path = filePath;
            pathTextBox.Text = path;
        }

        private void sortByFuelConsumptionAscButton_Click(object sender, EventArgs e)
        {
            taxiStation.SortByFuelConsumptionAscending();
            refreshTable();
        }

        private void sortByFuelConsumptionDesButton_Click(object sender, EventArgs e)
        {
            taxiStation.SortByFuelConsumptionDescending();
            refreshTable();
        }

        private void refreshTable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            DataTable table = new DataTable();
            table.Columns.Add("Бренд", typeof(string));
            table.Columns.Add("Модель", typeof(string));
            table.Columns.Add("Тип кузова", typeof(Car.Body));
            table.Columns.Add("Рег.номер", typeof(string));
            table.Columns.Add("Макс.скорость", typeof(double));
            table.Columns.Add("Кол-во пассажирских мест", typeof(int));
            table.Columns.Add("Расход топлива", typeof(double));
            table.Columns.Add("Цена", typeof(double));

            foreach (Car car in taxiStation.CarList)
            {
                table.Rows.Add(car.Brend, car.Model, car.BodyType, car.RegistrationNumber, car.MaxSpeed, car.NumberOfPassengerSeats, car.FuelConsumption,
                    car.Price);
            }
            dataGridView1.DataSource = table;
        }

        private void calculateCostButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = taxiStation.CalculateCostOfVehicleFleet().ToString();
        }

        private void findCarsBySpeedButton_Click(object sender, EventArgs e)
        {
            List<Car> cars;
            cars = taxiStation.FindCarsBySpeed(Convert.ToDouble(textBoxMinSpeed.Text), Convert.ToDouble(textBoxMaxSpeed.Text));
            textBoxOutput.Text = "";
            if (cars != null)
            {
                foreach (Car car in cars)
                {
                    textBoxOutput.Text += car.ToDataString();
                    textBoxOutput.Text += "\r\n";
                }
            }
        }
    }
}

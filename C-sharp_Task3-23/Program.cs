using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_Task3_23
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //using (StreamWriter sw = new StreamWriter(@"C:\Users\vakul\source\repos\C-sharp_Task3-23\text.txt", true, System.Text.Encoding.Default))
            //{
            //    foreach (Car car in taxiStation.CarList)
            //    {
            //        sw.WriteLine(car.ToDataString());
            //    }
            //}

            //using (StreamReader sr = new StreamReader(@"C:\Users\vakul\source\repos\C-sharp_Task3-23\text.txt", System.Text.Encoding.Default))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        string[] splLine = line.Split(" ");
            //        taxiStation.AddCar(new Car(splLine[0], splLine[1], (Car.Body)Enum.Parse(typeof(Car.Body), splLine[2]), splLine[3], Convert.ToDouble(splLine[4]), Convert.ToInt32(splLine[5]), Convert.ToDouble(splLine[6]), Convert.ToDouble(splLine[7])));
            //    }
            //}
        }
    }
}

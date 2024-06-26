using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Lab04;
using Lab3;
using ClassLib;

namespace ClassLib
{
    public class Camera
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Contry { get; set; }
        public int SceenDiagonal { get; set; }
        public int MatrixSize { get; set; }
        public double YearOfProduction { get; set; }
        public double Weight { get; set; }
        public bool LensInterchangeable { get; set; }
        public double Price { get; set; }  

        public Camera()
        {
        }

        public Camera(string name, string model, string contry, int sceenDiagonal, int matrixSize, double yearOfProduction,
            double weight, bool lensInterchangeable, double price)
        {
            Name = name;
            Model = model;
            Contry = contry;
            SceenDiagonal = sceenDiagonal;
            MatrixSize = matrixSize;
            YearOfProduction = yearOfProduction;
            Weight = weight;
            LensInterchangeable = lensInterchangeable;
            Price = price; 
        }

        public void CalculatePrice()
        {
            Price = MatrixSize * YearOfProduction;
        }
    }
}



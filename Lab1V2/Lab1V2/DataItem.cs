using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab1V2
{
    internal struct DataItem {
        public double CoordinateX { get; set; }
        public Complex ComponentY1 { get; set; }
        public Complex ComponentY2 { get; set; }

        //Конструктор
        public DataItem(double x, Complex y1, Complex y2){
            CoordinateX = x;
            ComponentY1 = y1;
            ComponentY2 = y2;
        }

        //Метод ToString 
        public string ToString(string format)
        {
            return $"Coordinate: {CoordinateX.ToString(format)}," +
                $" Component1: {ComponentY1.ToString(format)}, " +
                $"Component2: {ComponentY2.ToString(format)}";
        }

        public override string ToString() { 
            return $"CoordinateX: {CoordinateX}, ComponentY1: {ComponentY1}, ComponentY2: {ComponentY2}";
        }

    }
}

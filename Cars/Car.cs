using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    abstract public class Car : IServiceable
    {
        public string Marks { get; set; }
        public int YearsOfProdaction { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public Color Colors { get; set; }
        public int Distance { get; set; }
        public int DistanceOnService { get; set; } 
        public Car(string marks, int yearsOfProdaction, int price, int weight, Color colors)
        {
            Marks = marks;
            YearsOfProdaction = yearsOfProdaction;
            Price = price;
            Weight = weight;
            Colors = colors;
        }
        public void AddDistance (int newDistance) 
        {
            Distance += newDistance;
            DistanceOnService += newDistance;
        }
        public void AddDistance(double newDistance)
        {
           Distance += (int) newDistance;
           DistanceOnService += (int)newDistance;

        }
        public abstract void Service();
        public abstract bool IsReadyToService();

        public override string? ToString()
        {
            return "Car [yearsOfProdaction " + YearsOfProdaction + ", price " + Price + " , weight " + Weight +
                " , color " + Colors + " ,mark " + Marks + " , distance " + Distance + "]";
        }

        public override bool Equals(object? obj)
        {
            return obj is Car car &&
                   Marks == car.Marks &&
                   YearsOfProdaction == car.YearsOfProdaction &&
                   Price == car.Price &&
                   Weight == car.Weight &&
                   Colors == car.Colors;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Marks, YearsOfProdaction, Price, Weight, Colors);
        }

        public static bool operator == (Car left, Car right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(Car left, Car right)
        {
            return !Equals(left, right);
        }
    }
}

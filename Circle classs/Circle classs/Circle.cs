using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_classs
{
    public class Circle
    {
        private double Radius;
        private string Color;
    
        public Circle()
        {
            this.Radius =1.0;
            this.Color="Red";

        }
        public Circle(double r)
        {
            this.Radius =r;
            this.Color ="Red";
        }
        public Circle(double radius, string Color)
        {
            this.Radius =radius;
            this.Color = "Red";
        }
        public double getRadius()
        {
            return this.Radius;
        }
        public double getArea()
        {
            return this.Radius*Radius*Math.PI;
        }
        public string getColor()
        {
            return this.Color;
        }
        public void setRadius(double newRadius)
        {
            this.Radius = newRadius;
        }
        public void setColor(String newColor)
        {          
            this.Color = newColor;
        }
        //public override string ToString()
        //{
        //    return String.Format("Circle[radius] = {0},[color] = {1}", Radius, Color);
        //}
        public double getCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return String.Format("Circle[radius] = {0}", Radius);
        }
   }
}    


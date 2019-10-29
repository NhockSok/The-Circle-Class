using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Rectanggle_Class
{
    class Rectanggle
    {
        private float Length;
        private float Width;
        
        public Rectanggle()
        {
            this.Length =1.0f;
            this.Width  =1.0f;
        }
        public Rectanggle(float L,float W)
        {
            this.Length =L;
            this.Width =W;
        }
        public double getLength()
        {
            return this.Length;
        }
        public double getPerimeter()
        {
            return (Length + Width) * 2;
        }
        public float getWidth()
        {
            return Width;
        }
        public void setLength(float newLength)
        {
           Length = newLength;
        }
        public void setWidth(float newWidth)
        {          
            this.Width = newWidth;
        }
        public override string ToString()
        {
            return String.Format("Rectangle[Length] = {0},[Width] = {1}", getLength(), getWidth());
        }
    }
}

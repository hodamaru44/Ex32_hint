using System;
using System.Collections.Generic;
using System.Text;

namespace Ex32
{
    class Rectangle : Surface
    {
        readonly public float width;
        readonly public float height;
        public float diagonal;
        public Rectangle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public override float GetSurface()
        {
            return width * height;
        }
        public override float GetCircumference()
        {
            return (width + height) * 2;
        }
        public override float GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
            return width;
            
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex32
{
    class Circle : Surface
    {
        readonly public float radius;
        public Circle(float radius )
        {
            this.radius = radius;
        }
        public override float GetSurface()
        {
            return radius * radius*MathF.PI;
        }
        public override float GetCircumference()
        {
            return radius * 2*MathF.PI;
        }
        public override float GetBounds(out float width, out float height)
        {
            width = this.radius;
            height = this.radius;
            return width;
        }
    }
}

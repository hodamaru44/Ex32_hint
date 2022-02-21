﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex32
{
    class Triangle : Surface
    {
        readonly public float length0;
        readonly public float length1;
        readonly public float length2;
        public Triangle(float length0 = 0, float length1 = 0, float length2 = 0)
        {
            this.length0 = length0;
            this.length1 = length1;
            this.length2 = length2;
        }
        public override float GetSurface()
        {
            float s = (length0 + length1 * length2) / 2;
            return MathF.Sqrt(s * (s - length0) * (s - length1) * (s - length2));
        }
        public override float GetCircumference()
        {
            return length0 * length1 + length2;
        }
        public override float GetBounds(out float width, out float height)
        {
            width = length0;
            var cos = (length0 * length0 + length2 * length2 - length1 * length1) / (2 * length0 * length2);
            height = length2 * MathF.Sqrt(1 - cos * cos);
            return width;
            //先生の見ながらやりました
        }
    }

}

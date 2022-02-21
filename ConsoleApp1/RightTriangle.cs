﻿using System;

using System.Collections.Generic;
using System.Text;

namespace Ex32
{
    /// <summary>
    /// 直角三角形
    /// </summary>
    class RightTriangle : Surface
    {
        readonly public float width;
        readonly public float height;
        public RightTriangle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public override float GetSurface()
        {
            return width / 2 * height;
        }
        public override float GetCircumference()
        {
            return width + height + MathF.Sqrt(width * width + height * height);
        }

        public override float GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
            return width;
            //先生の見ながらやりました
        }
    }
}

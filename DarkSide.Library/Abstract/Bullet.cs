using System;
using System.Drawing;

namespace DarkSide.Library.Abstract
{
    internal class Bullet : Cisim
    {
        public Bullet(Size movementSpaceSizes, int midBarrel) : base(movementSpaceSizes)
        {
            SetStartPoints(midBarrel);
            MovementDistance = (int)(Height * 1.5);
        }

        private void SetStartPoints(int midBarrel)
        {
            Bottom = MovementSpaceSizes.Height;
            Center = midBarrel;
        }
    }
}

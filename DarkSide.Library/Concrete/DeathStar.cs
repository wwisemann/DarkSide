using DarkSide.Library.Concrete;
using DarkSide.Library.Enum;
using System;
using System.Drawing;

namespace DarkSide.Library.Concrete
{
    internal class DeathStar : Cisim
    {
        public DeathStar(int panelWidth, Size movementSpaceSizes ) : base(movementSpaceSizes)
        {
            Center = panelWidth / 2;
            Center = Center - (Center % Width);
            MovementDistance = Width;
        }
    }
}

using DarkSide.Library.Abstract;
using DarkSide.Library.Enum;
using System;
using System.Drawing;

namespace DarkSide.Library.Abstract
{
    internal class DeathStar : Cisim
    {
        public DeathStar(int panelWidth, Size movementSpaceSizes ) : base(movementSpaceSizes)
        {
            Center = panelWidth / 2;
            MovementDistance = Width;
        }
    }
}

using System;
using System.Drawing;

namespace DarkSide.Library.Concrete
{
    internal class TieFighter : Cisim
    {
        public TieFighter(Size movementSpaceSizes, int panelWidth, float speed) : base(movementSpaceSizes)
        {
            int sectionCount = panelWidth / Width;

            Center = new Random().Next(sectionCount/2-5, sectionCount/2+5) * Width;

            MovementDistance = (int)(Height * speed);
        }
    }
}

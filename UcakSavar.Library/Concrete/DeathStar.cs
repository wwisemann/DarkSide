using DarkSide.Library.Abstract;

namespace DarkSide.Library.Concrete
{
    internal class DeathStar : Cisim
    {
        public DeathStar(int panelWidth)
        {
            Left = (panelWidth - Width) / 2;
        }
    }
}

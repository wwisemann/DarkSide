using DarkSide.Library.Enum;
using System.Drawing;

namespace DarkSide.Library.Interface
{
    internal interface IMoved
    {
        Size MovementSpaceSizes { get; }
        
        int MovementDistance { get; }

        /// <summary>
        /// Cismi istenilen yöne hareket ettirir.
        /// </summary>
        /// <param name="direction">Hangi yöne hareket edileceği</param>
        /// <returns>Cisim duvara çarparsa true döndürür. </returns>
        bool MoveIt(Direction direction);

    }
}

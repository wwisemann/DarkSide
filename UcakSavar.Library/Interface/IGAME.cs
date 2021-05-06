using System;
using DarkSide.Library.Enum;

namespace DarkSide.Library.Interface
{
    internal interface IGame
    {
        bool DoesItContinue { get; }
        TimeSpan ElapsedTime { get; }
        void Start();
        void Fire();
        void Move(Direction direction);
    }


}

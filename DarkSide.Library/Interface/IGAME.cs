/************************************************************
*****                                                   *****
*****           Arifcan Yılmaz  - b201200048            *****
*****             NDP Uçaksavar Projesi                 *****
*****                                                   *****
*************************************************************/

using System;
using DarkSide.Library.Enum;

namespace DarkSide.Library.Interface
{
    internal interface IGame
    {
        event EventHandler ElapsedTimeHasChanged;
        bool DoesItContinue { get; }
        TimeSpan ElapsedTime { get; }
        void Start();
        void Fire();
        void Move(Direction direction);
    }

}

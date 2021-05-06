using System;
using DarkSide.Library.Enum;
using DarkSide.Library.Interface;
using System.Windows.Forms;

namespace DarkSide.Library.Concrete
{
    public class Game : IGame
    {
        public bool DoesItContinue { get; private set; }

        public TimeSpan ElapsedTime => throw new NotImplementedException();
        public void Start()
        {
            if (DoesItContinue) return;

            MessageBox.Show("Game is started.");

            DoesItContinue = true;
        }

        private void Finish()
        {
            if (!DoesItContinue) return;

            DoesItContinue = false;
        }

        public void Fire()
        {
            throw new NotImplementedException();
        }

        public void Move(Direction direction)
        {
            throw new NotImplementedException();
        }

        
    }
}

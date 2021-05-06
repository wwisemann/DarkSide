using System;
using DarkSide.Library.Enum;
using DarkSide.Library.Interface;
using System.Windows.Forms;

namespace DarkSide.Library.Concrete
{
    public class Game : IGame
    {
        #region Fields

        private readonly Timer _elapsedTimer = new Timer { Interval = 1000 };
        private TimeSpan _elapsedTime;

        #endregion

        #region Events

        public event EventHandler ElapsedTimeHasChanged;

        #endregion

        #region Features
    
        public bool DoesItContinue { get; private set; }
        public TimeSpan ElapsedTime
        {
            get => _elapsedTime;
            private set
            {
                _elapsedTime = value;
                ElapsedTimeHasChanged.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion

        #region Methods
      
        public Game()
        {
            _elapsedTimer.Tick += ElapsedTimer_Tick;
        }

        private void ElapsedTimer_Tick(object sender, EventArgs e)
        {
            ElapsedTime += TimeSpan.FromSeconds(1);
        }

        public void Start()
        {
            if (DoesItContinue) return;

            DoesItContinue = true;
            _elapsedTimer.Start();
        }

        private void Finish()
        {
            if (!DoesItContinue) return;

            DoesItContinue = false;
            _elapsedTimer.Stop();
        }

        public void Fire()
        {
            throw new NotImplementedException();
        }

        public void Move(Direction direction)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

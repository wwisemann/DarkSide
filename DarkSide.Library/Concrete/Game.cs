using System;
using DarkSide.Library.Enum;
using DarkSide.Library.Interface;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DarkSide.Library.Abstract
{
    public class Game : IGame
    {
        #region Fields

        private readonly Timer _elapsedTimer = new Timer { Interval = 1000 };
        private readonly Timer _moveTimer = new Timer { Interval = 100 };
        private TimeSpan _elapsedTime;

        private readonly Panel _deathstarPanel;
        private DeathStar _deathStar;

        private readonly Panel _battleFieldPanel;

        private readonly List<Bullet> _bullets = new List<Bullet>();


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

        public Game(Panel deathstarPanel, Panel battleFieldPanel)
        {
            _deathstarPanel = deathstarPanel;
            _battleFieldPanel = battleFieldPanel;

            _elapsedTimer.Tick += ElapsedTimer_Tick;
            _moveTimer.Tick += MoveTimer_Tick;
        }

        private void ElapsedTimer_Tick(object sender, EventArgs e)
        {
            ElapsedTime += TimeSpan.FromSeconds(1);
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            MoveBullets();
        }

        private void MoveBullets()
        {
            Console.WriteLine(_bullets.Count);

            for (int i = _bullets.Count - 1; i >= 0; i--)
            {
                var bullet = _bullets[i];
                var didItHit = bullet.MoveIt(Direction.up);
                if (didItHit)
                {
                    _bullets.Remove(bullet);
                    _battleFieldPanel.Controls.Remove(bullet);
                }
            }
        }

        public void Start()
        {
            if (DoesItContinue) return;

            DoesItContinue = true;
            StartTimers();
            CreateDeathStar();
        }

        private void StartTimers()
        {
            _elapsedTimer.Start();
            _moveTimer.Start();
        }

        private void CreateDeathStar()
        {
            _deathStar = new DeathStar(_deathstarPanel.Width, _deathstarPanel.Size);
            _deathstarPanel.Controls.Add(_deathStar);
        }

        private void Finish()
        {
            if (!DoesItContinue) return;

            DoesItContinue = false;
            StopTimers();
        }

        private void StopTimers()
        {
            _elapsedTimer.Stop();
            _moveTimer.Stop();
        }

        public void Fire()
        {
            if (!DoesItContinue) return;

            var bullet = new Bullet(_battleFieldPanel.Size, _deathStar.Center);
            _bullets.Add(bullet);
            _battleFieldPanel.Controls.Add(bullet);
           
        }

        public void Move(Direction direction)
        {
            if (!DoesItContinue) return;
                      
            _deathStar.MoveIt(direction);
        }

        #endregion
    }
}

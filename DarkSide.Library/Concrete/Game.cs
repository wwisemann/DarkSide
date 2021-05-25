using System;
using DarkSide.Library.Enum;
using DarkSide.Library.Interface;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace DarkSide.Library.Concrete
{
    public class Game : IGame
    {
        #region Fields

        private readonly Timer _elapsedTimer = new Timer { Interval = 1000 };
        private readonly Timer _moveTimer = new Timer { Interval = 100 };
        private readonly Timer _enemyTimer = new Timer { Interval = 3000 };
        private TimeSpan _elapsedTime;

        private readonly Panel _deathstarPanel;
        private DeathStar _deathStar;

        private readonly Panel _battleFieldPanel;

        private readonly List<Bullet> _bullets = new List<Bullet>();
        private readonly List<TieFighter> _tieFighters = new List<TieFighter>();
        private float _speed = 0.2f;
        private int _score = 0;


        #endregion

        #region Events

        public event EventHandler ElapsedTimeHasChanged;
        public event EventHandler<int> ScoreHasChanged;

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
            _enemyTimer.Tick += EnemyTimer_Tick;

        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            CreateTieFighter();
        }

        private void ElapsedTimer_Tick(object sender, EventArgs e)
        {
            ElapsedTime += TimeSpan.FromSeconds(1);
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            MoveBullets();
            MoveTieFighters();
        }

        private void MoveBullets()
        {
            for (int i = _bullets.Count - 1; i >= 0; i--)
            {
                var bullet = _bullets[i];
                var didItHitCeil = bullet.MoveIt(Direction.up);
                if (didItHitCeil)
                {
                    _bullets.Remove(bullet);
                    _battleFieldPanel.Controls.Remove(bullet);
                }
                else
                {
                    TieFighter hitTieFighter = FindHitTieFighter(bullet);
                    if (hitTieFighter != null)
                    {
                        _bullets.Remove(bullet);
                        _battleFieldPanel.Controls.Remove(bullet);
                        _tieFighters.Remove(hitTieFighter);
                        _battleFieldPanel.Controls.Remove(hitTieFighter);
                        _score += 5;
                        ScoreHasChanged.Invoke(this, _score);

                        ChangeDifficulty();
                    }
                }
            }
        }
        private TieFighter FindHitTieFighter(Bullet bullet)
        {
            for (int i = _tieFighters.Count - 1; i >= 0; i--)
            {
                var tieFighter = _tieFighters[i];

                if (tieFighter.Center != bullet.Center)
                    continue;

                if (tieFighter.Middle > (bullet.Middle - bullet.Height/2))
                    return tieFighter;

            }

            return null;
        }
        private void MoveTieFighters()
        {
            for (int i = _tieFighters.Count - 1; i >= 0; i--)
            {
                var tieFighter = _tieFighters[i];
                var didItHit = tieFighter.MoveIt(Direction.down);
                if (didItHit)
                {
                    Finish();
                    //todo: game over ekranı ekle
                    //todo: skoru kaydet
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

        private void CreateTieFighter()
        {
            var tieFighter = new TieFighter(_battleFieldPanel.Size, _battleFieldPanel.Size.Width, _speed);
            _tieFighters.Add(tieFighter);
            _battleFieldPanel.Controls.Add(tieFighter);
        }


        private void StartTimers()
        {
            _elapsedTimer.Start();
            _moveTimer.Start();
            _enemyTimer.Start();
        }

        private void CreateDeathStar()
        {
            _deathStar = new DeathStar(_deathstarPanel.Width, _deathstarPanel.Size);
            _deathstarPanel.Controls.Add(_deathStar);
        }

        public void Pause()
        {
            if(DoesItContinue)
            {
                StopTimers();
            }
            else
            {
                StartTimers();
            }
            DoesItContinue = !DoesItContinue;
        }
        public void ShowScoreboard()
        {
            //todo:
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
            _enemyTimer.Stop();
            
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
        public void ChangeDifficulty()
        {
            _speed = _score / 150.0f + 0.2f;
        }

        #endregion
    }
}

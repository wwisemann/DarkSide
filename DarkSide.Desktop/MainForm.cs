/************************************************************
*****                                                   *****
*****           Arifcan Yılmaz  - b201200048            *****
*****             NDP Uçaksavar Projesi                 *****
*****                                                   *****
*************************************************************/

using System;
using DarkSide.Library.Concrete;
using DarkSide.Library.Enum;
using System.Windows.Forms;

namespace DarkSide.Desktop
{
    public partial class MainForm : Form
    {
        private readonly Game _game;

        public MainForm()
        {
            InitializeComponent();

            _game = new Game(deathstarPanel,battleFieldPanel);
            _game.ElapsedTimeHasChanged += Game_ElapsedTimeHasChanged;
            _game.ScoreHasChanged += Game_ScoreHasChanged;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _game.Start();
                    break;
                case Keys.Right:
                    _game.Move(Direction.right);
                    break;
                case Keys.Left:
                    _game.Move(Direction.left);
                    break;
                case Keys.Space:
                    _game.Fire();
                    break;
                case Keys.P:
                    _game.Pause();
                    break;
                case Keys.Tab:
                    ShowScoreboard();
                    break;
            }
        }

        private void Game_ElapsedTimeHasChanged(object sender, EventArgs e)
        {
            timeLabel.Text = _game.ElapsedTime.ToString(@"m\:ss");
        }

        private void Game_ScoreHasChanged(object sender, int score)
        {
            lbl_Score.Text = score.ToString();
        }

        public void ShowScoreboard()
        {
            ScoreBoard frm = new ScoreBoard();
            frm.ShowDialog();
        }
    }
}

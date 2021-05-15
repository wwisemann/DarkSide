using System;
using DarkSide.Library.Abstract;
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
            }
        }

        private void Game_ElapsedTimeHasChanged(object sender, EventArgs e)
        {
            timeLabel.Text = _game.ElapsedTime.ToString(@"m\:ss");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

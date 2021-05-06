using DarkSide.Library.Concrete;
using DarkSide.Library.Enum;
using System.Windows.Forms;

namespace DarkSide.Desktop
{
    public partial class MainForm : Form
    {
        private readonly Game _game = new Game();
        public MainForm()
        {
            InitializeComponent();
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
    }
}

using System;
using System.Collections.Generic;
using System.IO;


using System.Linq;

using System.Windows.Forms;

namespace DarkSide.Desktop
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            string fileName = "BestFiveScores";
            

            if (!File.Exists(fileName))
            {
                
                File.WriteAllLines(fileName, new List<string>() { "0", "0", "0", "0", "0" });
            }
            
            List<string> lines = File.ReadAllLines(fileName).ToList();

            List<Label> bestfivescores = new List<Label>();

            foreach (Label item in panel2.Controls)
            {
                bestfivescores.Add(item);
            }
            for (int i = 0; i < 5; i++)
            {
                bestfivescores[(4 - i)].Text = lines[i];
            }
            
        }
    }
}

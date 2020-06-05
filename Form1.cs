using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimTrainer
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ClickButton.Visible = true;
            ScoreLabel.Visible = true;
            StartButton.Visible = false;
            QuitButton.Visible = false;
            PauseButton.Visible = true;
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            ClickButton.Width = rand.Next(40, 150);
            ClickButton.Height = ClickButton.Width;
            ClickButtonMove();
            score += 1;
            UpdateScoreLabel();
            ClickButtonSize();
        }

        private void ClickButtonSize()
        {
            ClickButton.Width = rand.Next(40, 160);
            ClickButton.Height = ClickButton.Width;
        }

        private void ClickButtonMove()
        {
            ClickButton.Top = rand.Next(40, 450);
            ClickButton.Left = rand.Next(40, 950);
            
        }
        private void UpdateScoreLabel()
        {
            ScoreLabel.Text = "Score "+ score;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            QuitButton.Visible = true;
        }
        
        

        
        
    }
}

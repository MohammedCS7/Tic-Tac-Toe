using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        public enum Turn
        {
            Player1 = 1,Player2 = 2,GameOver = 3
        }
        public enum WinState
        {
            Player1 = 1, Player2 = 2, Draw = 3,InProgress = 4
        }

        struct GameInfo
        {
            public Turn turn;
            public WinState winner;
            public int PlayCount;
        }

        GameInfo game;


        public Form1()
        {
            InitializeComponent();
            game.winner = WinState.InProgress;
            game.turn = Turn.Player1;
            game.PlayCount = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen pen = new Pen(White);
            pen.Width = 5;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 500, 50, 500, 400);
            e.Graphics.DrawLine(pen, 650, 50, 650, 400);
            e.Graphics.DrawLine(pen, 350, 150, 800, 150);
            e.Graphics.DrawLine(pen, 350, 280, 800, 280);
        }

        //void ChangeTurn()
        //{
        //    if (game.turn == Turn.Player1)
        //    {
        //        lblTurn.Text = "Player1";
        //        game.turn = Turn.Player2;
        //    }
        //    else if (game.turn == Turn.Player2)
        //    {
        //        lblTurn.Text = "Player2";
        //        game.turn = Turn.Player1;
        //    }
               
    
        //}

        bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if(btn1.Tag.ToString() != "Q" && btn1.Tag == btn2.Tag && btn2.Tag == btn3.Tag)
            {
                game.winner = (btn1.Tag.ToString() == "X") ? WinState.Player1 : WinState.Player2;
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;
                return true;
            }
            return false;
        }

        bool CheckWin()
        {
            return (CheckValues(button1, button2, button3) || CheckValues(button4, button5, button6) || CheckValues(button7, button8, button9)
                 || CheckValues(button1, button4, button7) || CheckValues(button2, button5, button8) || CheckValues(button3, button6, button9)
                 || CheckValues(button1, button5, button9) || CheckValues(button3, button5, button7)
                     );
        }

        void GameOver()
        {
            foreach(Control c in Controls)
            {
                if(c is PictureBox pb)
                pb.Enabled = false;
            }
            game.turn = Turn.GameOver;
            lblTurn.Text = "Game Over";
            string message = (game.winner == WinState.Draw) ? "It's a Draw!" : "The Winner is: " + game.winner.ToString();
            lblWinner.Text = game.winner.ToString();
            game.PlayCount = 0;
            MessageBox.Show(message, "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Restart()
        {
            foreach (Control c in Controls)
            {
                if (c is Button btn)
                {
                    if (btn != btnRestart)
                    {
                        btn.BackColor = Color.Black;
                        btn.Tag = "Q";
                        btn.Image = Resources.question_mark_96;
                    }
                }
            }
            game.turn = Turn.Player1;
            game.winner = WinState.InProgress;
            lblWinner.Text = "In Progress";
            lblTurn.Text = "Player1";
        }

        void ChangeButton(Button btn)
        {
            switch (game.turn)
            {
                case Turn.Player1:
                    btn.Image = Resources.X;
                    btn.Tag = "X";
                    game.turn = Turn.Player2;
                    break;
                case Turn.Player2:
                    btn.Image = Resources.O;
                    btn.Tag = "O";
                    game.turn = Turn.Player1;
                    break;
            }
            game.PlayCount++;
            lblTurn.Text = game.turn.ToString();
                if(CheckWin())
                    GameOver();
            else if(game.PlayCount == 9)
            {
                game.winner = WinState.Draw;
                GameOver();
            }

        }

     

        private void pb5_MouseHover(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.Black;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Tag.ToString() != "Q")
                {
                    MessageBox.Show("Box Already Taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ChangeButton(btn);
            }
        }

        private void Buttons_Mouse_Up(object sender, MouseEventArgs e)
        {
            
        }

        private void Buttons_Mouse_Enter(object sender, EventArgs e)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turnX = true;
        int turns = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckWin()
        {
            bool gameOver = false;

            if ((b1.Text == b2.Text) && (b1.Text == b3.Text) && (!b1.Enabled))
                gameOver = true; 
            if ((b4.Text == b5.Text) && (b4.Text == b6.Text) && (!b4.Enabled))
                gameOver = true; 
            if ((b7.Text == b8.Text) && (b7.Text == b9.Text) && (!b7.Enabled))
                gameOver = true;

            if ((b1.Text == b4.Text) && (b1.Text == b7.Text) && (!b1.Enabled))
                gameOver = true;
            if ((b2.Text == b5.Text) && (b2.Text == b8.Text) && (!b2.Enabled))
                gameOver = true;
            if ((b3.Text == b6.Text) && (b3.Text == b9.Text) && (!b3.Enabled))
                gameOver = true;

            if ((b1.Text == b5.Text) && (b1.Text == b9.Text) && (!b1.Enabled))
                gameOver = true;
            if ((b3.Text == b5.Text) && (b3.Text == b7.Text) && (!b3.Enabled))
                gameOver = true;

            if (gameOver == true)
            {
                String winner;
                if (turnX)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + " wins!");

                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                b6.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
            }
            else
            {
                if (turns == 9)
                    MessageBox.Show("Draw!");
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;
            if (turnX)
                pressed.Text = "X";
            else
                pressed.Text = "O";

            turns++;
            turnX = !turnX;
            pressed.Enabled = false;
            CheckWin();
        }            

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            turnX = true;
            turns = 0;                     

            b1.Text = "";
            b1.Enabled = true;
            b2.Text = "";
            b2.Enabled = true;
            b3.Text = "";
            b3.Enabled = true;
            b4.Text = "";
            b4.Enabled = true;
            b5.Text = "";
            b5.Enabled = true;
            b6.Text = "";
            b6.Enabled = true;
            b7.Text = "";
            b7.Enabled = true;
            b8.Text = "";
            b8.Enabled = true;
            b9.Text = "";
            b9.Enabled = true;
        }
    }
}

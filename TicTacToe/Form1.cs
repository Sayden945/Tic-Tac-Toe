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
        public bool playerTurn = true;
        public int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
                Button btnClick = (Button)sender;
            
                if (playerTurn)
                {
                    btnClick.Text = "X";
                    Console.WriteLine($"Player turn? {playerTurn}");
                }
                else
                {
                    btnClick.Text = "O";
                    Console.WriteLine($"Player turn? {playerTurn}");
                }

                btnClick.Enabled = false;
                
                checkWin();
                playerTurn = !playerTurn;



        }

        private void TurnCount() 
        {
            turnCount++;
            if (turnCount >= 9)
            {
                MessageBox.Show("Draw!");
                Reset();
            }
        }

        private void checkWin()
        {
            bool winner = false;

            //Diagonal wins
            //Checks if each corner matches middle button
            //Middle value must not be enabled
            if      (!btnB2.Enabled && (btnA1.Text == btnB2.Text) && (btnB2.Text == btnC3.Text))
            {winner = true; }
            else if (!btnB2.Enabled && (btnC1.Text == btnB2.Text) && (btnB2.Text == btnA3.Text))
            {winner = true;}

            //Horizontal wins
            if      (!btnA2.Enabled && (btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text))
            {winner = true;}
            else if (!btnB2.Enabled && (btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text))
            {winner = true;}
            else if (!btnC2.Enabled && (btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text))
            {winner = true;}

            //Vertical wins
            if      (!btnB1.Enabled && (btnA1.Text == btnB1.Text) && (btnB1.Text == btnC1.Text))
            { winner = true; }
            else if (!btnB2.Enabled && (btnA2.Text == btnB2.Text) && (btnB2.Text == btnC2.Text))
            { winner = true; }
            else if (!btnB3.Enabled && (btnA3.Text == btnB3.Text) && (btnB3.Text == btnC3.Text))
            { winner = true; }

            if (winner)
            {
                Win();
            }
        }

        private void Win()
        {
            if (playerTurn) { MessageBox.Show($"X is the winner!"); }
            else { MessageBox.Show($"O is the winner!"); }

            Reset();
        }

        private void Reset()
        {
            foreach(Control button in Controls)
            {
                if(button != btnNG)
                {
                    button.Enabled = true;
                    button.Text = "";
                }

                turnCount = 0;
                playerTurn = true;
            }
        }

        private void btnNG_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}

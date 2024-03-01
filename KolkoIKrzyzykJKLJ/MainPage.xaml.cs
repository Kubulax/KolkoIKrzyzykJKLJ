using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KolkoIKrzyzykJKLJ
{
    public partial class MainPage : ContentPage
    {
        int turns = 0;
        string currentPlayer = "×";
        bool hasWinner = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void DrawSymbol(object sender, EventArgs e)
        {
            Button field = sender as Button;

            if (!hasWinner && turns < 9 && String.IsNullOrWhiteSpace(field.Text)) 
            {          
                field.Text = currentPlayer;
                turns++;

                if (currentPlayer == "×")
                {
                    lbl_Player.Text = "Teraz gra: ○";
                }
                else if (currentPlayer == "○")
                {
                    lbl_Player.Text = "Teraz gra: ×";
                }

                CheckForWinner();

                if (currentPlayer == "×")
                {
                    currentPlayer = "○";
                }
                else if (currentPlayer == "○")
                {
                    currentPlayer = "×";
                }
            }
        }

        private void CheckForWinner()
        {
            if (
                btn_R0_C0.Text == currentPlayer &&
                btn_R0_C1.Text == currentPlayer &&
                btn_R0_C2.Text == currentPlayer
                )
            {
                btn_R0_C0.TextColor = Color.Blue;
                btn_R0_C1.TextColor = Color.Blue;
                btn_R0_C2.TextColor = Color.Blue;

                hasWinner = true;
            }
            else if(
                btn_R1_C0.Text == currentPlayer &&
                btn_R1_C1.Text == currentPlayer &&
                btn_R1_C2.Text == currentPlayer
                )
            {
                btn_R1_C0.TextColor = Color.Blue;
                btn_R1_C1.TextColor = Color.Blue;
                btn_R1_C2.TextColor = Color.Blue;

                hasWinner = true;
            }
            else if (
                btn_R2_C0.Text == currentPlayer &&
                btn_R2_C1.Text == currentPlayer &&
                btn_R2_C2.Text == currentPlayer
                )
            {
                btn_R2_C0.TextColor = Color.Blue;
                btn_R2_C1.TextColor = Color.Blue;
                btn_R2_C2.TextColor = Color.Blue;

                hasWinner = true;
            }

            else if (
                btn_R0_C0.Text == currentPlayer &&
                btn_R1_C0.Text == currentPlayer &&
                btn_R2_C0.Text == currentPlayer
                )
            {
                btn_R0_C0.TextColor = Color.Blue;
                btn_R1_C0.TextColor = Color.Blue;
                btn_R2_C0.TextColor = Color.Blue;

                hasWinner = true;
            }
            else if (
                btn_R0_C1.Text == currentPlayer &&
                btn_R1_C1.Text == currentPlayer &&
                btn_R2_C1.Text == currentPlayer
                )
            {
                btn_R0_C1.TextColor = Color.Blue;
                btn_R1_C1.TextColor = Color.Blue;
                btn_R2_C1.TextColor = Color.Blue;

                hasWinner = true;
            }
            else if (
                btn_R0_C2.Text == currentPlayer &&
                btn_R1_C2.Text == currentPlayer &&
                btn_R2_C2.Text == currentPlayer
                )
            {
                btn_R0_C2.TextColor = Color.Blue;
                btn_R1_C2.TextColor = Color.Blue;
                btn_R2_C2.TextColor = Color.Blue;

                hasWinner = true;
            }

            else if (
                btn_R0_C0.Text == currentPlayer &&
                btn_R1_C1.Text == currentPlayer &&
                btn_R2_C2.Text == currentPlayer
                )
            {
                btn_R0_C0.TextColor = Color.Blue;
                btn_R1_C1.TextColor = Color.Blue;
                btn_R2_C2.TextColor = Color.Blue;

                hasWinner = true;
            }
            else if (
                btn_R0_C2.Text == currentPlayer &&
                btn_R1_C1.Text == currentPlayer &&
                btn_R2_C0.Text == currentPlayer
                )
            {
                btn_R0_C2.TextColor = Color.Blue;
                btn_R1_C1.TextColor = Color.Blue;
                btn_R2_C0.TextColor = Color.Blue;

                hasWinner = true;
            }

            if ( hasWinner )
            {
                DisplayAlert("Koniec gry", "Wygrał " + currentPlayer, "OK");
                lbl_Player.Text = "Wygrywa: " + currentPlayer;
                return;
            }

            if ( !hasWinner && turns == 9)
            {
                DisplayAlert("Koniec gry", "Remis", "OK");
                lbl_Player.Text = "Remis";
                return;
            }

        }

        private void ResetRound(object sender, EventArgs e)
        {
            ResetRoundStatus();
        }

        private void ResetGame(object sender, EventArgs e)
        {
            ResetRoundStatus();
        }

        private void ResetRoundStatus()
        {
            btn_R0_C0.Text = "";
            btn_R0_C1.Text = "";
            btn_R0_C2.Text = "";
            btn_R1_C0.Text = "";
            btn_R1_C1.Text = "";
            btn_R1_C2.Text = "";
            btn_R2_C0.Text = "";
            btn_R2_C1.Text = "";
            btn_R2_C2.Text = "";

            btn_R0_C0.TextColor = Color.Black;
            btn_R0_C1.TextColor = Color.Black;
            btn_R0_C2.TextColor = Color.Black;
            btn_R1_C0.TextColor = Color.Black;
            btn_R1_C1.TextColor = Color.Black;
            btn_R1_C2.TextColor = Color.Black;
            btn_R2_C0.TextColor = Color.Black;
            btn_R2_C1.TextColor = Color.Black;
            btn_R2_C2.TextColor = Color.Black;

            turns = 0;
            currentPlayer = "×";
            hasWinner = false;
            lbl_Player.Text = "Teraz gra: ×";
        }
    }
}

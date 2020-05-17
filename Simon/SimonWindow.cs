using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class SimonWindow : Form
    {
        // preferences
        // later will be in configuration file
        const int MAX_NUMBER_OF_RANDOM = 4;
        const int TIME_BEFORE_CLEAR_NUMBERS = 1000;
        const int SEQUENCE_MAX_LENGTH = 8;
        const bool CHEAT_MODE = true;
        const string WIN_STRING = "You won!! what a great memory!!! you're the best!";
        const string LOOSE_STRING = "Wrong ..... sorry ....";
        const string WRONG_NUMBER_STRING = "You chose {0} the correct number was {1}";
        const string START_USER_INPUT_STRING = "Please start the sequence...";
        const string DO_YOU_WANT_TO_PLAY_AGAIN_STRING = "Do you want to play again? (Y-yes, N-no)";

        const int RED = 1;
        const int YELLOW = 2;
        const int BLUE = 3;
        const int GREEN = 4;

        // globals
        int round = 1;
        int user_sequence_index = 0;
        int[] sequence_numbers;
        Random random_generator = new Random();
        bool wait_for_player = false;

        public SimonWindow()
        {
            InitializeComponent();
        }

        private void GenerateRandomSequence()
        {
            sequence_numbers = new int[SEQUENCE_MAX_LENGTH];

            for (int i = 0; i < SEQUENCE_MAX_LENGTH; i++)
            {
                sequence_numbers[i] = random_generator.Next(1, MAX_NUMBER_OF_RANDOM + 1);
            }
        }

        private void DrawEntireSequence()
        {
            for (int i = 0; i < sequence_numbers.Length; i++)
            {
                //const int RED = 1;
                //const int YELLOW = 2;
                //const int BLUE = 3;
                //const int GREEN = 4;

                switch (sequence_numbers[i])
                {
                    case RED:
                        redPnl.BackColor = Color.Black;
                        Thread.Sleep(500);
                        redPnl.BackColor = Color.Red;
                        break;
                    case YELLOW:
                        yellowPnl.BackColor = Color.Black;
                        Thread.Sleep(500);
                        yellowPnl.BackColor = Color.Yellow;
                        break;
                    case BLUE:
                        bluePnl.BackColor = Color.Black;
                        Thread.Sleep(500);
                        bluePnl.BackColor = Color.Blue;
                        break;
                    case GREEN:
                        Color saveColor = greenPnl.BackColor;
                        greenPnl.BackColor = Color.Black;
                        Thread.Sleep(500);
                        greenPnl.BackColor = saveColor;
                        break;
                }

                Thread.Sleep(500);
            }

        }
        private void PlayOneNote(int color)
        {
            //const int RED = 1;
            //const int YELLOW = 2;
            //const int BLUE = 3;
            //const int GREEN = 4;
            switch (color)
            {
                case RED:
                    redPnl.BackColor = Color.Black;
                    Thread.Sleep(500);
                    redPnl.BackColor = Color.Red;
                    break;
                case YELLOW:
                    yellowPnl.BackColor = Color.Black;
                    Thread.Sleep(500);
                    yellowPnl.BackColor = Color.Yellow;
                    break;
                case BLUE:
                    bluePnl.BackColor = Color.Black;
                    Thread.Sleep(500);
                    bluePnl.BackColor = Color.Blue;
                    break;
                case GREEN:
                    Color saveColor = greenPnl.BackColor;
                    greenPnl.BackColor = Color.Black;
                    Thread.Sleep(500);
                    greenPnl.BackColor = saveColor;
                    break;
            }
            Thread.Sleep(500);

        }
        private void PlayCurrentRoundSequence()
        {
            if (wait_for_player)
            {
                Thread.Sleep(1000);
            }
            // round
            // round = 1, play index 0
            // round = 2, play index 0 1
            // round = 3, play index 0 1 2 
            // sequence_numbers: 2,3,3,2,2,3,1,4,4,4 ...
            for (int i = 0; i < round; i++)
            {
                PlayOneNote(sequence_numbers[i]);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            GenerateRandomSequence();
            round = 1;
            user_sequence_index = 0;
            wait_for_player = false;
            // generate new worker
            //Task.Run(new Action(DrawEntireSequence));
            roundLbl.Text = "1";
            Task.Run(new Action(PlayCurrentRoundSequence));

        }

        private void SimonWindow_Load(object sender, EventArgs e)
        {

        }

        private void AnyPnl_Click(object sender, EventArgs e)
        {
            //const int RED = 1;
            //const int YELLOW = 2;
            //const int BLUE = 3;
            //const int GREEN = 4;

            // short way
            int number_on_panel_tag = Convert.ToInt32((sender as Panel).Tag);

            // long way -- 4 ifs
            // int number_clicked;
            //if (sender == redPnl)
            //{
            // user clicked red panel == 1
            // number_clicked = 1;
            //}

            wait_for_player = true;
            Task.Run(() => { PlayOneNote(number_on_panel_tag); });

            if (number_on_panel_tag == sequence_numbers[user_sequence_index])
            {
                // clicked correct
                user_sequence_index++;

                //new Thread(() =>
                //{
                //    PlayOneNote(number_on_panel_tag);
                //}).Start();
                //Thread.Sleep(1000);

                if (user_sequence_index == round)
                {
                    user_sequence_index = 0;
                    round++;
                    roundLbl.Text = round.ToString();
                    if (round > SEQUENCE_MAX_LENGTH)
                    {
                        roundLbl.Text = "winner !!!!!";
                        MessageBox.Show("Win", "You won!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        Task.Run(new Action(PlayCurrentRoundSequence));
                    }
                }
            }
            else
            {
                // clicked wrong!!
                MessageBox.Show("Game over", "wrong ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                startBtn_Click(null, null);
            }
        }
    }
}

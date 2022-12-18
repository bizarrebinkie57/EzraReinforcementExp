using System.CodeDom;
using System.Media;
using System.Text.RegularExpressions;


namespace EzraReinforcementExp
{

    public partial class FrmQuiz : Form
    {
        private GameManager game;

        public FrmQuiz()
        {
            InitializeComponent();

            game = new GameManager();

        }

        private void TbResponse_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoundPlayer soundPlayer;
            String soundFile = "";

            // when the user presses enter
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                TbResponse.Enabled = false;

                // check their answer
                if (game.CheckAnswer(TbResponse.Text))
                {

                    PbCheck.Visible = true;
                    
                    if (game.POSITIVE_MODE)
                    {
             
                        switch (new Random().Next(2)) {
                            case 0:
                                soundFile = @"Resources\mixkit-retro-game-notification-212.wav";
                                break;
                            case 1:
                                soundFile = @"Resources\mixkit-small-crowd-ovation-437.wav";
                                break;
                        }
                        soundPlayer = new SoundPlayer(soundFile);
                        soundPlayer.Play();

                    } else
                    {
                        // nothing special
                    }

                    // move the element to mastered
                    game.AdvanceQuestion();

                } else {
                    //TbResponse.Font.Strikeout = true;

                    pbX.Visible = true;

                    if (game.POSITIVE_MODE)
                    {
                        // nothing special
                    }
                    else
                    {
                        switch (new Random().Next(2))
                        {
                            case 0:
                                soundFile = @"Resources\mixkit-crowd-laugh-424.wav";
                                break;
                            case 1:
                                soundFile = @"Resources\mixkit-arcade-retro-game-over-213.wav";
                                break;
                        }
                        soundPlayer = new SoundPlayer(soundFile);
                        soundPlayer.Play();
                    }

                    Lblcorrectanswer.Text = game.Question.Name;
                }

                LblReinforcement.Text = game.Reinforcment();

                // turn on the timer
                timer.Enabled = true;
                e.Handled = true;
            }
        }

        private void FrmQuiz_Load(object sender, EventArgs e)
        {

            nextQuestion();

            // start the game timer
            GameTimer.Interval = 1000 * 60 * game.QUIZ_MINUTES;
            GameTimer.Enabled = true;

        }

        private void nextQuestion()
        {
            // get the next qestion
            game.NextQuestion();

            // clear the text
            Lblcorrectanswer.Text = "";
            LblReinforcement.Text = "";
            TbResponse.Text = "";
            PbCheck.Visible = false;
            pbX.Visible = false;

            // show the question
            LblQuestion.Text = "What is the name of element " + game.Question.Symbol + "?";

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            nextQuestion();
            TbResponse.Enabled = true;
            TbResponse.Select();
            TbResponse.Focus();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            TbResponse.Enabled = false;
            LblQuestion.Text = "Game over. You mastered " + game.TotalMastered() + " elements";
            LblReinforcement.Text = "";
            Lblcorrectanswer.Text = "";
        }

        
    }

}
using System.CodeDom;
using System.Text.RegularExpressions;



namespace EzraReinforcementExp
{


    public partial class FrmQuiz : Form
    {
        private List<ElementQuestion> allQuestions;
        private List<ElementQuestion> currentQuestions;
        private List<ElementQuestion> masteredQuestions;
        private ElementQuestion question;

        const int WORKING_POOL_SIZE = 4;
        const int QUIZ_MINUTES = 1;
        const bool POSITIVE_MODE = true;
        readonly string[] CORRECT_POSITIVES = { "Correct,You're smart!", "Correct,You're good!", "Correct,That was really smart!" };
        readonly string[] INCORRECT_POSITIVES = { "Incorrect, Keep trying!" };
        readonly string[] CORRECT_NEGATIVES = { "Correct, It's about time." };
        readonly string[] INCORRECT_NEGATIVES = { "Incorrect,You're dumb!", "Incorrect,You're bad!", "Incorrect Are You Even Trying", "Incorrect,Youre bad at this!" };


        public FrmQuiz()
        {
            InitializeComponent();

            // initialize
            allQuestions = new List<ElementQuestion>();
            currentQuestions = new List<ElementQuestion>();
            masteredQuestions = new List<ElementQuestion>();

            //import elements
            using (StreamReader reader = new StreamReader(@"C:\Users\ezral\Unity\elements.csv"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    //Define pattern
                    Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                    //Separating columns to array
                    string[] X = CSVParser.Split(line);

                    //Debug.Log(X[0]);
                    ElementQuestion eq = new()
                    {
                        name = X[0],
                        symbol = X[1]
                    };
                    allQuestions.Add(eq);

                }
            }
        }

        private void TbResponse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                TbResponse.Enabled = false;

                // check their answer
                if (String.Equals(TbResponse.Text, question.name, StringComparison.OrdinalIgnoreCase))
                {

                    if (POSITIVE_MODE)
                    {
                        LblReinforcement.Text = CORRECT_POSITIVES[new Random().Next(0, CORRECT_POSITIVES.Length)];
                    } else
                    {
                        LblReinforcement.Text = CORRECT_NEGATIVES[new Random().Next(0, CORRECT_NEGATIVES.Length)];
                    }

                    // move the element to mastered
                    masteredQuestions.Add(question);
                    currentQuestions.Remove(question);
                    FillupCurrentQuestions();
                } else {
                    //TbResponse.Font.Strikeout = true;

                    if (POSITIVE_MODE)
                    {
                        LblReinforcement.Text = INCORRECT_POSITIVES[new Random().Next(0, INCORRECT_POSITIVES.Length)];
                    }
                    else
                    {
                        LblReinforcement.Text = INCORRECT_NEGATIVES[new Random().Next(0, INCORRECT_NEGATIVES.Length)];
                    }

                    Lblcorrectanswer.Text = question.name;
                }

                // turn on the timer
                timer.Enabled = true;
            }
        }

        private void FrmQuiz_Load(object sender, EventArgs e)
        {

            // load up the current pool
            FillupCurrentQuestions();

            // start the first question
            nextQuestion();

            // start the game timer
            GameTimer.Interval = 1000 * 60 * QUIZ_MINUTES;
            GameTimer.Enabled = true;

        }

        private void nextQuestion()
        {
            // get our first question
            int randomQuestionIndex = new Random().Next(0, currentQuestions.Count);
            question = currentQuestions[randomQuestionIndex];

            // clear the text
            Lblcorrectanswer.Text = "";
            LblReinforcement.Text = "";
            TbResponse.Text = "";

            // show the question
            LblQuestion.Text = "What is the name of element " + question.symbol + "?";

        }


        private void FillupCurrentQuestions()
        {
            while (currentQuestions.Count < WORKING_POOL_SIZE)
            {
                if (allQuestions.Count == 0) break; // we're out of questions!

                int randomQuestionIndex = new Random().Next(0, allQuestions.Count);
                currentQuestions.Add(allQuestions[randomQuestionIndex]);
                allQuestions.Remove(allQuestions[randomQuestionIndex]);
            }
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
            LblQuestion.Text = "Game over. You mastered " + masteredQuestions.Count + " elements";
            LblReinforcement.Text = "";
            Lblcorrectanswer.Text = "";
        }

        
    }

}
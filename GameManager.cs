using System.Collections;
using System.Collections.Generic;
using System.Linq;


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

/*
namespace EzraReinforcementExp
{
    public class GameManager
    {

        public Question[] questions;
        private static List<Question> unansweredQuestions;

        private Question currentQuestion;

        public ElementQuestion[] elementQuestions;
        public List<ElementQuestion> unansweredElementQuestions;
        //private static List<ElementQuestion> unansweredElementQuestions;
        private ElementQuestion currentElementQuestion;

        private float timeBetweenQuestions = 1f;

        void Start()
        {

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
                    ElementQuestion eq = new ElementQuestion();
                    eq.name = X[0];
                    eq.symbol = X[1];
                    unansweredElementQuestions.Add(eq);

                }
            }

            if (unansweredQuestions == null || unansweredQuestions.Count == 0)
            {
                unansweredQuestions = questions.ToList<Question>();
            }

            SetCurrentQuestion();

        }


        void SetCurrentQuestion()
        {
            int randomQuestionIndex = new Random().Next(0, unansweredQuestions.Count);
            currentQuestion = unansweredQuestions[randomQuestionIndex];

            //factText.text = currentQuestion.fact;

        }


    }

    public class Question
    {

        public string fact;
        public bool isTrue;

    }




}

*/
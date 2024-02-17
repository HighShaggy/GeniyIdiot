using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GeniyIdiotWindowsForms
{
    public partial class testForm : Form
    {


        List<Question> questions;
        Question currentQuestion;

        public double countRightAnswers = 0;

        public double questionsCount;

        public int questionNumber = 1;

        public int randomNumber = 0;

        public string username = "Имя неизвестно,";

        public int rightAnswer = -1;

        public int count = 0;

        public testForm()
        {
            InitializeComponent();
        }


        private void testForm_Load(object sender, EventArgs e)
        {
            questions = QuestionHub.GetHub();
            questionsCount = questions.Count;
            ShowNextQuestion();
        }




        public static int[] GetRandomIndex(int length)
        {
            var array = new int[length];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
            return array;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ShowNextQuestion();
        }

        public void ShowNextQuestion()
        {
            var allQuestionsIndex = QuestionStorage.GetRandomIndex(questions.Count);

            int userAnswer;
            count++;

            bool GetNumber = int.TryParse(userAnswerText.Text, out userAnswer);
            if (GetNumber != true && count > 1)
            {
                MessageBox.Show("Введите число");
            }
            else
            {

                if (userAnswer == rightAnswer)
                {
                    countRightAnswers++;
                }
                userAnswerText.Clear();

                if (questions.Count == 0)
                {
                    var percentRightAnswers = Convert.ToDouble((countRightAnswers / questionsCount) * 100);
                    Close();
                    MessageBox.Show(username + " спасибо за прохождение теста! Ваш диагноз: " + QuestionHub.GetFinalDiagnosis(percentRightAnswers));
                    User user = new User(username, Convert.ToInt32(countRightAnswers), QuestionHub.GetFinalDiagnosis(percentRightAnswers));
                    UserResult.SaveResult(user);

                    return;
                }

                Random random = new Random();
                var randomQuestionIndex = allQuestionsIndex[random.Next(0, questions.Count)];
                var question = questions[randomQuestionIndex].NameQuestion;
                rightAnswer = questions[randomQuestionIndex].CountAnswer;
                currentQuestion = questions[randomQuestionIndex];
                questions.Remove(currentQuestion);
                numberQuestion.Text = "Вопрос № " + questionNumber++;
                textQuestion.Text = question;
            }
        }
        private void acceptName_Click(object sender, EventArgs e)
        {
            var userAnswername = textUsername.Text;
            username = userAnswername;
            textUsername.Clear();
        }

        
    }
}

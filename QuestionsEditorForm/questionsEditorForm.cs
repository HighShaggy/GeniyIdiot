//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using GeniyIdiot.Common;


//namespace GeniyIdiotWindowsForms
//{
//    public partial class questionsEditorForm : Form
//    {
//        private string textQuestions;

//        public string questionAnswer;

//        public questionsEditorForm()
//        {
//            InitializeComponent();
//        }

//        public void Form1_Load(object sender, EventArgs e)
//        {
//            var textQuestion = textBoxQuestionName.Text;
//            var countAnswer = textBoxCountAnswer.Text;
//            textQuestion = textQuestions;
//            countAnswer = questionAnswer;
//        }
//        public void AddNewQuestion()
//        {
//            var question = new Question(textQuestions, Convert.ToInt32(questionAnswer));
//            QuestionHub.Add(question);
//        }

//        public static void Remove(Question removeQuestion)
//        {
//            var questions = QuestionHub.GetHub();
//            for (int i = 0; i < questions.Count; i++)
//            {
//                if (questions[i].NameQuestion == removeQuestion.NameQuestion)
//                {
//                    questions.RemoveAt(i);
//                    break;
//                }
//            }
//            FileReaderBase.Clear("questions.txt");
//            foreach (var question in questions)
//            {
//                QuestionHub.Add(question);
//            }
//        }

//        private void acceptAdd_Click(object sender, EventArgs e)
//        {
//            AddNewQuestion();
//            textBoxQuestionName.Clear();
//            textBoxCountAnswer.Clear();
//            MessageBox.Show("Вопрос добавлен");
//        }
//    }
//}

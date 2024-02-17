using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiotWindowsForms
{
    public partial class questionEditorForm : Form
    {
        private string textUserQuestions;

        public int questionAnswer;

        public int count = 0;

        Question deletedQuestion;
        public questionEditorForm()
        {
            InitializeComponent();
        }

        public void questionEditorForm_Load(object sender, EventArgs e)
        {
            var questions = QuestionHub.GetHub();
            foreach (var question in questions)
            {
                ResultsdataGridView1.Rows.Add(count + ". " + question.NameQuestion, question.CountAnswer);
                count++;
            }
        }

        public void AddNewQuestion()
        {
            var textQuestion = textBoxQuestionName.Text;
            textUserQuestions = textQuestion;

            bool GetNumber = int.TryParse(textBoxCountAnswer.Text, out questionAnswer);
            if (GetNumber != true)
            {
                MessageBox.Show("Введите число");
            }
            else
            {
                var question = new Question(textUserQuestions, Convert.ToInt32(questionAnswer));
                QuestionHub.Add(question);
            }
        }

        public void acceptAdd_Click(object sender, EventArgs e)
        {
            AddNewQuestion();
            textBoxQuestionName.Clear();
            textBoxCountAnswer.Clear();
            MessageBox.Show("Вопрос добавлен");
            RefreshDataGrid();
        }

        public void buttondDeleteQuestion_Click(object sender, EventArgs e)
        {
            var questions = QuestionHub.GetHub();
            int numberDeleteQuestion;
            bool GetNumber = int.TryParse(textBoxNumberDelete.Text, out numberDeleteQuestion);
            if (GetNumber == true && numberDeleteQuestion < questions.Count && numberDeleteQuestion >= 0)
            {
                deletedQuestion = questions[numberDeleteQuestion];
                Remove(deletedQuestion);
                textBoxNumberDelete.Clear();
                MessageBox.Show("Вопрос удален");
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Введите число или правильный номер вопроса");
            }

        }
        public static void Remove(Question removeQuestion)
        {
            var questions = QuestionHub.GetHub();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].NameQuestion == removeQuestion.NameQuestion)
                {
                    questions.RemoveAt(i);
                    break;
                }
            }
            FileReaderBase.Clear("questions.txt");
            foreach (var question in questions)
            {
                QuestionHub.Add(question);
            }
        }
        private void RefreshDataGrid()
        {
            var questions = QuestionHub.GetHub();
            this.ResultsdataGridView1.Rows.Clear();
            count = 0;
            foreach (var question in questions)
            {
                ResultsdataGridView1.Rows.Add(count + ". " + question.NameQuestion, question.CountAnswer);
                count++;
            }
        }
    }
}

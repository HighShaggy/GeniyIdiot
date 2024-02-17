using System;
using System.Windows.Forms;
using GeniyIdiotConsoleApp; 

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var questions = QuestionStorage.GetQuestions();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
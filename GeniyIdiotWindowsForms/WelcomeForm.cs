using System;
using System.IO;
using System.Windows.Forms;

namespace GeniyIdiotWindowsForms
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void closeProgram_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startTest_Click(object sender, EventArgs e)
        {
            var startLoginForm = new userNameForm();
            startLoginForm.Show();
        }

        private void watchStats_Click(object sender, EventArgs e)
        {
            var table = new FileStream("results.txt", FileMode.OpenOrCreate);
            table.Close();
            string[] emptyFile = File.ReadAllLines("results.txt");
            if (emptyFile.Length == 0)
            {
                MessageBox.Show("Результатов пока что нет");
            }
            else
            {
                var resultStore = new resultsForm();
                resultStore.Show();
            }
        }
        private void editQuestions_Click(object sender, EventArgs e)
        {
            var editorQuestions = new questionEditorForm();
            editorQuestions.Show();
        }
    }
}

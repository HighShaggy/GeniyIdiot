using System;
using System.Windows.Forms;

namespace GeniyIdiotWindowsForms
{
    public partial class userNameForm : Form
    {
        public string Text { get; set; }

        public userNameForm()
        {
            InitializeComponent();
        }

        private void acceptNameButton_Click_1(object sender, EventArgs e)
        {
            using (var gameForm = new playGameForm())
            {
                gameForm.Text = textBoxUserName.Text;
                gameForm.ShowDialog();
                Close();
            }
        }
    }
}
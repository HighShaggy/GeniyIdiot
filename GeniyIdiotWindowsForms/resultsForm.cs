using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWindowsForms
{
    public partial class resultsForm : Form
    {
        public resultsForm()
        {
            InitializeComponent();
        }

        private void resultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResult.GetUserResult();
            foreach (var result in results)
            {
                ResultsdataGridView1.Rows.Add(result.Name, result.CountRightAnswers, result.Diagnosis);
            }
        }
    }
}

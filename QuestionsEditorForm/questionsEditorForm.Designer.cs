namespace GeniyIdiotWindowsForms
{
    partial class questionsEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.acceptAdd = new System.Windows.Forms.Button();
            this.addNameQuestion = new System.Windows.Forms.Label();
            this.addAnswer = new System.Windows.Forms.Label();
            this.textBoxQuestionName = new System.Windows.Forms.TextBox();
            this.textBoxCountAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acceptAdd
            // 
            this.acceptAdd.Location = new System.Drawing.Point(69, 200);
            this.acceptAdd.Name = "acceptAdd";
            this.acceptAdd.Size = new System.Drawing.Size(75, 23);
            this.acceptAdd.TabIndex = 0;
            this.acceptAdd.Text = "Добавить вопрос";
            this.acceptAdd.UseVisualStyleBackColor = true;
            this.acceptAdd.Click += new System.EventHandler(this.acceptAdd_Click);
            // 
            // addNameQuestion
            // 
            this.addNameQuestion.AutoSize = true;
            this.addNameQuestion.Location = new System.Drawing.Point(12, 41);
            this.addNameQuestion.Name = "addNameQuestion";
            this.addNameQuestion.Size = new System.Drawing.Size(223, 13);
            this.addNameQuestion.TabIndex = 1;
            this.addNameQuestion.Text = "Введите вопрос, который хотите добавить";
            // 
            // addAnswer
            // 
            this.addAnswer.AutoSize = true;
            this.addAnswer.Location = new System.Drawing.Point(66, 122);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(80, 13);
            this.addAnswer.TabIndex = 2;
            this.addAnswer.Text = "Введите ответ";
            // 
            // textBoxQuestionName
            // 
            this.textBoxQuestionName.Location = new System.Drawing.Point(57, 71);
            this.textBoxQuestionName.Name = "textBoxQuestionName";
            this.textBoxQuestionName.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuestionName.TabIndex = 3;
            
            // 
            // textBoxCountAnswer
            // 
            this.textBoxCountAnswer.Location = new System.Drawing.Point(57, 153);
            this.textBoxCountAnswer.Name = "textBoxCountAnswer";
            this.textBoxCountAnswer.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountAnswer.TabIndex = 4;
            
            // 
            // QuestionsEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCountAnswer);
            this.Controls.Add(this.textBoxQuestionName);
            this.Controls.Add(this.addAnswer);
            this.Controls.Add(this.addNameQuestion);
            this.Controls.Add(this.acceptAdd);
            this.Name = "QuestionsEditorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptAdd;
        private System.Windows.Forms.Label addNameQuestion;
        private System.Windows.Forms.Label addAnswer;
        public System.Windows.Forms.TextBox textBoxQuestionName;
        public System.Windows.Forms.TextBox textBoxCountAnswer;
    }
}


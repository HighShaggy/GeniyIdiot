namespace GeniyIdiotWindowsForms
{
    partial class testForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.userAnswerText = new System.Windows.Forms.TextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.numberQuestion = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.acceptName = new System.Windows.Forms.Button();
            this.textQuestion = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userAnswerText
            // 
            this.userAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userAnswerText.Location = new System.Drawing.Point(333, 278);
            this.userAnswerText.Name = "userAnswerText";
            this.userAnswerText.Size = new System.Drawing.Size(124, 26);
            this.userAnswerText.TabIndex = 1;
            // 
            // answerButton
            // 
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerButton.Location = new System.Drawing.Point(499, 278);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(119, 30);
            this.answerButton.TabIndex = 2;
            this.answerButton.Text = "Ответить";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberQuestion
            // 
            this.numberQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberQuestion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.numberQuestion.Location = new System.Drawing.Point(213, 153);
            this.numberQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberQuestion.Name = "numberQuestion";
            this.numberQuestion.Size = new System.Drawing.Size(372, 42);
            this.numberQuestion.TabIndex = 3;
            this.numberQuestion.Text = "Номер вопроса";
            this.numberQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textUsername.Location = new System.Drawing.Point(27, 61);
            this.textUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(76, 26);
            this.textUsername.TabIndex = 9;
            // 
            // acceptName
            // 
            this.acceptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptName.Location = new System.Drawing.Point(133, 60);
            this.acceptName.Margin = new System.Windows.Forms.Padding(2);
            this.acceptName.Name = "acceptName";
            this.acceptName.Size = new System.Drawing.Size(43, 25);
            this.acceptName.TabIndex = 8;
            this.acceptName.Text = "Ок";
            this.acceptName.UseVisualStyleBackColor = true;
            this.acceptName.Click += new System.EventHandler(this.acceptName_Click);
            // 
            // textQuestion
            // 
            this.textQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textQuestion.Location = new System.Drawing.Point(0, 0);
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.Size = new System.Drawing.Size(800, 450);
            this.textQuestion.TabIndex = 0;
            this.textQuestion.Text = "Текст вопроса";
            this.textQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(23, 18);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(97, 20);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Ваше имя:";
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.acceptName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.numberQuestion);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.userAnswerText);
            this.Controls.Add(this.textQuestion);
            this.Name = "testForm";
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.testForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button answerButton;
        public System.Windows.Forms.Label numberQuestion;
        public System.Windows.Forms.TextBox textUsername;
        public System.Windows.Forms.Button acceptName;
        public System.Windows.Forms.TextBox userAnswerText;
        public System.Windows.Forms.Label textQuestion;
        private System.Windows.Forms.Label labelName;
    }
}


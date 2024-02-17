namespace GeniyIdiotWindowsForms
{
    partial class playGameForm
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
        private void InitializeComponent()
        {
            this.userAnswerText = new System.Windows.Forms.TextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.numberQuestion = new System.Windows.Forms.Label();
            this.textQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userAnswerText
            // 
            this.userAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userAnswerText.Location = new System.Drawing.Point(852, 69);
            this.userAnswerText.Margin = new System.Windows.Forms.Padding(4);
            this.userAnswerText.Name = "userAnswerText";
            this.userAnswerText.Size = new System.Drawing.Size(132, 30);
            this.userAnswerText.TabIndex = 2;
            // 
            // answerButton
            // 
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerButton.Location = new System.Drawing.Point(848, 126);
            this.answerButton.Margin = new System.Windows.Forms.Padding(4);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(137, 37);
            this.answerButton.TabIndex = 3;
            this.answerButton.Text = "Ответить";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // numberQuestion
            // 
            this.numberQuestion.AutoSize = true;
            this.numberQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numberQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberQuestion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.numberQuestion.Location = new System.Drawing.Point(0, 529);
            this.numberQuestion.Name = "numberQuestion";
            this.numberQuestion.Size = new System.Drawing.Size(167, 25);
            this.numberQuestion.TabIndex = 4;
            this.numberQuestion.Text = "Номер вопроса";
            this.numberQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textQuestion
            // 
            this.textQuestion.AutoSize = true;
            this.textQuestion.Dock = System.Windows.Forms.DockStyle.Right;
            this.textQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textQuestion.Location = new System.Drawing.Point(908, 0);
            this.textQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.Size = new System.Drawing.Size(159, 25);
            this.textQuestion.TabIndex = 5;
            this.textQuestion.Text = "Текст вопроса";
            this.textQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textQuestion);
            this.Controls.Add(this.numberQuestion);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.userAnswerText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "playGameForm";
            this.Text = "Игра гений/идиот";
            this.Load += new System.EventHandler(this.playGameForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox userAnswerText;
        public System.Windows.Forms.Button answerButton;
        public System.Windows.Forms.Label numberQuestion;
        private System.Windows.Forms.Label textQuestion;
    }
}
namespace GeniyIdiotWindowsForms
{
    partial class questionEditorForm
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
            this.acceptAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuestionName = new System.Windows.Forms.TextBox();
            this.textBoxCountAnswer = new System.Windows.Forms.TextBox();
            this.ResultsdataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumberDelete = new System.Windows.Forms.TextBox();
            this.buttondDeleteQuestion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptAdd
            // 
            this.acceptAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptAdd.Location = new System.Drawing.Point(55, 331);
            this.acceptAdd.Name = "acceptAdd";
            this.acceptAdd.Size = new System.Drawing.Size(88, 23);
            this.acceptAdd.TabIndex = 0;
            this.acceptAdd.Text = "Добавить вопрос";
            this.acceptAdd.UseVisualStyleBackColor = true;
            this.acceptAdd.Click += new System.EventHandler(this.acceptAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите вопрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите ответ на вопрос";
            // 
            // textBoxQuestionName
            // 
            this.textBoxQuestionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuestionName.Location = new System.Drawing.Point(43, 208);
            this.textBoxQuestionName.Name = "textBoxQuestionName";
            this.textBoxQuestionName.Size = new System.Drawing.Size(110, 22);
            this.textBoxQuestionName.TabIndex = 3;
            // 
            // textBoxCountAnswer
            // 
            this.textBoxCountAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountAnswer.Location = new System.Drawing.Point(43, 297);
            this.textBoxCountAnswer.Name = "textBoxCountAnswer";
            this.textBoxCountAnswer.Size = new System.Drawing.Size(110, 22);
            this.textBoxCountAnswer.TabIndex = 4;
            // 
            // ResultsdataGridView1
            // 
            this.ResultsdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameQuestion,
            this.rightAnswer});
            this.ResultsdataGridView1.Location = new System.Drawing.Point(284, 0);
            this.ResultsdataGridView1.Name = "ResultsdataGridView1";
            this.ResultsdataGridView1.Size = new System.Drawing.Size(517, 286);
            this.ResultsdataGridView1.TabIndex = 5;
            // 
            // nameQuestion
            // 
            this.nameQuestion.HeaderText = "Текст вопроса";
            this.nameQuestion.Name = "nameQuestion";
            this.nameQuestion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameQuestion.Width = 400;
            // 
            // rightAnswer
            // 
            this.rightAnswer.HeaderText = "Правильный ответ";
            this.rightAnswer.Name = "rightAnswer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(341, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите номер вопроса который хотите удалить";
            // 
            // textBoxNumberDelete
            // 
            this.textBoxNumberDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberDelete.Location = new System.Drawing.Point(428, 348);
            this.textBoxNumberDelete.Name = "textBoxNumberDelete";
            this.textBoxNumberDelete.Size = new System.Drawing.Size(33, 22);
            this.textBoxNumberDelete.TabIndex = 7;
            // 
            // buttondDeleteQuestion
            // 
            this.buttondDeleteQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttondDeleteQuestion.Location = new System.Drawing.Point(480, 331);
            this.buttondDeleteQuestion.Name = "buttondDeleteQuestion";
            this.buttondDeleteQuestion.Size = new System.Drawing.Size(85, 53);
            this.buttondDeleteQuestion.TabIndex = 8;
            this.buttondDeleteQuestion.Text = "Удалить";
            this.buttondDeleteQuestion.UseVisualStyleBackColor = true;
            this.buttondDeleteQuestion.Click += new System.EventHandler(this.buttondDeleteQuestion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Добавить вопрос";
            // 
            // questionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttondDeleteQuestion);
            this.Controls.Add(this.textBoxNumberDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultsdataGridView1);
            this.Controls.Add(this.textBoxCountAnswer);
            this.Controls.Add(this.textBoxQuestionName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acceptAdd);
            this.Name = "questionEditorForm";
            this.Text = "Редактор вопросов";
            this.Load += new System.EventHandler(this.questionEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxQuestionName;
        public System.Windows.Forms.TextBox textBoxCountAnswer;
        private System.Windows.Forms.DataGridView ResultsdataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumberDelete;
        private System.Windows.Forms.Button buttondDeleteQuestion;
        private System.Windows.Forms.Label label4;
    }
}
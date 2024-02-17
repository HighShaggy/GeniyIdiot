namespace GeniyIdiotWindowsForms
{
    partial class welcomeForm
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
            this.startTest = new System.Windows.Forms.Button();
            this.watchStats = new System.Windows.Forms.Button();
            this.editQuestions = new System.Windows.Forms.Button();
            this.closeProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startTest
            // 
            this.startTest.Location = new System.Drawing.Point(221, 76);
            this.startTest.Name = "startTest";
            this.startTest.Size = new System.Drawing.Size(266, 42);
            this.startTest.TabIndex = 0;
            this.startTest.Text = "Начать тест";
            this.startTest.UseVisualStyleBackColor = true;
            this.startTest.Click += new System.EventHandler(this.startTest_Click);
            // 
            // watchStats
            // 
            this.watchStats.Location = new System.Drawing.Point(221, 124);
            this.watchStats.Name = "watchStats";
            this.watchStats.Size = new System.Drawing.Size(266, 42);
            this.watchStats.TabIndex = 1;
            this.watchStats.Text = "Результаты";
            this.watchStats.UseVisualStyleBackColor = true;
            this.watchStats.Click += new System.EventHandler(this.watchStats_Click);
            // 
            // editQuestions
            // 
            this.editQuestions.Location = new System.Drawing.Point(221, 172);
            this.editQuestions.Name = "editQuestions";
            this.editQuestions.Size = new System.Drawing.Size(266, 42);
            this.editQuestions.TabIndex = 2;
            this.editQuestions.Text = "Добавление / удаление вопросов";
            this.editQuestions.UseVisualStyleBackColor = true;
            this.editQuestions.Click += new System.EventHandler(this.editQuestions_Click);
            // 
            // closeProgram
            // 
            this.closeProgram.Location = new System.Drawing.Point(221, 220);
            this.closeProgram.Name = "closeProgram";
            this.closeProgram.Size = new System.Drawing.Size(266, 42);
            this.closeProgram.TabIndex = 3;
            this.closeProgram.Text = "Выход";
            this.closeProgram.UseVisualStyleBackColor = true;
            this.closeProgram.Click += new System.EventHandler(this.closeProgram_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeProgram);
            this.Controls.Add(this.editQuestions);
            this.Controls.Add(this.watchStats);
            this.Controls.Add(this.startTest);
            this.Name = "WelcomeForm";
            this.Text = "Гений/идиот";
           
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startTest;
        private System.Windows.Forms.Button watchStats;
        private System.Windows.Forms.Button editQuestions;
        private System.Windows.Forms.Button closeProgram;
    }
}


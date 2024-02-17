namespace GeniyIdiotWindowsForms
{
    partial class resultsForm
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
            this.ResultsdataGridView1 = new System.Windows.Forms.DataGridView();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countRightAnswersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsdataGridView1
            // 
            this.ResultsdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameColumn,
            this.countRightAnswersColumn,
            this.diagnosColumn});
            this.ResultsdataGridView1.Location = new System.Drawing.Point(121, 72);
            this.ResultsdataGridView1.Name = "ResultsdataGridView1";
            this.ResultsdataGridView1.Size = new System.Drawing.Size(570, 97);
            this.ResultsdataGridView1.TabIndex = 0;
            // 
            // userNameColumn
            // 
            this.userNameColumn.HeaderText = "Имя:";
            this.userNameColumn.Name = "userNameColumn";
            this.userNameColumn.Width = 175;
            // 
            // countRightAnswersColumn
            // 
            this.countRightAnswersColumn.HeaderText = "Кол-во правильных ответов:";
            this.countRightAnswersColumn.Name = "countRightAnswersColumn";
            this.countRightAnswersColumn.Width = 175;
            // 
            // diagnosColumn
            // 
            this.diagnosColumn.HeaderText = "Диагноз:";
            this.diagnosColumn.Name = "diagnosColumn";
            this.diagnosColumn.Width = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результаты тестирований";
            // 
            // resultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultsdataGridView1);
            this.Name = "resultsForm";
            this.Text = "Результаты";
            this.Load += new System.EventHandler(this.resultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultsdataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countRightAnswersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosColumn;
        private System.Windows.Forms.Label label1;
    }
}


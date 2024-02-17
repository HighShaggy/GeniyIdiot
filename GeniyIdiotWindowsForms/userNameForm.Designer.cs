namespace GeniyIdiotWindowsForms
{
    partial class userNameForm
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
            this.acceptNameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acceptNameButton
            // 
            this.acceptNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptNameButton.Location = new System.Drawing.Point(333, 75);
            this.acceptNameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptNameButton.Name = "acceptNameButton";
            this.acceptNameButton.Size = new System.Drawing.Size(157, 62);
            this.acceptNameButton.TabIndex = 0;
            this.acceptNameButton.Text = "Начать тест";
            this.acceptNameButton.UseVisualStyleBackColor = true;
            this.acceptNameButton.Click += new System.EventHandler(this.acceptNameButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите ваше имя:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(145, 95);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(132, 22);
            this.textBoxUserName.TabIndex = 2;
            // 
            // userNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 416);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acceptNameButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "userNameForm";
            this.Text = "Авторизация";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptNameButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxUserName;
    }
}
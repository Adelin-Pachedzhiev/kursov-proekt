namespace Kursov_proekt
{
    partial class Form3
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.heightDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.previousQuestion = new System.Windows.Forms.Button();
            this.nextQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(279, 112);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.questionLabel.Size = new System.Drawing.Size(381, 80);
            this.questionLabel.TabIndex = 4;
            this.questionLabel.Text = "Каква е вашата височина ?";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(286, 236);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 45);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // heightDescription
            // 
            this.heightDescription.AutoSize = true;
            this.heightDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightDescription.Location = new System.Drawing.Point(459, 261);
            this.heightDescription.Name = "heightDescription";
            this.heightDescription.Size = new System.Drawing.Size(30, 20);
            this.heightDescription.TabIndex = 16;
            this.heightDescription.Text = "см";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(896, 62);
            this.label1.TabIndex = 17;
            this.label1.Text = "Разберете коя диета и тренировъчен режим са най-добри за вас";
            // 
            // previousQuestion
            // 
            this.previousQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.previousQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousQuestion.ForeColor = System.Drawing.Color.White;
            this.previousQuestion.Location = new System.Drawing.Point(20, 550);
            this.previousQuestion.Name = "previousQuestion";
            this.previousQuestion.Size = new System.Drawing.Size(160, 70);
            this.previousQuestion.TabIndex = 18;
            this.previousQuestion.Text = "Предишен въпрос";
            this.previousQuestion.UseVisualStyleBackColor = false;
            this.previousQuestion.Click += new System.EventHandler(this.previousQuestion_Click_1);
            // 
            // nextQuestion
            // 
            this.nextQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.nextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestion.ForeColor = System.Drawing.Color.White;
            this.nextQuestion.Location = new System.Drawing.Point(910, 550);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(160, 70);
            this.nextQuestion.TabIndex = 19;
            this.nextQuestion.Text = "Следващ въпрос";
            this.nextQuestion.UseVisualStyleBackColor = false;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.nextQuestion);
            this.Controls.Add(this.previousQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightDescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.questionLabel);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label heightDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button previousQuestion;
        private System.Windows.Forms.Button nextQuestion;
    }
}
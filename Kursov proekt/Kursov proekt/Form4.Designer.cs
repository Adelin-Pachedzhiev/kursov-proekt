namespace Kursov_proekt
{
    partial class Form4
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
            this.weightTextBox1 = new System.Windows.Forms.TextBox();
            this.weightDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nextQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(281, 131);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.questionLabel.Size = new System.Drawing.Size(377, 84);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "Какво е вашето тегло ?";
            // 
            // weightTextBox1
            // 
            this.weightTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox1.Location = new System.Drawing.Point(289, 237);
            this.weightTextBox1.Margin = new System.Windows.Forms.Padding(10);
            this.weightTextBox1.Name = "weightTextBox1";
            this.weightTextBox1.Size = new System.Drawing.Size(160, 34);
            this.weightTextBox1.TabIndex = 17;
            this.weightTextBox1.TextChanged += new System.EventHandler(this.weightTextBox1_TextChanged);
            // 
            // weightDescription
            // 
            this.weightDescription.AutoSize = true;
            this.weightDescription.Location = new System.Drawing.Point(462, 250);
            this.weightDescription.Name = "weightDescription";
            this.weightDescription.Size = new System.Drawing.Size(23, 17);
            this.weightDescription.TabIndex = 18;
            this.weightDescription.Text = "kg";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 70);
            this.button1.TabIndex = 19;
            this.button1.Text = "Предишен въпрос";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nextQuestion
            // 
            this.nextQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.nextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestion.ForeColor = System.Drawing.Color.White;
            this.nextQuestion.Location = new System.Drawing.Point(901, 550);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(160, 70);
            this.nextQuestion.TabIndex = 20;
            this.nextQuestion.Text = "Следващ въпрос";
            this.nextQuestion.UseVisualStyleBackColor = false;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click_1);
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
            this.label1.TabIndex = 21;
            this.label1.Text = "Разберете коя диета и тренировъчен режим са най-добри за вас";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextQuestion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.weightDescription);
            this.Controls.Add(this.weightTextBox1);
            this.Controls.Add(this.questionLabel);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label weightDescription;
        private System.Windows.Forms.TextBox weightTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.Label label1;
    }
}
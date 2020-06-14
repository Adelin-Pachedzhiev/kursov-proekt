namespace Kursov_proekt
{
    partial class Form2
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton40 = new System.Windows.Forms.RadioButton();
            this.nextQuestion = new System.Windows.Forms.Button();
            this.previousQuestion = new System.Windows.Forms.Button();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(350, 110);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.questionLabel.Size = new System.Drawing.Size(363, 80);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = "Каква е вашата възраст ?\r\n";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(80, 450);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Тинейджър";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(357, 450);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(80, 21);
            this.radioButton20.TabIndex = 6;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "след 20";
            this.radioButton20.UseVisualStyleBackColor = true;
            this.radioButton20.CheckedChanged += new System.EventHandler(this.radioButton20_CheckedChanged);
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.Location = new System.Drawing.Point(633, 450);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(80, 21);
            this.radioButton30.TabIndex = 7;
            this.radioButton30.TabStop = true;
            this.radioButton30.Text = "след 30";
            this.radioButton30.UseVisualStyleBackColor = true;
            this.radioButton30.CheckedChanged += new System.EventHandler(this.radioButton30_CheckedChanged);
            // 
            // radioButton40
            // 
            this.radioButton40.AutoSize = true;
            this.radioButton40.Location = new System.Drawing.Point(886, 450);
            this.radioButton40.Name = "radioButton40";
            this.radioButton40.Size = new System.Drawing.Size(80, 21);
            this.radioButton40.TabIndex = 8;
            this.radioButton40.TabStop = true;
            this.radioButton40.Text = "след 40";
            this.radioButton40.UseVisualStyleBackColor = true;
            this.radioButton40.CheckedChanged += new System.EventHandler(this.radioButton40_CheckedChanged);
            // 
            // nextQuestion
            // 
            this.nextQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.nextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestion.ForeColor = System.Drawing.Color.White;
            this.nextQuestion.Location = new System.Drawing.Point(910, 570);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(160, 70);
            this.nextQuestion.TabIndex = 9;
            this.nextQuestion.Text = "Следващ въпрос";
            this.nextQuestion.UseVisualStyleBackColor = false;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
            // 
            // previousQuestion
            // 
            this.previousQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.previousQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousQuestion.ForeColor = System.Drawing.Color.White;
            this.previousQuestion.Location = new System.Drawing.Point(15, 570);
            this.previousQuestion.Name = "previousQuestion";
            this.previousQuestion.Size = new System.Drawing.Size(160, 70);
            this.previousQuestion.TabIndex = 13;
            this.previousQuestion.Text = "Предишен въпрос";
            this.previousQuestion.UseVisualStyleBackColor = false;
            this.previousQuestion.Click += new System.EventHandler(this.previousQuestion_Click);
            // 
            // pictureBox40
            // 
            this.pictureBox40.Image = global::Kursov_proekt.Properties.Resources.original_age4;
            this.pictureBox40.Location = new System.Drawing.Point(840, 250);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(180, 180);
            this.pictureBox40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox40.TabIndex = 12;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Image = global::Kursov_proekt.Properties.Resources.original_age3;
            this.pictureBox30.Location = new System.Drawing.Point(580, 250);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(180, 180);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 11;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::Kursov_proekt.Properties.Resources.original_age2;
            this.pictureBox20.Location = new System.Drawing.Point(315, 250);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(180, 180);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 10;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Kursov_proekt.Properties.Resources.original_age1;
            this.pictureBox10.Location = new System.Drawing.Point(50, 250);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(180, 180);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 4;
            this.pictureBox10.TabStop = false;
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
            this.label1.TabIndex = 14;
            this.label1.Text = "Разберете коя диета и тренировъчен режим са най-добри за вас";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previousQuestion);
            this.Controls.Add(this.pictureBox40);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.nextQuestion);
            this.Controls.Add(this.radioButton40);
            this.Controls.Add(this.radioButton30);
            this.Controls.Add(this.radioButton20);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.questionLabel);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton30;
        private System.Windows.Forms.RadioButton radioButton40;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.Button previousQuestion;
        private System.Windows.Forms.Label label1;
    }
}
namespace Kursov_proekt
{
    partial class Form5
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.pictureBoxVery = new System.Windows.Forms.PictureBox();
            this.pictureBoxModerately = new System.Windows.Forms.PictureBox();
            this.pictureBoxLightly = new System.Windows.Forms.PictureBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModerately)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLightly)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.White;
            this.mainLabel.Location = new System.Drawing.Point(110, 20);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.mainLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainLabel.Size = new System.Drawing.Size(896, 62);
            this.mainLabel.TabIndex = 5;
            this.mainLabel.Text = "Разберете коя диета и тренировъчен режим са най-добри за вас";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(401, 117);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.questionLabel.Size = new System.Drawing.Size(289, 80);
            this.questionLabel.TabIndex = 6;
            this.questionLabel.Text = "Колко активни сте ?";
            // 
            // pictureBoxVery
            // 
            this.pictureBoxVery.Image = global::Kursov_proekt.Properties.Resources.unnamed;
            this.pictureBoxVery.Location = new System.Drawing.Point(764, 242);
            this.pictureBoxVery.Name = "pictureBoxVery";
            this.pictureBoxVery.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxVery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVery.TabIndex = 9;
            this.pictureBoxVery.TabStop = false;
            this.pictureBoxVery.Click += new System.EventHandler(this.pictureBoxVery_Click);
            // 
            // pictureBoxModerately
            // 
            this.pictureBoxModerately.Image = global::Kursov_proekt.Properties.Resources._93372673bb3c76463cb1e854cd828bbe;
            this.pictureBoxModerately.Location = new System.Drawing.Point(481, 242);
            this.pictureBoxModerately.Name = "pictureBoxModerately";
            this.pictureBoxModerately.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxModerately.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxModerately.TabIndex = 8;
            this.pictureBoxModerately.TabStop = false;
            this.pictureBoxModerately.Click += new System.EventHandler(this.pictureBoxModerately_Click);
            // 
            // pictureBoxLightly
            // 
            this.pictureBoxLightly.Image = global::Kursov_proekt.Properties.Resources.original_active1;
            this.pictureBoxLightly.Location = new System.Drawing.Point(187, 242);
            this.pictureBoxLightly.Name = "pictureBoxLightly";
            this.pictureBoxLightly.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxLightly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLightly.TabIndex = 7;
            this.pictureBoxLightly.TabStop = false;
            this.pictureBoxLightly.Click += new System.EventHandler(this.pictureBoxLightly_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.ForeColor = System.Drawing.Color.White;
            this.previousButton.Location = new System.Drawing.Point(12, 571);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(160, 70);
            this.previousButton.TabIndex = 17;
            this.previousButton.Text = "Предишен въпрос";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 72);
            this.label1.TabIndex = 19;
            this.label1.Text = "Слабо активен :\r\nбез тренировки или\r\nедин път седмично\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 72);
            this.label2.TabIndex = 20;
            this.label2.Text = "Средно активен :\r\nоколо 3 тренировки\r\n седмично";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(780, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 72);
            this.label3.TabIndex = 21;
            this.label3.Text = "Силно активен :\r\n4+ тренировки\r\nседмично";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.pictureBoxVery);
            this.Controls.Add(this.pictureBoxModerately);
            this.Controls.Add(this.pictureBoxLightly);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.mainLabel);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModerately)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLightly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.PictureBox pictureBoxLightly;
        private System.Windows.Forms.PictureBox pictureBoxModerately;
        private System.Windows.Forms.PictureBox pictureBoxVery;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
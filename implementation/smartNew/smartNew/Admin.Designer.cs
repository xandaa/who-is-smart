namespace smartNew
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.easyRBtn = new System.Windows.Forms.RadioButton();
            this.mediumRBtn = new System.Windows.Forms.RadioButton();
            this.hardRBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lessonNameTxt = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level";
            // 
            // easyRBtn
            // 
            this.easyRBtn.AutoSize = true;
            this.easyRBtn.Location = new System.Drawing.Point(97, 38);
            this.easyRBtn.Name = "easyRBtn";
            this.easyRBtn.Size = new System.Drawing.Size(48, 17);
            this.easyRBtn.TabIndex = 1;
            this.easyRBtn.TabStop = true;
            this.easyRBtn.Text = "Easy";
            this.easyRBtn.UseVisualStyleBackColor = true;
            // 
            // mediumRBtn
            // 
            this.mediumRBtn.AutoSize = true;
            this.mediumRBtn.Location = new System.Drawing.Point(151, 40);
            this.mediumRBtn.Name = "mediumRBtn";
            this.mediumRBtn.Size = new System.Drawing.Size(62, 17);
            this.mediumRBtn.TabIndex = 2;
            this.mediumRBtn.TabStop = true;
            this.mediumRBtn.Text = "Medium";
            this.mediumRBtn.UseVisualStyleBackColor = true;
            // 
            // hardRBtn
            // 
            this.hardRBtn.AutoSize = true;
            this.hardRBtn.Location = new System.Drawing.Point(230, 40);
            this.hardRBtn.Name = "hardRBtn";
            this.hardRBtn.Size = new System.Drawing.Size(48, 17);
            this.hardRBtn.TabIndex = 3;
            this.hardRBtn.TabStop = true;
            this.hardRBtn.Text = "Hard";
            this.hardRBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lesson name";
            // 
            // lessonNameTxt
            // 
            this.lessonNameTxt.Location = new System.Drawing.Point(113, 67);
            this.lessonNameTxt.Name = "lessonNameTxt";
            this.lessonNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lessonNameTxt.TabIndex = 5;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(230, 95);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(13, 95);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "New lesson";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 130);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.lessonNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hardRBtn);
            this.Controls.Add(this.mediumRBtn);
            this.Controls.Add(this.easyRBtn);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton easyRBtn;
        private System.Windows.Forms.RadioButton mediumRBtn;
        private System.Windows.Forms.RadioButton hardRBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lessonNameTxt;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label3;
    }
}
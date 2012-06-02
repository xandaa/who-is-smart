namespace smartNew
{
    partial class Home
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
            this.lessonsLbx = new System.Windows.Forms.ListBox();
            this.playBtn = new System.Windows.Forms.Button();
            this.topUsersLbx = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lessonsLbx
            // 
            this.lessonsLbx.FormattingEnabled = true;
            this.lessonsLbx.Location = new System.Drawing.Point(28, 46);
            this.lessonsLbx.Name = "lessonsLbx";
            this.lessonsLbx.Size = new System.Drawing.Size(144, 238);
            this.lessonsLbx.TabIndex = 0;
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(214, 46);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 127);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // topUsersLbx
            // 
            this.topUsersLbx.FormattingEnabled = true;
            this.topUsersLbx.Location = new System.Drawing.Point(334, 46);
            this.topUsersLbx.Name = "topUsersLbx";
            this.topUsersLbx.Size = new System.Drawing.Size(141, 238);
            this.topUsersLbx.TabIndex = 2;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(214, 214);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Top Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lessons";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.topUsersLbx);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.lessonsLbx);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lessonsLbx;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.ListBox topUsersLbx;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
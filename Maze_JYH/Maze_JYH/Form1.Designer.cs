namespace MCS_Week_003_final
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.MakeMaze = new System.Windows.Forms.Button();
            this.RecButton = new System.Windows.Forms.Button();
            this.SelectPathButton = new System.Windows.Forms.Button();
            this.RecordStop_BUTTON = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmrRecord = new System.Windows.Forms.Timer(this.components);
            this.lblTimer2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.endPointPictureBox = new System.Windows.Forms.PictureBox();
            this.PlayerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.endPointPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(604, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopButton.Location = new System.Drawing.Point(423, 136);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(100, 100);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ResumeButton
            // 
            this.ResumeButton.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResumeButton.Location = new System.Drawing.Point(604, 136);
            this.ResumeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(100, 100);
            this.ResumeButton.TabIndex = 11;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // MakeMaze
            // 
            this.MakeMaze.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MakeMaze.Location = new System.Drawing.Point(423, 3);
            this.MakeMaze.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MakeMaze.Name = "MakeMaze";
            this.MakeMaze.Size = new System.Drawing.Size(100, 100);
            this.MakeMaze.TabIndex = 13;
            this.MakeMaze.Text = "Start";
            this.MakeMaze.UseVisualStyleBackColor = true;
            this.MakeMaze.Click += new System.EventHandler(this.MakeMaze_Click);
            // 
            // RecButton
            // 
            this.RecButton.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RecButton.Location = new System.Drawing.Point(506, 275);
            this.RecButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RecButton.Name = "RecButton";
            this.RecButton.Size = new System.Drawing.Size(100, 100);
            this.RecButton.TabIndex = 14;
            this.RecButton.Text = "Rec";
            this.RecButton.UseVisualStyleBackColor = true;
            this.RecButton.Click += new System.EventHandler(this.RecButton_Click);
            // 
            // SelectPathButton
            // 
            this.SelectPathButton.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SelectPathButton.Location = new System.Drawing.Point(361, 275);
            this.SelectPathButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SelectPathButton.Name = "SelectPathButton";
            this.SelectPathButton.Size = new System.Drawing.Size(100, 100);
            this.SelectPathButton.TabIndex = 15;
            this.SelectPathButton.Text = "SelectPath";
            this.SelectPathButton.UseVisualStyleBackColor = true;
            this.SelectPathButton.Click += new System.EventHandler(this.SelectPathButton_Click);
            // 
            // RecordStop_BUTTON
            // 
            this.RecordStop_BUTTON.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RecordStop_BUTTON.Location = new System.Drawing.Point(646, 275);
            this.RecordStop_BUTTON.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RecordStop_BUTTON.Name = "RecordStop_BUTTON";
            this.RecordStop_BUTTON.Size = new System.Drawing.Size(104, 100);
            this.RecordStop_BUTTON.TabIndex = 16;
            this.RecordStop_BUTTON.Text = "RecordStop";
            this.RecordStop_BUTTON.UseVisualStyleBackColor = true;
            this.RecordStop_BUTTON.Click += new System.EventHandler(this.RecordStop_BUTTON_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(1, 590);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(65, 15);
            this.lblTimer.TabIndex = 17;
            this.lblTimer.Text = "00:00:00";
            // 
            // tmrRecord
            // 
            this.tmrRecord.Interval = 15;
            this.tmrRecord.Tick += new System.EventHandler(this.tmrRecord_Tick);
            // 
            // lblTimer2
            // 
            this.lblTimer2.AutoSize = true;
            this.lblTimer2.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer2.Location = new System.Drawing.Point(427, 483);
            this.lblTimer2.Name = "lblTimer2";
            this.lblTimer2.Size = new System.Drawing.Size(282, 69);
            this.lblTimer2.TabIndex = 18;
            this.lblTimer2.Text = "00:00:00";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.tmrRecord2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "소요시간";
            // 
            // endPointPictureBox
            // 
            this.endPointPictureBox.BackColor = System.Drawing.Color.Blue;
            this.endPointPictureBox.Location = new System.Drawing.Point(292, 301);
            this.endPointPictureBox.Name = "endPointPictureBox";
            this.endPointPictureBox.Size = new System.Drawing.Size(10, 10);
            this.endPointPictureBox.TabIndex = 25;
            this.endPointPictureBox.TabStop = false;
            // 
            // PlayerPictureBox
            // 
            this.PlayerPictureBox.BackColor = System.Drawing.Color.Red;
            this.PlayerPictureBox.Location = new System.Drawing.Point(42, 26);
            this.PlayerPictureBox.Name = "PlayerPictureBox";
            this.PlayerPictureBox.Size = new System.Drawing.Size(7, 7);
            this.PlayerPictureBox.TabIndex = 26;
            this.PlayerPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 614);
            this.Controls.Add(this.PlayerPictureBox);
            this.Controls.Add(this.endPointPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimer2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.RecordStop_BUTTON);
            this.Controls.Add(this.SelectPathButton);
            this.Controls.Add(this.RecButton);
            this.Controls.Add(this.MakeMaze);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.endPointPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button MakeMaze;
        private System.Windows.Forms.Button RecButton;
        private System.Windows.Forms.Button SelectPathButton;
        private System.Windows.Forms.Button RecordStop_BUTTON;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrRecord;
        private System.Windows.Forms.Label lblTimer2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PlaerPictureBox;
        private System.Windows.Forms.PictureBox endPointPictureBox;
        private System.Windows.Forms.PictureBox PlayerPictureBox;
    }
}


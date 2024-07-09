namespace TableFootball
{
    partial class ResultFrom
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
            components = new System.ComponentModel.Container();
            Team1 = new Label();
            Team2 = new Label();
            E1sulm = new Label();
            E2sulm = new Label();
            E2Port = new Label();
            E1port = new Label();
            txtTeam1Score = new TextBox();
            txtTeam2Score = new TextBox();
            btnFinish = new Button();
            TimerCounter = new Label();
            MyTimer = new System.Windows.Forms.Timer(components);
            minutes = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Team1
            // 
            Team1.AutoSize = true;
            Team1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Team1.ForeColor = Color.White;
            Team1.Location = new Point(311, 71);
            Team1.Name = "Team1";
            Team1.Size = new Size(46, 54);
            Team1.TabIndex = 0;
            Team1.Text = "1";
            // 
            // Team2
            // 
            Team2.AutoSize = true;
            Team2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Team2.ForeColor = Color.White;
            Team2.Location = new Point(1129, 71);
            Team2.Name = "Team2";
            Team2.Size = new Size(46, 54);
            Team2.TabIndex = 1;
            Team2.Text = "1";
            // 
            // E1sulm
            // 
            E1sulm.AutoSize = true;
            E1sulm.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            E1sulm.ForeColor = Color.FromArgb(215, 106, 15);
            E1sulm.Location = new Point(311, 149);
            E1sulm.Name = "E1sulm";
            E1sulm.Size = new Size(32, 38);
            E1sulm.TabIndex = 2;
            E1sulm.Text = "1";
            // 
            // E2sulm
            // 
            E2sulm.AutoSize = true;
            E2sulm.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            E2sulm.ForeColor = Color.FromArgb(215, 106, 15);
            E2sulm.Location = new Point(1129, 149);
            E2sulm.Name = "E2sulm";
            E2sulm.Size = new Size(32, 38);
            E2sulm.TabIndex = 3;
            E2sulm.Text = "1";
            // 
            // E2Port
            // 
            E2Port.AutoSize = true;
            E2Port.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            E2Port.ForeColor = Color.FromArgb(215, 106, 15);
            E2Port.Location = new Point(1129, 225);
            E2Port.Name = "E2Port";
            E2Port.Size = new Size(32, 38);
            E2Port.TabIndex = 4;
            E2Port.Text = "1";
            // 
            // E1port
            // 
            E1port.AutoSize = true;
            E1port.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            E1port.ForeColor = Color.FromArgb(215, 106, 15);
            E1port.Location = new Point(311, 225);
            E1port.Name = "E1port";
            E1port.Size = new Size(32, 38);
            E1port.TabIndex = 5;
            E1port.Text = "1";
            // 
            // txtTeam1Score
            // 
            txtTeam1Score.BackColor = Color.FromArgb(10, 20, 30);
            txtTeam1Score.BorderStyle = BorderStyle.FixedSingle;
            txtTeam1Score.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            txtTeam1Score.ForeColor = Color.White;
            txtTeam1Score.Location = new Point(554, 60);
            txtTeam1Score.Name = "txtTeam1Score";
            txtTeam1Score.Size = new Size(62, 65);
            txtTeam1Score.TabIndex = 6;
            txtTeam1Score.Text = "0";
            txtTeam1Score.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTeam2Score
            // 
            txtTeam2Score.BackColor = Color.FromArgb(10, 20, 30);
            txtTeam2Score.BorderStyle = BorderStyle.FixedSingle;
            txtTeam2Score.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            txtTeam2Score.ForeColor = Color.White;
            txtTeam2Score.Location = new Point(896, 60);
            txtTeam2Score.Name = "txtTeam2Score";
            txtTeam2Score.Size = new Size(64, 65);
            txtTeam2Score.TabIndex = 7;
            txtTeam2Score.Text = "0";
            txtTeam2Score.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.Green;
            btnFinish.Cursor = Cursors.Hand;
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinish.ForeColor = Color.White;
            btnFinish.Location = new Point(576, 419);
            btnFinish.Margin = new Padding(3, 4, 3, 4);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(384, 191);
            btnFinish.TabIndex = 13;
            btnFinish.Text = "Perfundo";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnContinue_Click;
            // 
            // TimerCounter
            // 
            TimerCounter.AutoSize = true;
            TimerCounter.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            TimerCounter.Location = new Point(753, 62);
            TimerCounter.Name = "TimerCounter";
            TimerCounter.Size = new Size(0, 60);
            TimerCounter.TabIndex = 14;
            // 
            // MyTimer
            // 
            MyTimer.Interval = 1000;
            MyTimer.Tick += MyTimer_Tick;
            // 
            // minutes
            // 
            minutes.AutoSize = true;
            minutes.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            minutes.Location = new Point(683, 62);
            minutes.Name = "minutes";
            minutes.Size = new Size(0, 60);
            minutes.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(721, 61);
            label1.Name = "label1";
            label1.Size = new Size(0, 60);
            label1.TabIndex = 16;
            // 
            // ResultFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 20, 30);
            ClientSize = new Size(1440, 993);
            Controls.Add(label1);
            Controls.Add(minutes);
            Controls.Add(TimerCounter);
            Controls.Add(btnFinish);
            Controls.Add(txtTeam2Score);
            Controls.Add(txtTeam1Score);
            Controls.Add(E1port);
            Controls.Add(E2Port);
            Controls.Add(E2sulm);
            Controls.Add(E1sulm);
            Controls.Add(Team2);
            Controls.Add(Team1);
            ForeColor = Color.FromArgb(215, 106, 15);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultFrom";
            Text = "ResultFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Team1;
        private Label Team2;
        private Label E1sulm;
        private Label E2sulm;
        private Label E2Port;
        private Label E1port;
        private TextBox txtTeam1Score;
        private TextBox txtTeam2Score;
        private Button btnFinish;
        private Label TimerCounter;
        private System.Windows.Forms.Timer MyTimer;
        private Label minutes;
        private Label label1;
    }
}
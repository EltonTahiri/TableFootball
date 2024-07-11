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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultFrom));
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
            WinPercTeam1 = new Label();
            WinPercTeam2 = new Label();
            odds1 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            oddsX = new CheckBox();
            odds2 = new CheckBox();
            Bets = new Button();
            SuspendLayout();
            // 
            // Team1
            // 
            Team1.AutoSize = true;
            Team1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Team1.ForeColor = Color.White;
            Team1.Location = new Point(479, 121);
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
            Team2.Location = new Point(1297, 121);
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
            E1sulm.Location = new Point(479, 199);
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
            E2sulm.Location = new Point(1297, 199);
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
            E2Port.Location = new Point(1297, 275);
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
            E1port.Location = new Point(479, 275);
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
            txtTeam1Score.Location = new Point(722, 110);
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
            txtTeam2Score.Location = new Point(1118, 110);
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
            btnFinish.Location = new Point(756, 706);
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
            TimerCounter.Location = new Point(928, 112);
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
            minutes.Location = new Point(863, 112);
            minutes.Name = "minutes";
            minutes.Size = new Size(0, 60);
            minutes.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(899, 111);
            label1.Name = "label1";
            label1.Size = new Size(0, 60);
            label1.TabIndex = 16;
            // 
            // WinPercTeam1
            // 
            WinPercTeam1.AutoSize = true;
            WinPercTeam1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            WinPercTeam1.ForeColor = Color.White;
            WinPercTeam1.Location = new Point(479, 349);
            WinPercTeam1.Name = "WinPercTeam1";
            WinPercTeam1.Size = new Size(50, 60);
            WinPercTeam1.TabIndex = 17;
            WinPercTeam1.Text = "1";
            // 
            // WinPercTeam2
            // 
            WinPercTeam2.AutoSize = true;
            WinPercTeam2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            WinPercTeam2.ForeColor = Color.White;
            WinPercTeam2.Location = new Point(1293, 349);
            WinPercTeam2.Name = "WinPercTeam2";
            WinPercTeam2.Size = new Size(50, 60);
            WinPercTeam2.TabIndex = 18;
            WinPercTeam2.Text = "1";
            // 
            // odds1
            // 
            odds1.AutoSize = true;
            odds1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            odds1.Location = new Point(709, 563);
            odds1.Name = "odds1";
            odds1.Size = new Size(152, 35);
            odds1.TabIndex = 19;
            odds1.Text = "checkBox1";
            odds1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(709, 540);
            label2.Name = "label2";
            label2.Size = new Size(16, 18);
            label2.TabIndex = 20;
            label2.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(912, 540);
            label3.Name = "label3";
            label3.Size = new Size(18, 18);
            label3.TabIndex = 21;
            label3.Text = "X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1116, 540);
            label4.Name = "label4";
            label4.Size = new Size(16, 18);
            label4.TabIndex = 22;
            label4.Text = "2";
            // 
            // oddsX
            // 
            oddsX.AutoSize = true;
            oddsX.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            oddsX.Location = new Point(912, 563);
            oddsX.Name = "oddsX";
            oddsX.Size = new Size(152, 35);
            oddsX.TabIndex = 23;
            oddsX.Text = "checkBox1";
            oddsX.UseVisualStyleBackColor = true;
            // 
            // odds2
            // 
            odds2.AutoSize = true;
            odds2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            odds2.Location = new Point(1116, 563);
            odds2.Name = "odds2";
            odds2.Size = new Size(152, 35);
            odds2.TabIndex = 24;
            odds2.Text = "checkBox1";
            odds2.UseVisualStyleBackColor = true;
            // 
            // Bets
            // 
            Bets.BackColor = Color.Red;
            Bets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Bets.ForeColor = Color.White;
            Bets.Location = new Point(1428, 577);
            Bets.Name = "Bets";
            Bets.Size = new Size(94, 29);
            Bets.TabIndex = 25;
            Bets.Text = "Bet";
            Bets.UseVisualStyleBackColor = false;
            Bets.Click += Bets_Click;
            // 
            // ResultFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 20, 30);
            ClientSize = new Size(1811, 1093);
            Controls.Add(Bets);
            Controls.Add(odds2);
            Controls.Add(oddsX);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(odds1);
            Controls.Add(WinPercTeam2);
            Controls.Add(WinPercTeam1);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "ResultFrom";
            Text = "ResultFrom";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
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
        private Label WinPercTeam1;
        private Label WinPercTeam2;
        private CheckBox odds1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox oddsX;
        private CheckBox odds2;
        private Button Bets;
    }
}
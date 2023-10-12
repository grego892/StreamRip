namespace StreamRip
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CallLettersLbl = new Label();
            CallLettersTxt = new TextBox();
            StartRipBtn = new Button();
            dataBindBindingSource2 = new BindingSource(components);
            dataBindBindingSource = new BindingSource(components);
            streamStatusBindingSource = new BindingSource(components);
            StopRipBtn = new Button();
            dataBindBindingSource1 = new BindingSource(components);
            MonitorVolumeGrp = new GroupBox();
            MonitorVolumeTrk = new TrackBar();
            MonitorMuteBtn = new Button();
            CurrentSongTxt = new TextBox();
            songBindingSource = new BindingSource(components);
            streamProcessBindingSource = new BindingSource(components);
            NowPlayingGrp = new Label();
            OpenFolderBtn = new Button();
            AboutLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataBindBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataBindBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)streamStatusBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataBindBindingSource1).BeginInit();
            MonitorVolumeGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MonitorVolumeTrk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)songBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)streamProcessBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CallLettersLbl
            // 
            CallLettersLbl.AutoSize = true;
            CallLettersLbl.Location = new Point(17, 16);
            CallLettersLbl.Margin = new Padding(2, 0, 2, 0);
            CallLettersLbl.Name = "CallLettersLbl";
            CallLettersLbl.Size = new Size(65, 15);
            CallLettersLbl.TabIndex = 0;
            CallLettersLbl.Text = "Call Letters";
            // 
            // CallLettersTxt
            // 
            CallLettersTxt.Location = new Point(86, 12);
            CallLettersTxt.Margin = new Padding(2, 1, 2, 1);
            CallLettersTxt.Name = "CallLettersTxt";
            CallLettersTxt.Size = new Size(110, 23);
            CallLettersTxt.TabIndex = 1;
            // 
            // StartRipBtn
            // 
            StartRipBtn.DataBindings.Add(new Binding("Visible", dataBindBindingSource2, "StreamRunning", true));
            StartRipBtn.Location = new Point(200, 12);
            StartRipBtn.Margin = new Padding(2, 1, 2, 1);
            StartRipBtn.Name = "StartRipBtn";
            StartRipBtn.Size = new Size(66, 22);
            StartRipBtn.TabIndex = 2;
            StartRipBtn.Text = "Start Rip";
            StartRipBtn.UseVisualStyleBackColor = true;
            StartRipBtn.Click += StartRipBtn_Click;
            // 
            // dataBindBindingSource2
            // 
            dataBindBindingSource2.DataSource = typeof(StreamData);
            // 
            // StopRipBtn
            // 
            StopRipBtn.DataBindings.Add(new Binding("Visible", dataBindBindingSource1, "StreamRunning", true));
            StopRipBtn.Enabled = false;
            StopRipBtn.Location = new Point(272, 12);
            StopRipBtn.Margin = new Padding(2, 1, 2, 1);
            StopRipBtn.Name = "StopRipBtn";
            StopRipBtn.Size = new Size(65, 22);
            StopRipBtn.TabIndex = 3;
            StopRipBtn.Text = "Stop Rip";
            StopRipBtn.UseVisualStyleBackColor = true;
            StopRipBtn.Click += StopRipBtn_Click;
            // 
            // dataBindBindingSource1
            // 
            dataBindBindingSource1.DataSource = typeof(StreamData);
            // 
            // MonitorVolumeGrp
            // 
            MonitorVolumeGrp.Controls.Add(MonitorVolumeTrk);
            MonitorVolumeGrp.Controls.Add(MonitorMuteBtn);
            MonitorVolumeGrp.Location = new Point(12, 71);
            MonitorVolumeGrp.Margin = new Padding(2, 1, 2, 1);
            MonitorVolumeGrp.Name = "MonitorVolumeGrp";
            MonitorVolumeGrp.Padding = new Padding(2, 1, 2, 1);
            MonitorVolumeGrp.Size = new Size(192, 75);
            MonitorVolumeGrp.TabIndex = 4;
            MonitorVolumeGrp.TabStop = false;
            MonitorVolumeGrp.Text = "Monitor Volume";
            // 
            // MonitorVolumeTrk
            // 
            MonitorVolumeTrk.Location = new Point(74, 22);
            MonitorVolumeTrk.Margin = new Padding(2, 1, 2, 1);
            MonitorVolumeTrk.Maximum = 100;
            MonitorVolumeTrk.Name = "MonitorVolumeTrk";
            MonitorVolumeTrk.Size = new Size(112, 45);
            MonitorVolumeTrk.TabIndex = 1;
            MonitorVolumeTrk.Scroll += MonitorVolumeTrk_Scroll;
            // 
            // MonitorMuteBtn
            // 
            MonitorMuteBtn.Location = new Point(9, 22);
            MonitorMuteBtn.Margin = new Padding(2, 1, 2, 1);
            MonitorMuteBtn.Name = "MonitorMuteBtn";
            MonitorMuteBtn.Size = new Size(61, 22);
            MonitorMuteBtn.TabIndex = 0;
            MonitorMuteBtn.Text = "Unmute";
            MonitorMuteBtn.UseVisualStyleBackColor = true;
            MonitorMuteBtn.Click += MonitorMuteBtn_Click;
            // 
            // CurrentSongTxt
            // 
            CurrentSongTxt.DataBindings.Add(new Binding("Text", dataBindBindingSource1, "CurrentSong", true));
            CurrentSongTxt.Location = new Point(98, 43);
            CurrentSongTxt.Margin = new Padding(2, 1, 2, 1);
            CurrentSongTxt.Name = "CurrentSongTxt";
            CurrentSongTxt.ReadOnly = true;
            CurrentSongTxt.Size = new Size(335, 23);
            CurrentSongTxt.TabIndex = 5;
            // 
            // NowPlayingGrp
            // 
            NowPlayingGrp.AutoSize = true;
            NowPlayingGrp.Location = new Point(20, 46);
            NowPlayingGrp.Margin = new Padding(2, 0, 2, 0);
            NowPlayingGrp.Name = "NowPlayingGrp";
            NowPlayingGrp.Size = new Size(74, 15);
            NowPlayingGrp.TabIndex = 6;
            NowPlayingGrp.Text = "Now Playing";
            // 
            // OpenFolderBtn
            // 
            OpenFolderBtn.Location = new Point(352, 12);
            OpenFolderBtn.Margin = new Padding(2, 1, 2, 1);
            OpenFolderBtn.Name = "OpenFolderBtn";
            OpenFolderBtn.Size = new Size(90, 22);
            OpenFolderBtn.TabIndex = 8;
            OpenFolderBtn.Text = "Open Folder";
            OpenFolderBtn.UseVisualStyleBackColor = true;
            OpenFolderBtn.Click += OpenFolderBtn_Click;
            // 
            // AboutLbl
            // 
            AboutLbl.AutoSize = true;
            AboutLbl.Location = new Point(402, 133);
            AboutLbl.Margin = new Padding(2, 0, 2, 0);
            AboutLbl.Name = "AboutLbl";
            AboutLbl.Size = new Size(40, 15);
            AboutLbl.TabIndex = 9;
            AboutLbl.Text = "About";
            AboutLbl.Click += AboutLbl_Click;
            // 
            // MainForm
            // 
            AcceptButton = StartRipBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 157);
            Controls.Add(AboutLbl);
            Controls.Add(OpenFolderBtn);
            Controls.Add(NowPlayingGrp);
            Controls.Add(CurrentSongTxt);
            Controls.Add(MonitorVolumeGrp);
            Controls.Add(StopRipBtn);
            Controls.Add(StartRipBtn);
            Controls.Add(CallLettersTxt);
            Controls.Add(CallLettersLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            Name = "MainForm";
            Text = "StreamRip";
            ((System.ComponentModel.ISupportInitialize)dataBindBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataBindBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)streamStatusBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataBindBindingSource1).EndInit();
            MonitorVolumeGrp.ResumeLayout(false);
            MonitorVolumeGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MonitorVolumeTrk).EndInit();
            ((System.ComponentModel.ISupportInitialize)songBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)streamProcessBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CallLettersLbl;
        private TextBox CallLettersTxt;
        private Button StartRipBtn;
        private Button StopRipBtn;
        private GroupBox MonitorVolumeGrp;
        private TrackBar MonitorVolumeTrk;
        private Button MonitorMuteBtn;
        private TextBox CurrentSongTxt;
        private Label NowPlayingGrp;
        private BindingSource streamProcessBindingSource;
        private BindingSource songBindingSource;
        private BindingSource streamStatusBindingSource;
        private BindingSource dataBindBindingSource;
        private BindingSource dataBindBindingSource1;
        private BindingSource dataBindBindingSource2;
        private Button OpenFolderBtn;
        private Label AboutLbl;
    }
}

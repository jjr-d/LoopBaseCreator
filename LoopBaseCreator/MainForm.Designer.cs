namespace LoopBaseCreator
{
    partial class MainForm
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
            this.lblBpm = new System.Windows.Forms.Label();
            this.lblNbrBars = new System.Windows.Forms.Label();
            this.lblTimeSignature = new System.Windows.Forms.Label();
            this.lblNbrSamples = new System.Windows.Forms.Label();
            this.lblNbrSamplesValue = new System.Windows.Forms.Label();
            this.nudBpm = new System.Windows.Forms.NumericUpDown();
            this.nudNumberBars = new System.Windows.Forms.NumericUpDown();
            this.nudTimeSigTop = new System.Windows.Forms.NumericUpDown();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.lblBpmLimits = new System.Windows.Forms.Label();
            this.lblNumberBarsLimits = new System.Windows.Forms.Label();
            this.lblBeatsPerBarLimits = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblBeatDuration = new System.Windows.Forms.Label();
            this.cbNoteDuration = new System.Windows.Forms.ComboBox();
            this.cbTimeSigBottom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBpm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeSigTop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBpm
            // 
            this.lblBpm.AutoSize = true;
            this.lblBpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpm.Location = new System.Drawing.Point(18, 55);
            this.lblBpm.Name = "lblBpm";
            this.lblBpm.Size = new System.Drawing.Size(50, 24);
            this.lblBpm.TabIndex = 0;
            this.lblBpm.Text = "BPM";
            // 
            // lblNbrBars
            // 
            this.lblNbrBars.AutoSize = true;
            this.lblNbrBars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrBars.Location = new System.Drawing.Point(18, 80);
            this.lblNbrBars.Name = "lblNbrBars";
            this.lblNbrBars.Size = new System.Drawing.Size(140, 24);
            this.lblNbrBars.TabIndex = 1;
            this.lblNbrBars.Text = "Number of bars";
            // 
            // lblTimeSignature
            // 
            this.lblTimeSignature.AutoSize = true;
            this.lblTimeSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSignature.Location = new System.Drawing.Point(18, 121);
            this.lblTimeSignature.Name = "lblTimeSignature";
            this.lblTimeSignature.Size = new System.Drawing.Size(135, 24);
            this.lblTimeSignature.TabIndex = 2;
            this.lblTimeSignature.Text = "Time signature";
            // 
            // lblNbrSamples
            // 
            this.lblNbrSamples.AutoSize = true;
            this.lblNbrSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrSamples.Location = new System.Drawing.Point(18, 204);
            this.lblNbrSamples.Name = "lblNbrSamples";
            this.lblNbrSamples.Size = new System.Drawing.Size(174, 24);
            this.lblNbrSamples.TabIndex = 2;
            this.lblNbrSamples.Text = "Number of samples";
            // 
            // lblNbrSamplesValue
            // 
            this.lblNbrSamplesValue.AutoSize = true;
            this.lblNbrSamplesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrSamplesValue.Location = new System.Drawing.Point(219, 204);
            this.lblNbrSamplesValue.Name = "lblNbrSamplesValue";
            this.lblNbrSamplesValue.Size = new System.Drawing.Size(20, 24);
            this.lblNbrSamplesValue.TabIndex = 2;
            this.lblNbrSamplesValue.Text = "0";
            // 
            // nudBpm
            // 
            this.nudBpm.Location = new System.Drawing.Point(199, 56);
            this.nudBpm.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudBpm.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudBpm.Name = "nudBpm";
            this.nudBpm.Size = new System.Drawing.Size(40, 20);
            this.nudBpm.TabIndex = 1;
            this.nudBpm.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudBpm.Click += new System.EventHandler(this.NudBpmEnter);
            this.nudBpm.Enter += new System.EventHandler(this.NudBpmEnter);
            // 
            // nudNumberBars
            // 
            this.nudNumberBars.Location = new System.Drawing.Point(199, 81);
            this.nudNumberBars.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudNumberBars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberBars.Name = "nudNumberBars";
            this.nudNumberBars.Size = new System.Drawing.Size(40, 20);
            this.nudNumberBars.TabIndex = 2;
            this.nudNumberBars.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudNumberBars.Click += new System.EventHandler(this.NudNumberBarsEnter);
            this.nudNumberBars.Enter += new System.EventHandler(this.NudNumberBarsEnter);
            // 
            // nudTimeSigTop
            // 
            this.nudTimeSigTop.Location = new System.Drawing.Point(199, 112);
            this.nudTimeSigTop.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTimeSigTop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimeSigTop.Name = "nudTimeSigTop";
            this.nudTimeSigTop.Size = new System.Drawing.Size(40, 20);
            this.nudTimeSigTop.TabIndex = 3;
            this.nudTimeSigTop.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudTimeSigTop.Click += new System.EventHandler(this.NudBeatsPerBarEnter);
            this.nudTimeSigTop.Enter += new System.EventHandler(this.NudBeatsPerBarEnter);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(-1, 300);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(177, 13);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "LoopBaseCreator v1.0 (C) JJR 2018";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.Location = new System.Drawing.Point(82, 243);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(136, 38);
            this.btnCreateFile.TabIndex = 6;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // lblBpmLimits
            // 
            this.lblBpmLimits.AutoSize = true;
            this.lblBpmLimits.Location = new System.Drawing.Point(243, 60);
            this.lblBpmLimits.Name = "lblBpmLimits";
            this.lblBpmLimits.Size = new System.Drawing.Size(43, 13);
            this.lblBpmLimits.TabIndex = 6;
            this.lblBpmLimits.Text = "20..300";
            // 
            // lblNumberBarsLimits
            // 
            this.lblNumberBarsLimits.AutoSize = true;
            this.lblNumberBarsLimits.Location = new System.Drawing.Point(243, 85);
            this.lblNumberBarsLimits.Name = "lblNumberBarsLimits";
            this.lblNumberBarsLimits.Size = new System.Drawing.Size(37, 13);
            this.lblNumberBarsLimits.TabIndex = 6;
            this.lblNumberBarsLimits.Text = "1..200";
            // 
            // lblBeatsPerBarLimits
            // 
            this.lblBeatsPerBarLimits.AutoSize = true;
            this.lblBeatsPerBarLimits.Location = new System.Drawing.Point(243, 116);
            this.lblBeatsPerBarLimits.Name = "lblBeatsPerBarLimits";
            this.lblBeatsPerBarLimits.Size = new System.Drawing.Size(31, 13);
            this.lblBeatsPerBarLimits.TabIndex = 6;
            this.lblBeatsPerBarLimits.Text = "1..20";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.MaximumSize = new System.Drawing.Size(280, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(278, 26);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Create a zero-content wave file with length corresponding to the parameters given" +
    ".";
            // 
            // lblBeatDuration
            // 
            this.lblBeatDuration.AutoSize = true;
            this.lblBeatDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeatDuration.Location = new System.Drawing.Point(18, 159);
            this.lblBeatDuration.Name = "lblBeatDuration";
            this.lblBeatDuration.Size = new System.Drawing.Size(120, 24);
            this.lblBeatDuration.TabIndex = 2;
            this.lblBeatDuration.Text = "Beat duration";
            // 
            // cbNoteDuration
            // 
            this.cbNoteDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoteDuration.FormattingEnabled = true;
            this.cbNoteDuration.Location = new System.Drawing.Point(199, 160);
            this.cbNoteDuration.Name = "cbNoteDuration";
            this.cbNoteDuration.Size = new System.Drawing.Size(40, 21);
            this.cbNoteDuration.TabIndex = 5;
            // 
            // cbTimeSigBottom
            // 
            this.cbTimeSigBottom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeSigBottom.FormattingEnabled = true;
            this.cbTimeSigBottom.Location = new System.Drawing.Point(199, 134);
            this.cbTimeSigBottom.Name = "cbTimeSigBottom";
            this.cbTimeSigBottom.Size = new System.Drawing.Size(40, 21);
            this.cbTimeSigBottom.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCreateFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 315);
            this.Controls.Add(this.cbTimeSigBottom);
            this.Controls.Add(this.cbNoteDuration);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblBeatsPerBarLimits);
            this.Controls.Add(this.lblNumberBarsLimits);
            this.Controls.Add(this.lblBpmLimits);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.nudTimeSigTop);
            this.Controls.Add(this.nudNumberBars);
            this.Controls.Add(this.nudBpm);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.lblNbrSamplesValue);
            this.Controls.Add(this.lblNbrSamples);
            this.Controls.Add(this.lblBeatDuration);
            this.Controls.Add(this.lblTimeSignature);
            this.Controls.Add(this.lblNbrBars);
            this.Controls.Add(this.lblBpm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "LoopBaseCreator";
            ((System.ComponentModel.ISupportInitialize)(this.nudBpm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeSigTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBpm;
        private System.Windows.Forms.Label lblNbrBars;
        private System.Windows.Forms.Label lblTimeSignature;
        private System.Windows.Forms.Label lblNbrSamples;
        private System.Windows.Forms.Label lblNbrSamplesValue;
        private System.Windows.Forms.NumericUpDown nudBpm;
        private System.Windows.Forms.NumericUpDown nudNumberBars;
        private System.Windows.Forms.NumericUpDown nudTimeSigTop;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Label lblBpmLimits;
        private System.Windows.Forms.Label lblNumberBarsLimits;
        private System.Windows.Forms.Label lblBeatsPerBarLimits;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblBeatDuration;
        private System.Windows.Forms.ComboBox cbNoteDuration;
        private System.Windows.Forms.ComboBox cbTimeSigBottom;
    }
}


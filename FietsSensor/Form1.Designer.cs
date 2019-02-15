namespace FietsSensor
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.lblSmoothing = new System.Windows.Forms.Label();
            this.lblWindow = new System.Windows.Forms.Label();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.nudAlpha = new System.Windows.Forms.NumericUpDown();
            this.cmbSmoothing = new System.Windows.Forms.ComboBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.nudWindow = new System.Windows.Forms.NumericUpDown();
            this.pbxPlot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(689, 26);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(99, 33);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilename.Location = new System.Drawing.Point(203, 26);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(458, 28);
            this.txtFilename.TabIndex = 3;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(22, 31);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(94, 24);
            this.lblFilename.TabIndex = 4;
            this.lblFilename.Text = "Filename:";
            // 
            // lblSmoothing
            // 
            this.lblSmoothing.AutoSize = true;
            this.lblSmoothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmoothing.Location = new System.Drawing.Point(22, 85);
            this.lblSmoothing.Name = "lblSmoothing";
            this.lblSmoothing.Size = new System.Drawing.Size(175, 24);
            this.lblSmoothing.TabIndex = 5;
            this.lblSmoothing.Text = "Smoothing method:";
            // 
            // lblWindow
            // 
            this.lblWindow.AutoSize = true;
            this.lblWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindow.Location = new System.Drawing.Point(22, 139);
            this.lblWindow.Name = "lblWindow";
            this.lblWindow.Size = new System.Drawing.Size(79, 24);
            this.lblWindow.TabIndex = 6;
            this.lblWindow.Text = "Window";
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha.Location = new System.Drawing.Point(22, 139);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(64, 24);
            this.lblAlpha.TabIndex = 7;
            this.lblAlpha.Text = "Alpha:";
            // 
            // nudAlpha
            // 
            this.nudAlpha.DecimalPlaces = 2;
            this.nudAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAlpha.Location = new System.Drawing.Point(203, 135);
            this.nudAlpha.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAlpha.Name = "nudAlpha";
            this.nudAlpha.Size = new System.Drawing.Size(120, 28);
            this.nudAlpha.TabIndex = 8;
            this.nudAlpha.Value = new decimal(new int[] {
            40,
            0,
            0,
            131072});
            // 
            // cmbSmoothing
            // 
            this.cmbSmoothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSmoothing.FormattingEnabled = true;
            this.cmbSmoothing.Items.AddRange(new object[] {
            "Moving average",
            "Exponential smoothing"});
            this.cmbSmoothing.Location = new System.Drawing.Point(203, 82);
            this.cmbSmoothing.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSmoothing.Name = "cmbSmoothing";
            this.cmbSmoothing.Size = new System.Drawing.Size(202, 30);
            this.cmbSmoothing.TabIndex = 3;
            this.cmbSmoothing.SelectedIndexChanged += new System.EventHandler(this.cmbSmoothing_SelectedIndexChanged);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(25, 185);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(118, 24);
            this.lblResults.TabIndex = 10;
            this.lblResults.Text = "Speed (m/s):";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(203, 185);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(202, 239);
            this.txtResult.TabIndex = 11;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(26, 391);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 33);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // nudWindow
            // 
            this.nudWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWindow.Location = new System.Drawing.Point(203, 135);
            this.nudWindow.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudWindow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWindow.Name = "nudWindow";
            this.nudWindow.Size = new System.Drawing.Size(120, 28);
            this.nudWindow.TabIndex = 1;
            this.nudWindow.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // pbxPlot
            // 
            this.pbxPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxPlot.Location = new System.Drawing.Point(434, 82);
            this.pbxPlot.Name = "pbxPlot";
            this.pbxPlot.Size = new System.Drawing.Size(354, 342);
            this.pbxPlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlot.TabIndex = 13;
            this.pbxPlot.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxPlot);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.cmbSmoothing);
            this.Controls.Add(this.nudAlpha);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.lblWindow);
            this.Controls.Add(this.lblSmoothing);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.nudWindow);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Bike sensor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label lblSmoothing;
        private System.Windows.Forms.Label lblWindow;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.NumericUpDown nudAlpha;
        private System.Windows.Forms.ComboBox cmbSmoothing;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown nudWindow;
        private System.Windows.Forms.PictureBox pbxPlot;
    }
}


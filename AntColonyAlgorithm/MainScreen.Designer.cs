namespace AntColonyAlgorithmApp
{
    partial class MainScreen
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rdio_gamma = new System.Windows.Forms.RadioButton();
            this.btn_reset = new System.Windows.Forms.Button();
            this.rdio_poisson = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdio_uniform = new System.Windows.Forms.RadioButton();
            this.nupd_stepSize = new System.Windows.Forms.NumericUpDown();
            this.rdio_beta = new System.Windows.Forms.RadioButton();
            this.txt_stepCount = new System.Windows.Forms.TextBox();
            this.btn_step = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.nupd_antCount = new System.Windows.Forms.NumericUpDown();
            this.nupd_pointCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lstb_betaResult = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstb_uniformResult = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstb_expoResult = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstb_gammaResult = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nupd_runCount = new System.Windows.Forms.NumericUpDown();
            this.btn_runAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_stepSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_antCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_pointCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_runCount)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.nupd_runCount);
            this.splitContainer1.Panel1.Controls.Add(this.btn_runAll);
            this.splitContainer1.Panel1.Controls.Add(this.rdio_gamma);
            this.splitContainer1.Panel1.Controls.Add(this.btn_reset);
            this.splitContainer1.Panel1.Controls.Add(this.rdio_poisson);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.rdio_uniform);
            this.splitContainer1.Panel1.Controls.Add(this.nupd_stepSize);
            this.splitContainer1.Panel1.Controls.Add(this.rdio_beta);
            this.splitContainer1.Panel1.Controls.Add(this.txt_stepCount);
            this.splitContainer1.Panel1.Controls.Add(this.btn_step);
            this.splitContainer1.Panel1.Controls.Add(this.btn_set);
            this.splitContainer1.Panel1.Controls.Add(this.nupd_antCount);
            this.splitContainer1.Panel1.Controls.Add(this.nupd_pointCount);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1242, 868);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // rdio_gamma
            // 
            this.rdio_gamma.AutoSize = true;
            this.rdio_gamma.Location = new System.Drawing.Point(27, 579);
            this.rdio_gamma.Name = "rdio_gamma";
            this.rdio_gamma.Size = new System.Drawing.Size(78, 21);
            this.rdio_gamma.TabIndex = 3;
            this.rdio_gamma.TabStop = true;
            this.rdio_gamma.Text = "Gamma";
            this.rdio_gamma.UseVisualStyleBackColor = true;
            this.rdio_gamma.CheckedChanged += new System.EventHandler(this.rdio_gamma_CheckedChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(40, 250);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(65, 49);
            this.btn_reset.TabIndex = 0;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // rdio_poisson
            // 
            this.rdio_poisson.AutoSize = true;
            this.rdio_poisson.Location = new System.Drawing.Point(27, 551);
            this.rdio_poisson.Name = "rdio_poisson";
            this.rdio_poisson.Size = new System.Drawing.Size(102, 21);
            this.rdio_poisson.TabIndex = 2;
            this.rdio_poisson.TabStop = true;
            this.rdio_poisson.Text = "Exponential";
            this.rdio_poisson.UseVisualStyleBackColor = true;
            this.rdio_poisson.CheckedChanged += new System.EventHandler(this.rdio_binominal_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "X Times";
            // 
            // rdio_uniform
            // 
            this.rdio_uniform.AutoSize = true;
            this.rdio_uniform.Location = new System.Drawing.Point(27, 517);
            this.rdio_uniform.Name = "rdio_uniform";
            this.rdio_uniform.Size = new System.Drawing.Size(78, 21);
            this.rdio_uniform.TabIndex = 1;
            this.rdio_uniform.TabStop = true;
            this.rdio_uniform.Text = "Uniform";
            this.rdio_uniform.UseVisualStyleBackColor = true;
            this.rdio_uniform.CheckedChanged += new System.EventHandler(this.rdio_uniform_CheckedChanged);
            // 
            // nupd_stepSize
            // 
            this.nupd_stepSize.Enabled = false;
            this.nupd_stepSize.Location = new System.Drawing.Point(41, 344);
            this.nupd_stepSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupd_stepSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupd_stepSize.Name = "nupd_stepSize";
            this.nupd_stepSize.Size = new System.Drawing.Size(64, 22);
            this.nupd_stepSize.TabIndex = 0;
            this.nupd_stepSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdio_beta
            // 
            this.rdio_beta.AutoSize = true;
            this.rdio_beta.Checked = true;
            this.rdio_beta.Location = new System.Drawing.Point(27, 489);
            this.rdio_beta.Name = "rdio_beta";
            this.rdio_beta.Size = new System.Drawing.Size(58, 21);
            this.rdio_beta.TabIndex = 0;
            this.rdio_beta.TabStop = true;
            this.rdio_beta.Text = "Beta";
            this.rdio_beta.UseVisualStyleBackColor = true;
            this.rdio_beta.CheckedChanged += new System.EventHandler(this.Beta_CheckedChanged);
            // 
            // txt_stepCount
            // 
            this.txt_stepCount.Enabled = false;
            this.txt_stepCount.Location = new System.Drawing.Point(40, 442);
            this.txt_stepCount.Name = "txt_stepCount";
            this.txt_stepCount.ReadOnly = true;
            this.txt_stepCount.Size = new System.Drawing.Size(65, 22);
            this.txt_stepCount.TabIndex = 0;
            this.txt_stepCount.Text = "0";
            // 
            // btn_step
            // 
            this.btn_step.Enabled = false;
            this.btn_step.Location = new System.Drawing.Point(40, 379);
            this.btn_step.Name = "btn_step";
            this.btn_step.Size = new System.Drawing.Size(65, 50);
            this.btn_step.TabIndex = 4;
            this.btn_step.Text = "Step";
            this.btn_step.UseVisualStyleBackColor = true;
            this.btn_step.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(40, 184);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(65, 49);
            this.btn_set.TabIndex = 3;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // nupd_antCount
            // 
            this.nupd_antCount.Location = new System.Drawing.Point(40, 139);
            this.nupd_antCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupd_antCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupd_antCount.Name = "nupd_antCount";
            this.nupd_antCount.Size = new System.Drawing.Size(65, 22);
            this.nupd_antCount.TabIndex = 2;
            this.nupd_antCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nupd_pointCount
            // 
            this.nupd_pointCount.Location = new System.Drawing.Point(42, 63);
            this.nupd_pointCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nupd_pointCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nupd_pointCount.Name = "nupd_pointCount";
            this.nupd_pointCount.Size = new System.Drawing.Size(63, 22);
            this.nupd_pointCount.TabIndex = 0;
            this.nupd_pointCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ant Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point Count";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Salmon;
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.lstb_gammaResult);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.lstb_expoResult);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.lstb_uniformResult);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.lstb_betaResult);
            this.splitContainer2.Panel2MinSize = 150;
            this.splitContainer2.Size = new System.Drawing.Size(1068, 868);
            this.splitContainer2.SplitterDistance = 710;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // lstb_betaResult
            // 
            this.lstb_betaResult.FormattingEnabled = true;
            this.lstb_betaResult.ItemHeight = 16;
            this.lstb_betaResult.Location = new System.Drawing.Point(13, 30);
            this.lstb_betaResult.Name = "lstb_betaResult";
            this.lstb_betaResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstb_betaResult.Size = new System.Drawing.Size(239, 116);
            this.lstb_betaResult.TabIndex = 0;
            this.lstb_betaResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstb_betaResult_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Beta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Uniform";
            // 
            // lstb_uniformResult
            // 
            this.lstb_uniformResult.FormattingEnabled = true;
            this.lstb_uniformResult.ItemHeight = 16;
            this.lstb_uniformResult.Location = new System.Drawing.Point(264, 30);
            this.lstb_uniformResult.Name = "lstb_uniformResult";
            this.lstb_uniformResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstb_uniformResult.Size = new System.Drawing.Size(239, 116);
            this.lstb_uniformResult.TabIndex = 2;
            this.lstb_uniformResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstb_betaResult_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Exponential";
            // 
            // lstb_expoResult
            // 
            this.lstb_expoResult.FormattingEnabled = true;
            this.lstb_expoResult.ItemHeight = 16;
            this.lstb_expoResult.Location = new System.Drawing.Point(515, 29);
            this.lstb_expoResult.Name = "lstb_expoResult";
            this.lstb_expoResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstb_expoResult.Size = new System.Drawing.Size(239, 116);
            this.lstb_expoResult.TabIndex = 4;
            this.lstb_expoResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstb_betaResult_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(850, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gamma";
            // 
            // lstb_gammaResult
            // 
            this.lstb_gammaResult.FormattingEnabled = true;
            this.lstb_gammaResult.ItemHeight = 16;
            this.lstb_gammaResult.Location = new System.Drawing.Point(769, 29);
            this.lstb_gammaResult.Name = "lstb_gammaResult";
            this.lstb_gammaResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstb_gammaResult.Size = new System.Drawing.Size(239, 116);
            this.lstb_gammaResult.TabIndex = 6;
            this.lstb_gammaResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstb_betaResult_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 627);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Y Times";
            // 
            // nupd_runCount
            // 
            this.nupd_runCount.Enabled = false;
            this.nupd_runCount.Location = new System.Drawing.Point(39, 659);
            this.nupd_runCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupd_runCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupd_runCount.Name = "nupd_runCount";
            this.nupd_runCount.Size = new System.Drawing.Size(64, 22);
            this.nupd_runCount.TabIndex = 6;
            this.nupd_runCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_runAll
            // 
            this.btn_runAll.Enabled = false;
            this.btn_runAll.Location = new System.Drawing.Point(38, 694);
            this.btn_runAll.Name = "btn_runAll";
            this.btn_runAll.Size = new System.Drawing.Size(65, 50);
            this.btn_runAll.TabIndex = 7;
            this.btn_runAll.Text = "Run All";
            this.btn_runAll.UseVisualStyleBackColor = true;
            this.btn_runAll.Click += new System.EventHandler(this.btn_runAll_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 868);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainScreen_Paint);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupd_stepSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_antCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_pointCount)).EndInit();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupd_runCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.NumericUpDown nupd_antCount;
        private System.Windows.Forms.NumericUpDown nupd_pointCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_step;
        private System.Windows.Forms.TextBox txt_stepCount;
        private System.Windows.Forms.NumericUpDown nupd_stepSize;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdio_gamma;
        private System.Windows.Forms.RadioButton rdio_poisson;
        private System.Windows.Forms.RadioButton rdio_uniform;
        private System.Windows.Forms.RadioButton rdio_beta;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lstb_betaResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstb_gammaResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstb_expoResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstb_uniformResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nupd_runCount;
        private System.Windows.Forms.Button btn_runAll;
    }
}
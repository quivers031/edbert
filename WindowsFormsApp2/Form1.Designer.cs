namespace WindowsFormsApp2
{
    partial class FormHasilPertandingan
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
            this.comboBoxHomeTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxAwayTeam = new System.Windows.Forms.ComboBox();
            this.labelVS = new System.Windows.Forms.Label();
            this.labelManagerH = new System.Windows.Forms.Label();
            this.labelCaptainH = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelManagerA = new System.Windows.Forms.Label();
            this.labelCaptainA = new System.Windows.Forms.Label();
            this.labelNManagerH = new System.Windows.Forms.Label();
            this.labelNCaptainH = new System.Windows.Forms.Label();
            this.labelNManagerA = new System.Windows.Forms.Label();
            this.labelNCaptainA = new System.Windows.Forms.Label();
            this.labelStadiumHome = new System.Windows.Forms.Label();
            this.labelCapacityStadiumH = new System.Windows.Forms.Label();
            this.dgvPertandingan = new System.Windows.Forms.DataGridView();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelIsiTanggal = new System.Windows.Forms.Label();
            this.labelSkor = new System.Windows.Forms.Label();
            this.labelIsiSkor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPertandingan)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxHomeTeam
            // 
            this.comboBoxHomeTeam.FormattingEnabled = true;
            this.comboBoxHomeTeam.Location = new System.Drawing.Point(76, 7);
            this.comboBoxHomeTeam.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxHomeTeam.Name = "comboBoxHomeTeam";
            this.comboBoxHomeTeam.Size = new System.Drawing.Size(260, 24);
            this.comboBoxHomeTeam.TabIndex = 0;
            this.comboBoxHomeTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxHomeTeam_SelectedIndexChanged);
            // 
            // comboBoxAwayTeam
            // 
            this.comboBoxAwayTeam.FormattingEnabled = true;
            this.comboBoxAwayTeam.Location = new System.Drawing.Point(802, 7);
            this.comboBoxAwayTeam.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAwayTeam.Name = "comboBoxAwayTeam";
            this.comboBoxAwayTeam.Size = new System.Drawing.Size(260, 24);
            this.comboBoxAwayTeam.TabIndex = 1;
            this.comboBoxAwayTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxAwayTeam_SelectedIndexChanged);
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Location = new System.Drawing.Point(480, 7);
            this.labelVS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(26, 17);
            this.labelVS.TabIndex = 2;
            this.labelVS.Text = "VS";
            // 
            // labelManagerH
            // 
            this.labelManagerH.AutoSize = true;
            this.labelManagerH.Location = new System.Drawing.Point(76, 81);
            this.labelManagerH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManagerH.Name = "labelManagerH";
            this.labelManagerH.Size = new System.Drawing.Size(76, 17);
            this.labelManagerH.TabIndex = 3;
            this.labelManagerH.Text = "Manager : ";
            // 
            // labelCaptainH
            // 
            this.labelCaptainH.AutoSize = true;
            this.labelCaptainH.Location = new System.Drawing.Point(76, 140);
            this.labelCaptainH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCaptainH.Name = "labelCaptainH";
            this.labelCaptainH.Size = new System.Drawing.Size(68, 17);
            this.labelCaptainH.TabIndex = 4;
            this.labelCaptainH.Text = "Captain : ";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(410, 113);
            this.labelStadium.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(71, 17);
            this.labelStadium.TabIndex = 5;
            this.labelStadium.Text = "Stadium : ";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(410, 163);
            this.labelCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(74, 17);
            this.labelCapacity.TabIndex = 6;
            this.labelCapacity.Text = "Capacity : ";
            // 
            // labelManagerA
            // 
            this.labelManagerA.AutoSize = true;
            this.labelManagerA.Location = new System.Drawing.Point(799, 74);
            this.labelManagerA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManagerA.Name = "labelManagerA";
            this.labelManagerA.Size = new System.Drawing.Size(76, 17);
            this.labelManagerA.TabIndex = 7;
            this.labelManagerA.Text = "Manager : ";
            // 
            // labelCaptainA
            // 
            this.labelCaptainA.AutoSize = true;
            this.labelCaptainA.Location = new System.Drawing.Point(799, 133);
            this.labelCaptainA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCaptainA.Name = "labelCaptainA";
            this.labelCaptainA.Size = new System.Drawing.Size(68, 17);
            this.labelCaptainA.TabIndex = 8;
            this.labelCaptainA.Text = "Captain : ";
            // 
            // labelNManagerH
            // 
            this.labelNManagerH.AutoSize = true;
            this.labelNManagerH.Location = new System.Drawing.Point(163, 81);
            this.labelNManagerH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNManagerH.Name = "labelNManagerH";
            this.labelNManagerH.Size = new System.Drawing.Size(46, 17);
            this.labelNManagerH.TabIndex = 9;
            this.labelNManagerH.Text = "label8";
            // 
            // labelNCaptainH
            // 
            this.labelNCaptainH.AutoSize = true;
            this.labelNCaptainH.Location = new System.Drawing.Point(163, 140);
            this.labelNCaptainH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNCaptainH.Name = "labelNCaptainH";
            this.labelNCaptainH.Size = new System.Drawing.Size(46, 17);
            this.labelNCaptainH.TabIndex = 10;
            this.labelNCaptainH.Text = "label9";
            // 
            // labelNManagerA
            // 
            this.labelNManagerA.AutoSize = true;
            this.labelNManagerA.Location = new System.Drawing.Point(888, 74);
            this.labelNManagerA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNManagerA.Name = "labelNManagerA";
            this.labelNManagerA.Size = new System.Drawing.Size(54, 17);
            this.labelNManagerA.TabIndex = 11;
            this.labelNManagerA.Text = "label10";
            // 
            // labelNCaptainA
            // 
            this.labelNCaptainA.AutoSize = true;
            this.labelNCaptainA.Location = new System.Drawing.Point(888, 133);
            this.labelNCaptainA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNCaptainA.Name = "labelNCaptainA";
            this.labelNCaptainA.Size = new System.Drawing.Size(54, 17);
            this.labelNCaptainA.TabIndex = 12;
            this.labelNCaptainA.Text = "label11";
            // 
            // labelStadiumHome
            // 
            this.labelStadiumHome.AutoSize = true;
            this.labelStadiumHome.Location = new System.Drawing.Point(511, 113);
            this.labelStadiumHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStadiumHome.Name = "labelStadiumHome";
            this.labelStadiumHome.Size = new System.Drawing.Size(54, 17);
            this.labelStadiumHome.TabIndex = 13;
            this.labelStadiumHome.Text = "label12";
            // 
            // labelCapacityStadiumH
            // 
            this.labelCapacityStadiumH.AutoSize = true;
            this.labelCapacityStadiumH.Location = new System.Drawing.Point(511, 163);
            this.labelCapacityStadiumH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCapacityStadiumH.Name = "labelCapacityStadiumH";
            this.labelCapacityStadiumH.Size = new System.Drawing.Size(54, 17);
            this.labelCapacityStadiumH.TabIndex = 14;
            this.labelCapacityStadiumH.Text = "label13";
            // 
            // dgvPertandingan
            // 
            this.dgvPertandingan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPertandingan.Location = new System.Drawing.Point(37, 306);
            this.dgvPertandingan.Name = "dgvPertandingan";
            this.dgvPertandingan.RowHeadersWidth = 51;
            this.dgvPertandingan.RowTemplate.Height = 24;
            this.dgvPertandingan.Size = new System.Drawing.Size(1019, 271);
            this.dgvPertandingan.TabIndex = 15;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(459, 199);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 16;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(407, 225);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(72, 17);
            this.labelTanggal.TabIndex = 17;
            this.labelTanggal.Text = "Tanggal : ";
            // 
            // labelIsiTanggal
            // 
            this.labelIsiTanggal.AutoSize = true;
            this.labelIsiTanggal.Location = new System.Drawing.Point(511, 225);
            this.labelIsiTanggal.Name = "labelIsiTanggal";
            this.labelIsiTanggal.Size = new System.Drawing.Size(38, 17);
            this.labelIsiTanggal.TabIndex = 18;
            this.labelIsiTanggal.Text = "------";
            // 
            // labelSkor
            // 
            this.labelSkor.AutoSize = true;
            this.labelSkor.Location = new System.Drawing.Point(407, 267);
            this.labelSkor.Name = "labelSkor";
            this.labelSkor.Size = new System.Drawing.Size(49, 17);
            this.labelSkor.TabIndex = 19;
            this.labelSkor.Text = "Skor : ";
            // 
            // labelIsiSkor
            // 
            this.labelIsiSkor.AutoSize = true;
            this.labelIsiSkor.Location = new System.Drawing.Point(511, 267);
            this.labelIsiSkor.Name = "labelIsiSkor";
            this.labelIsiSkor.Size = new System.Drawing.Size(38, 17);
            this.labelIsiSkor.TabIndex = 20;
            this.labelIsiSkor.Text = "------";
            // 
            // FormHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 589);
            this.Controls.Add(this.labelIsiSkor);
            this.Controls.Add(this.labelSkor);
            this.Controls.Add(this.labelIsiTanggal);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.dgvPertandingan);
            this.Controls.Add(this.labelCapacityStadiumH);
            this.Controls.Add(this.labelStadiumHome);
            this.Controls.Add(this.labelNCaptainA);
            this.Controls.Add(this.labelNManagerA);
            this.Controls.Add(this.labelNCaptainH);
            this.Controls.Add(this.labelNManagerH);
            this.Controls.Add(this.labelCaptainA);
            this.Controls.Add(this.labelManagerA);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelCaptainH);
            this.Controls.Add(this.labelManagerH);
            this.Controls.Add(this.labelVS);
            this.Controls.Add(this.comboBoxAwayTeam);
            this.Controls.Add(this.comboBoxHomeTeam);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.FormHasilPertandingan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPertandingan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHomeTeam;
        private System.Windows.Forms.ComboBox comboBoxAwayTeam;
        private System.Windows.Forms.Label labelVS;
        private System.Windows.Forms.Label labelManagerH;
        private System.Windows.Forms.Label labelCaptainH;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelManagerA;
        private System.Windows.Forms.Label labelCaptainA;
        private System.Windows.Forms.Label labelNManagerH;
        private System.Windows.Forms.Label labelNCaptainH;
        private System.Windows.Forms.Label labelNManagerA;
        private System.Windows.Forms.Label labelNCaptainA;
        private System.Windows.Forms.Label labelStadiumHome;
        private System.Windows.Forms.Label labelCapacityStadiumH;
        private System.Windows.Forms.DataGridView dgvPertandingan;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelIsiTanggal;
        private System.Windows.Forms.Label labelSkor;
        private System.Windows.Forms.Label labelIsiSkor;
    }
}


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
            this.SuspendLayout();
            // 
            // comboBoxHomeTeam
            // 
            this.comboBoxHomeTeam.FormattingEnabled = true;
            this.comboBoxHomeTeam.Location = new System.Drawing.Point(58, 36);
            this.comboBoxHomeTeam.Name = "comboBoxHomeTeam";
            this.comboBoxHomeTeam.Size = new System.Drawing.Size(196, 21);
            this.comboBoxHomeTeam.TabIndex = 0;
            this.comboBoxHomeTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxHomeTeam_SelectedIndexChanged);
            // 
            // comboBoxAwayTeam
            // 
            this.comboBoxAwayTeam.FormattingEnabled = true;
            this.comboBoxAwayTeam.Location = new System.Drawing.Point(500, 36);
            this.comboBoxAwayTeam.Name = "comboBoxAwayTeam";
            this.comboBoxAwayTeam.Size = new System.Drawing.Size(196, 21);
            this.comboBoxAwayTeam.TabIndex = 1;
            this.comboBoxAwayTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxAwayTeam_SelectedIndexChanged);
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Location = new System.Drawing.Point(361, 36);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(21, 13);
            this.labelVS.TabIndex = 2;
            this.labelVS.Text = "VS";
            // 
            // labelManagerH
            // 
            this.labelManagerH.AutoSize = true;
            this.labelManagerH.Location = new System.Drawing.Point(58, 96);
            this.labelManagerH.Name = "labelManagerH";
            this.labelManagerH.Size = new System.Drawing.Size(58, 13);
            this.labelManagerH.TabIndex = 3;
            this.labelManagerH.Text = "Manager : ";
            // 
            // labelCaptainH
            // 
            this.labelCaptainH.AutoSize = true;
            this.labelCaptainH.Location = new System.Drawing.Point(58, 144);
            this.labelCaptainH.Name = "labelCaptainH";
            this.labelCaptainH.Size = new System.Drawing.Size(52, 13);
            this.labelCaptainH.TabIndex = 4;
            this.labelCaptainH.Text = "Captain : ";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(300, 211);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(54, 13);
            this.labelStadium.TabIndex = 5;
            this.labelStadium.Text = "Stadium : ";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(300, 252);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(57, 13);
            this.labelCapacity.TabIndex = 6;
            this.labelCapacity.Text = "Capacity : ";
            // 
            // labelManagerA
            // 
            this.labelManagerA.AutoSize = true;
            this.labelManagerA.Location = new System.Drawing.Point(497, 96);
            this.labelManagerA.Name = "labelManagerA";
            this.labelManagerA.Size = new System.Drawing.Size(58, 13);
            this.labelManagerA.TabIndex = 7;
            this.labelManagerA.Text = "Manager : ";
            // 
            // labelCaptainA
            // 
            this.labelCaptainA.AutoSize = true;
            this.labelCaptainA.Location = new System.Drawing.Point(497, 144);
            this.labelCaptainA.Name = "labelCaptainA";
            this.labelCaptainA.Size = new System.Drawing.Size(52, 13);
            this.labelCaptainA.TabIndex = 8;
            this.labelCaptainA.Text = "Captain : ";
            // 
            // labelNManagerH
            // 
            this.labelNManagerH.AutoSize = true;
            this.labelNManagerH.Location = new System.Drawing.Point(123, 96);
            this.labelNManagerH.Name = "labelNManagerH";
            this.labelNManagerH.Size = new System.Drawing.Size(35, 13);
            this.labelNManagerH.TabIndex = 9;
            this.labelNManagerH.Text = "label8";
            // 
            // labelNCaptainH
            // 
            this.labelNCaptainH.AutoSize = true;
            this.labelNCaptainH.Location = new System.Drawing.Point(123, 144);
            this.labelNCaptainH.Name = "labelNCaptainH";
            this.labelNCaptainH.Size = new System.Drawing.Size(35, 13);
            this.labelNCaptainH.TabIndex = 10;
            this.labelNCaptainH.Text = "label9";
            // 
            // labelNManagerA
            // 
            this.labelNManagerA.AutoSize = true;
            this.labelNManagerA.Location = new System.Drawing.Point(564, 96);
            this.labelNManagerA.Name = "labelNManagerA";
            this.labelNManagerA.Size = new System.Drawing.Size(41, 13);
            this.labelNManagerA.TabIndex = 11;
            this.labelNManagerA.Text = "label10";
            // 
            // labelNCaptainA
            // 
            this.labelNCaptainA.AutoSize = true;
            this.labelNCaptainA.Location = new System.Drawing.Point(564, 144);
            this.labelNCaptainA.Name = "labelNCaptainA";
            this.labelNCaptainA.Size = new System.Drawing.Size(41, 13);
            this.labelNCaptainA.TabIndex = 12;
            this.labelNCaptainA.Text = "label11";
            // 
            // labelStadiumHome
            // 
            this.labelStadiumHome.AutoSize = true;
            this.labelStadiumHome.Location = new System.Drawing.Point(376, 211);
            this.labelStadiumHome.Name = "labelStadiumHome";
            this.labelStadiumHome.Size = new System.Drawing.Size(41, 13);
            this.labelStadiumHome.TabIndex = 13;
            this.labelStadiumHome.Text = "label12";
            // 
            // labelCapacityStadiumH
            // 
            this.labelCapacityStadiumH.AutoSize = true;
            this.labelCapacityStadiumH.Location = new System.Drawing.Point(376, 252);
            this.labelCapacityStadiumH.Name = "labelCapacityStadiumH";
            this.labelCapacityStadiumH.Size = new System.Drawing.Size(41, 13);
            this.labelCapacityStadiumH.TabIndex = 14;
            this.labelCapacityStadiumH.Text = "label13";
            // 
            // FormHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FormHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.FormHasilPertandingan_Load);
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
    }
}


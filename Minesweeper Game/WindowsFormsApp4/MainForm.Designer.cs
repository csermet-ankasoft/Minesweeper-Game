namespace Minesweeper_Game
{
    partial class FormGamePlace
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
            this.panelUp = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelx = new System.Windows.Forms.Label();
            this.ComboBoxRight = new System.Windows.Forms.ComboBox();
            this.ComboBoxLeft = new System.Windows.Forms.ComboBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.ComboBoxBomb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGamePlace = new System.Windows.Forms.Panel();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.CadetBlue;
            this.panelUp.Controls.Add(this.button1);
            this.panelUp.Controls.Add(this.labelx);
            this.panelUp.Controls.Add(this.ComboBoxRight);
            this.panelUp.Controls.Add(this.ComboBoxLeft);
            this.panelUp.Controls.Add(this.buttonSettings);
            this.panelUp.Controls.Add(this.buttonStart);
            this.panelUp.Controls.Add(this.ComboBoxBomb);
            this.panelUp.Controls.Add(this.label2);
            this.panelUp.Controls.Add(this.label4);
            this.panelUp.Controls.Add(this.label3);
            this.panelUp.Controls.Add(this.label1);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(678, 80);
            this.panelUp.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.button1.Location = new System.Drawing.Point(299, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "HighScore";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelx.Location = new System.Drawing.Point(217, 8);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(20, 24);
            this.labelx.TabIndex = 4;
            this.labelx.Text = "x";
            // 
            // ComboBoxRight
            // 
            this.ComboBoxRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboBoxRight.FormattingEnabled = true;
            this.ComboBoxRight.Location = new System.Drawing.Point(243, 6);
            this.ComboBoxRight.Name = "ComboBoxRight";
            this.ComboBoxRight.Size = new System.Drawing.Size(45, 32);
            this.ComboBoxRight.TabIndex = 3;
            this.ComboBoxRight.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // ComboBoxLeft
            // 
            this.ComboBoxLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboBoxLeft.FormattingEnabled = true;
            this.ComboBoxLeft.Location = new System.Drawing.Point(166, 6);
            this.ComboBoxLeft.Name = "ComboBoxLeft";
            this.ComboBoxLeft.Size = new System.Drawing.Size(45, 32);
            this.ComboBoxLeft.TabIndex = 2;
            this.ComboBoxLeft.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Settings;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(5, 4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(37, 38);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonStart.FlatAppearance.BorderSize = 4;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Nirmala UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(563, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(105, 65);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboBoxBomb
            // 
            this.ComboBoxBomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboBoxBomb.FormattingEnabled = true;
            this.ComboBoxBomb.Location = new System.Drawing.Point(166, 43);
            this.ComboBoxBomb.Name = "ComboBoxBomb";
            this.ComboBoxBomb.Size = new System.Drawing.Size(61, 32);
            this.ComboBoxBomb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bomb Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(410, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Score : 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(295, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Left Bomb Number : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Place :";
            // 
            // panelGamePlace
            // 
            this.panelGamePlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGamePlace.Location = new System.Drawing.Point(0, 80);
            this.panelGamePlace.Name = "panelGamePlace";
            this.panelGamePlace.Size = new System.Drawing.Size(678, 675);
            this.panelGamePlace.TabIndex = 6;
            // 
            // FormGamePlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(678, 755);
            this.Controls.Add(this.panelGamePlace);
            this.Controls.Add(this.panelUp);
            this.MinimumSize = new System.Drawing.Size(670, 670);
            this.Name = "FormGamePlace";
            this.Text = "Minesweeper_Game CNR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ComboBox ComboBoxBomb;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.ComboBox ComboBoxRight;
        private System.Windows.Forms.ComboBox ComboBoxLeft;
        private System.Windows.Forms.Panel panelGamePlace;
        private System.Windows.Forms.Button button1;
    }
}


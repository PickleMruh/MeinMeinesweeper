using System;

namespace MeinMinesweeper
{
    partial class MeinMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.presetEasy = new System.Windows.Forms.Button();
            this.presetMedium = new System.Windows.Forms.Button();
            this.presetHard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.isTimeSet = new System.Windows.Forms.CheckBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.labelMines = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.sizeX = new System.Windows.Forms.NumericUpDown();
            this.sizeY = new System.Windows.Forms.NumericUpDown();
            this.minesNumber = new System.Windows.Forms.NumericUpDown();
            this.timeLimit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(300, 450);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 50);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // presetEasy
            // 
            this.presetEasy.Font = new System.Drawing.Font("Calibri", 18F);
            this.presetEasy.Location = new System.Drawing.Point(100, 100);
            this.presetEasy.Name = "presetEasy";
            this.presetEasy.Size = new System.Drawing.Size(189, 50);
            this.presetEasy.TabIndex = 1;
            this.presetEasy.Text = "Easy";
            this.presetEasy.UseVisualStyleBackColor = true;
            this.presetEasy.Click += new System.EventHandler(this.PresetEasy_Click);
            // 
            // presetMedium
            // 
            this.presetMedium.Font = new System.Drawing.Font("Calibri", 18F);
            this.presetMedium.Location = new System.Drawing.Point(100, 156);
            this.presetMedium.Name = "presetMedium";
            this.presetMedium.Size = new System.Drawing.Size(189, 50);
            this.presetMedium.TabIndex = 2;
            this.presetMedium.Text = "Medium";
            this.presetMedium.UseVisualStyleBackColor = true;
            this.presetMedium.Click += new System.EventHandler(this.PresetMedium_Click);
            // 
            // presetHard
            // 
            this.presetHard.Font = new System.Drawing.Font("Calibri", 18F);
            this.presetHard.Location = new System.Drawing.Point(100, 212);
            this.presetHard.Name = "presetHard";
            this.presetHard.Size = new System.Drawing.Size(189, 50);
            this.presetHard.TabIndex = 3;
            this.presetHard.Text = "Hard";
            this.presetHard.UseVisualStyleBackColor = true;
            this.presetHard.Click += new System.EventHandler(this.PresetHard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(100, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set difficulty level";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // isTimeSet
            // 
            this.isTimeSet.AutoSize = true;
            this.isTimeSet.Location = new System.Drawing.Point(522, 215);
            this.isTimeSet.Name = "isTimeSet";
            this.isTimeSet.Size = new System.Drawing.Size(108, 17);
            this.isTimeSet.TabIndex = 8;
            this.isTimeSet.Text = "Time to explosion";
            this.isTimeSet.UseVisualStyleBackColor = true;
            this.isTimeSet.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRows.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRows.Location = new System.Drawing.Point(460, 103);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(56, 26);
            this.labelRows.TabIndex = 10;
            this.labelRows.Text = "Rows";
            this.labelRows.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumns.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelColumns.Location = new System.Drawing.Point(431, 141);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(85, 26);
            this.labelColumns.TabIndex = 11;
            this.labelColumns.Text = "Columns";
            this.labelColumns.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelMines
            // 
            this.labelMines.AutoSize = true;
            this.labelMines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMines.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMines.Location = new System.Drawing.Point(453, 179);
            this.labelMines.Name = "labelMines";
            this.labelMines.Size = new System.Drawing.Size(63, 26);
            this.labelMines.TabIndex = 12;
            this.labelMines.Text = "Mines";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(420, 240);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(96, 26);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "Time limit";
            // 
            // sizeX
            // 
            this.sizeX.Font = new System.Drawing.Font("Calibri", 15F);
            this.sizeX.Location = new System.Drawing.Point(522, 101);
            this.sizeX.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.sizeX.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.sizeX.Name = "sizeX";
            this.sizeX.Size = new System.Drawing.Size(108, 32);
            this.sizeX.TabIndex = 14;
            this.sizeX.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.sizeX.ValueChanged += new System.EventHandler(this.SizeX_ValueChanged);
            // 
            // sizeY
            // 
            this.sizeY.Font = new System.Drawing.Font("Calibri", 15F);
            this.sizeY.Location = new System.Drawing.Point(522, 139);
            this.sizeY.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.sizeY.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.sizeY.Name = "sizeY";
            this.sizeY.Size = new System.Drawing.Size(108, 32);
            this.sizeY.TabIndex = 15;
            this.sizeY.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // minesNumber
            // 
            this.minesNumber.Font = new System.Drawing.Font("Calibri", 15F);
            this.minesNumber.Location = new System.Drawing.Point(522, 177);
            this.minesNumber.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.minesNumber.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minesNumber.Name = "minesNumber";
            this.minesNumber.Size = new System.Drawing.Size(108, 32);
            this.minesNumber.TabIndex = 16;
            this.minesNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // timeLimit
            // 
            this.timeLimit.Font = new System.Drawing.Font("Calibri", 15F);
            this.timeLimit.Location = new System.Drawing.Point(522, 238);
            this.timeLimit.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.timeLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeLimit.Name = "timeLimit";
            this.timeLimit.Size = new System.Drawing.Size(108, 32);
            this.timeLimit.TabIndex = 17;
            this.timeLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MeinMenu
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.timeLimit);
            this.Controls.Add(this.minesNumber);
            this.Controls.Add(this.sizeY);
            this.Controls.Add(this.sizeX);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMines);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.isTimeSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.presetHard);
            this.Controls.Add(this.presetMedium);
            this.Controls.Add(this.presetEasy);
            this.Controls.Add(this.startButton);
            this.Name = "MeinMenu";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button presetEasy;
        private System.Windows.Forms.Button presetMedium;
        private System.Windows.Forms.Button presetHard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isTimeSet;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Label labelMines;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.NumericUpDown sizeX;
        private System.Windows.Forms.NumericUpDown sizeY;
        private System.Windows.Forms.NumericUpDown minesNumber;
        private System.Windows.Forms.NumericUpDown timeLimit;
    }
}


namespace WindowsFormsApp
{
    partial class LottoProgram
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
            this.startBtn = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.TextBox();
            this.six = new System.Windows.Forms.TextBox();
            this.five = new System.Windows.Forms.TextBox();
            this.row1 = new System.Windows.Forms.NumericUpDown();
            this.row2 = new System.Windows.Forms.NumericUpDown();
            this.row3 = new System.Windows.Forms.NumericUpDown();
            this.row4 = new System.Windows.Forms.NumericUpDown();
            this.row5 = new System.Windows.Forms.NumericUpDown();
            this.row6 = new System.Windows.Forms.NumericUpDown();
            this.row7 = new System.Windows.Forms.NumericUpDown();
            this.turns = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.row1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.row2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.row3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.row4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.row5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.row6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.row7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turns)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(358, 130);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(131, 31);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "Starta lotto";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.HighlightText;
            this.seven.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seven.CausesValidation = false;
            this.seven.Cursor = System.Windows.Forms.Cursors.Default;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(434, 209);
            this.seven.Name = "seven";
            this.seven.ReadOnly = true;
            this.seven.ShortcutsEnabled = false;
            this.seven.Size = new System.Drawing.Size(92, 19);
            this.seven.TabIndex = 11;
            this.seven.TabStop = false;
            this.seven.Text = "0";
            this.seven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.HighlightText;
            this.six.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.six.CausesValidation = false;
            this.six.Cursor = System.Windows.Forms.Cursors.Default;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(271, 209);
            this.six.Name = "six";
            this.six.ReadOnly = true;
            this.six.Size = new System.Drawing.Size(92, 19);
            this.six.TabIndex = 10;
            this.six.TabStop = false;
            this.six.Text = "0";
            this.six.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.HighlightText;
            this.five.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.five.CausesValidation = false;
            this.five.Cursor = System.Windows.Forms.Cursors.Default;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(108, 209);
            this.five.Name = "five";
            this.five.ReadOnly = true;
            this.five.Size = new System.Drawing.Size(92, 19);
            this.five.TabIndex = 9;
            this.five.TabStop = false;
            this.five.Text = "0";
            this.five.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // row1
            // 
            this.row1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row1.Location = new System.Drawing.Point(151, 47);
            this.row1.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.row1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.row1.Name = "row1";
            this.row1.Size = new System.Drawing.Size(47, 26);
            this.row1.TabIndex = 12;
            this.row1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.row1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // row2
            // 
            this.row2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row2.Location = new System.Drawing.Point(206, 47);
            this.row2.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.row2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.row2.Name = "row2";
            this.row2.Size = new System.Drawing.Size(47, 26);
            this.row2.TabIndex = 13;
            this.row2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.row2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // row3
            // 
            this.row3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row3.Location = new System.Drawing.Point(261, 47);
            this.row3.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.row3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.row3.Name = "row3";
            this.row3.Size = new System.Drawing.Size(47, 26);
            this.row3.TabIndex = 14;
            this.row3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.row3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // row4
            // 
            this.row4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row4.Location = new System.Drawing.Point(316, 47);
            this.row4.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.row4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.row4.Name = "row4";
            this.row4.Size = new System.Drawing.Size(47, 26);
            this.row4.TabIndex = 15;
            this.row4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.row4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // row5
            // 
            this.row5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row5.Location = new System.Drawing.Point(371, 47);
            this.row5.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.row5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.row5.Name = "row5";
            this.row5.Size = new System.Drawing.Size(47, 26);
            this.row5.TabIndex = 16;
            this.row5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.row5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // row6
            // 
            this.row6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row6.Location = new System.Drawing.Point(426, 47);
            this.row6.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.row6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.row6.Name = "row6";
            this.row6.Size = new System.Drawing.Size(47, 26);
            this.row6.TabIndex = 17;
            this.row6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.row6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // row7
            // 
            this.row7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.row7.Location = new System.Drawing.Point(481, 47);
            this.row7.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.row7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.row7.Name = "row7";
            this.row7.Size = new System.Drawing.Size(47, 26);
            this.row7.TabIndex = 18;
            this.row7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.row7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // turns
            // 
            this.turns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turns.Location = new System.Drawing.Point(226, 132);
            this.turns.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.turns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.turns.Name = "turns";
            this.turns.Size = new System.Drawing.Size(120, 26);
            this.turns.TabIndex = 19;
            this.turns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.turns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Din lottorad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Antal dragningar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "5 rätt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "6 rätt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "7 rätt:";
            // 
            // LottoProgram
            // 
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turns);
            this.Controls.Add(this.row7);
            this.Controls.Add(this.row6);
            this.Controls.Add(this.row5);
            this.Controls.Add(this.row4);
            this.Controls.Add(this.row3);
            this.Controls.Add(this.row2);
            this.Controls.Add(this.row1);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.startBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LottoProgram";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto Simulation";
            this.Load += new System.EventHandler(this.LottoProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.row1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.row2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.row3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.row4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.row5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.row6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.row7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox seven;
        private System.Windows.Forms.TextBox six;
        private System.Windows.Forms.TextBox five;
        private System.Windows.Forms.NumericUpDown row1;
        private System.Windows.Forms.NumericUpDown row2;
        private System.Windows.Forms.NumericUpDown row3;
        private System.Windows.Forms.NumericUpDown row4;
        private System.Windows.Forms.NumericUpDown row5;
        private System.Windows.Forms.NumericUpDown row6;
        private System.Windows.Forms.NumericUpDown row7;
        private System.Windows.Forms.NumericUpDown turns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


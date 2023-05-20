namespace CalculatorMVC
{
    partial class CalculatorForm
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
            this.headBox = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tvDisplayResult = new System.Windows.Forms.TextBox();
            this.tvDisplayOperation = new System.Windows.Forms.TextBox();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.headBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headBox
            // 
            this.headBox.Controls.Add(this.btnMinimize);
            this.headBox.Controls.Add(this.btnExit);
            this.headBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.headBox.Location = new System.Drawing.Point(0, 0);
            this.headBox.Margin = new System.Windows.Forms.Padding(0);
            this.headBox.Name = "headBox";
            this.headBox.Size = new System.Drawing.Size(222, 33);
            this.headBox.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.Location = new System.Drawing.Point(144, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(39, 33);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "--";
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(183, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // tvDisplayResult
            // 
            this.tvDisplayResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tvDisplayResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvDisplayResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvDisplayResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tvDisplayResult.Location = new System.Drawing.Point(0, 33);
            this.tvDisplayResult.Margin = new System.Windows.Forms.Padding(0);
            this.tvDisplayResult.Multiline = true;
            this.tvDisplayResult.Name = "tvDisplayResult";
            this.tvDisplayResult.Size = new System.Drawing.Size(222, 28);
            this.tvDisplayResult.TabIndex = 2;
            this.tvDisplayResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tvDisplayOperation
            // 
            this.tvDisplayOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tvDisplayOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvDisplayOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvDisplayOperation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tvDisplayOperation.Location = new System.Drawing.Point(0, 61);
            this.tvDisplayOperation.Margin = new System.Windows.Forms.Padding(0);
            this.tvDisplayOperation.Multiline = true;
            this.tvDisplayOperation.Name = "tvDisplayOperation";
            this.tvDisplayOperation.Size = new System.Drawing.Size(222, 47);
            this.tvDisplayOperation.TabIndex = 3;
            this.tvDisplayOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnN7
            // 
            this.btnN7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnN7.FlatAppearance.BorderSize = 0;
            this.btnN7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnN7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN7.Location = new System.Drawing.Point(5, 125);
            this.btnN7.Margin = new System.Windows.Forms.Padding(0);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(46, 38);
            this.btnN7.TabIndex = 4;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = false;
            // 
            // btnN8
            // 
            this.btnN8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnN8.FlatAppearance.BorderSize = 0;
            this.btnN8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnN8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN8.Location = new System.Drawing.Point(60, 125);
            this.btnN8.Margin = new System.Windows.Forms.Padding(0);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(46, 38);
            this.btnN8.TabIndex = 5;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = false;
            // 
            // btnN9
            // 
            this.btnN9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnN9.FlatAppearance.BorderSize = 0;
            this.btnN9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnN9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN9.Location = new System.Drawing.Point(115, 125);
            this.btnN9.Margin = new System.Windows.Forms.Padding(0);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(46, 38);
            this.btnN9.TabIndex = 6;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(170, 125);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(46, 38);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnN6
            // 
            this.btnN6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnN6.FlatAppearance.BorderSize = 0;
            this.btnN6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnN6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN6.Location = new System.Drawing.Point(115, 173);
            this.btnN6.Margin = new System.Windows.Forms.Padding(0);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(46, 38);
            this.btnN6.TabIndex = 10;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = false;
            // 
            // btnN5
            // 
            this.btnN5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnN5.FlatAppearance.BorderSize = 0;
            this.btnN5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnN5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN5.Location = new System.Drawing.Point(60, 173);
            this.btnN5.Margin = new System.Windows.Forms.Padding(0);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(46, 38);
            this.btnN5.TabIndex = 9;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = false;
            // 
            // btnN4
            // 
            this.btnN4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnN4.FlatAppearance.BorderSize = 0;
            this.btnN4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnN4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN4.Location = new System.Drawing.Point(5, 173);
            this.btnN4.Margin = new System.Windows.Forms.Padding(0);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(46, 38);
            this.btnN4.TabIndex = 8;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = false;
            // 
            // btnN3
            // 
            this.btnN3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnN3.FlatAppearance.BorderSize = 0;
            this.btnN3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnN3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN3.Location = new System.Drawing.Point(115, 221);
            this.btnN3.Margin = new System.Windows.Forms.Padding(0);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(46, 38);
            this.btnN3.TabIndex = 13;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = false;
            // 
            // btnN2
            // 
            this.btnN2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnN2.FlatAppearance.BorderSize = 0;
            this.btnN2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN2.Location = new System.Drawing.Point(60, 221);
            this.btnN2.Margin = new System.Windows.Forms.Padding(0);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(46, 38);
            this.btnN2.TabIndex = 12;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = false;
            // 
            // btnN1
            // 
            this.btnN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnN1.FlatAppearance.BorderSize = 0;
            this.btnN1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN1.Location = new System.Drawing.Point(5, 221);
            this.btnN1.Margin = new System.Windows.Forms.Padding(0);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(46, 38);
            this.btnN1.TabIndex = 11;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = false;
            // 
            // btnN0
            // 
            this.btnN0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnN0.FlatAppearance.BorderSize = 0;
            this.btnN0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnN0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN0.Location = new System.Drawing.Point(5, 269);
            this.btnN0.Margin = new System.Windows.Forms.Padding(0);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(101, 38);
            this.btnN0.TabIndex = 14;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDot.Location = new System.Drawing.Point(115, 269);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(46, 38);
            this.btnDot.TabIndex = 15;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(170, 173);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 38);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSub.Location = new System.Drawing.Point(170, 221);
            this.btnSub.Margin = new System.Windows.Forms.Padding(0);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(46, 38);
            this.btnSub.TabIndex = 17;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(170, 269);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(46, 38);
            this.btnMultiply.TabIndex = 18;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(170, 317);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(46, 38);
            this.btnDivide.TabIndex = 19;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(5, 317);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(0);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(156, 38);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(222, 372);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.tvDisplayOperation);
            this.Controls.Add(this.tvDisplayResult);
            this.Controls.Add(this.headBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorForm";
            this.Text = "Form1";
            this.headBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel headBox;
        private Button btnExit;
        private Button btnN5;
        private Button btnN6;
        private Button btnMinimize;
        private TextBox tvDisplayResult;
        private TextBox tvDisplayOperation;
        private Button btnN7;
        private Button btnN8;
        private Button btnN9;
        private Button btnReset;
        private Button btnN4;
        private Button btnN3;
        private Button btnN2;
        private Button btnN1;
        private Button btnN0;
        private Button btnDot;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEqual;
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            KoefA = new TextBox();
            KoefB = new TextBox();
            KoefC = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Button = new Button();
            x1label = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 9);
            label2.Name = "label2";
            label2.Size = new Size(394, 24);
            label2.TabIndex = 0;
            label2.Text = "Калькулятор квадратных уравнений";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(139, 46);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 1;
            label1.Text = "ax^2+bx+c=0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(28, 70);
            label3.Name = "label3";
            label3.Size = new Size(382, 24);
            label3.TabIndex = 2;
            label3.Text = "_______________________________";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 111);
            label4.Name = "label4";
            label4.Size = new Size(189, 19);
            label4.TabIndex = 3;
            label4.Text = "Введите коэфиценты:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(126, 148);
            label5.Name = "label5";
            label5.Size = new Size(51, 19);
            label5.TabIndex = 4;
            label5.Text = "X^2 +";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(241, 148);
            label6.Name = "label6";
            label6.Size = new Size(33, 19);
            label6.TabIndex = 5;
            label6.Text = "X +";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(338, 148);
            label7.Name = "label7";
            label7.Size = new Size(31, 19);
            label7.TabIndex = 6;
            label7.Text = "= 0";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KoefA
            // 
            KoefA.Location = new Point(68, 144);
            KoefA.Name = "KoefA";
            KoefA.Size = new Size(52, 23);
            KoefA.TabIndex = 7;
            // 
            // KoefB
            // 
            KoefB.Location = new Point(183, 144);
            KoefB.Name = "KoefB";
            KoefB.Size = new Size(52, 23);
            KoefB.TabIndex = 8;
            // 
            // KoefC
            // 
            KoefC.Location = new Point(280, 144);
            KoefC.Name = "KoefC";
            KoefC.Size = new Size(52, 23);
            KoefC.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(28, 170);
            label8.Name = "label8";
            label8.Size = new Size(382, 24);
            label8.TabIndex = 10;
            label8.Text = "_______________________________";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(22, 209);
            label9.Name = "label9";
            label9.Size = new Size(155, 19);
            label9.TabIndex = 11;
            label9.Text = "Корни уравнения:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.LightGray;
            label10.Location = new Point(28, 312);
            label10.Name = "label10";
            label10.Size = new Size(382, 24);
            label10.TabIndex = 12;
            label10.Text = "_______________________________";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Button
            // 
            Button.Location = new Point(28, 349);
            Button.Name = "Button";
            Button.Size = new Size(382, 49);
            Button.TabIndex = 13;
            Button.Text = "Рассчитать";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click_1;
            // 
            // x1label
            // 
            x1label.AutoSize = true;
            x1label.FlatStyle = FlatStyle.Popup;
            x1label.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            x1label.Location = new Point(22, 244);
            x1label.Name = "x1label";
            x1label.Size = new Size(0, 19);
            x1label.TabIndex = 14;
            x1label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 511);
            Controls.Add(x1label);
            Controls.Add(Button);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(KoefC);
            Controls.Add(KoefB);
            Controls.Add(KoefA);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            MaximumSize = new Size(450, 550);
            MinimumSize = new Size(450, 550);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox KoefA;
        private TextBox KoefB;
        private TextBox KoefC;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button Button;
        private Label x1label;
    }
}

namespace LightBoard
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
            btnCalculate = new Button();
            lblResult = new Label();
            groupBox1 = new GroupBox();
            bulb3 = new PictureBox();
            bulb2 = new PictureBox();
            bulb1 = new PictureBox();
            btnNextSignal = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bulb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bulb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bulb1).BeginInit();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 32);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 9);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(211, 20);
            lblResult.TabIndex = 1;
            lblResult.Text = "Нажмите кнопку для расчета";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bulb3);
            groupBox1.Controls.Add(bulb2);
            groupBox1.Controls.Add(bulb1);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 154);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Визуализация";
            // 
            // bulb3
            // 
            bulb3.BorderStyle = BorderStyle.FixedSingle;
            bulb3.Location = new Point(258, 26);
            bulb3.Name = "bulb3";
            bulb3.Size = new Size(120, 120);
            bulb3.TabIndex = 2;
            bulb3.TabStop = false;
            // 
            // bulb2
            // 
            bulb2.BorderStyle = BorderStyle.FixedSingle;
            bulb2.Location = new Point(132, 26);
            bulb2.Name = "bulb2";
            bulb2.Size = new Size(120, 120);
            bulb2.TabIndex = 1;
            bulb2.TabStop = false;
            // 
            // bulb1
            // 
            bulb1.BorderStyle = BorderStyle.FixedSingle;
            bulb1.Location = new Point(6, 26);
            bulb1.Name = "bulb1";
            bulb1.Size = new Size(120, 120);
            bulb1.TabIndex = 0;
            bulb1.TabStop = false;
            // 
            // btnNextSignal
            // 
            btnNextSignal.Enabled = false;
            btnNextSignal.Location = new Point(12, 227);
            btnNextSignal.Name = "btnNextSignal";
            btnNextSignal.Size = new Size(190, 29);
            btnNextSignal.TabIndex = 3;
            btnNextSignal.Text = "Следующий сигнал";
            btnNextSignal.UseVisualStyleBackColor = true;
            btnNextSignal.Click += btnNextSignal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 268);
            Controls.Add(btnNextSignal);
            Controls.Add(groupBox1);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "LightBoard";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bulb3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bulb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bulb1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label lblResult;
        private GroupBox groupBox1;
        private PictureBox bulb3;
        private PictureBox bulb2;
        private PictureBox bulb1;
        private Button btnNextSignal;
    }
}

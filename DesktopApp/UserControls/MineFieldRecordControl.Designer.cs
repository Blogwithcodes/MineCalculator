namespace DesktopApp.UserControls
{
    partial class MineFieldRecordControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            woodenPeg = new Label();
            grOf_tb = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            Downlaod_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 27);
            label1.TabIndex = 2;
            label1.Text = "Mine Field Records ";
            // 
            // woodenPeg
            // 
            woodenPeg.AutoSize = true;
            woodenPeg.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            woodenPeg.Location = new Point(31, 87);
            woodenPeg.Margin = new Padding(4, 0, 4, 0);
            woodenPeg.Name = "woodenPeg";
            woodenPeg.Size = new Size(139, 22);
            woodenPeg.TabIndex = 5;
            woodenPeg.Text = "Distance from";
            // 
            // grOf_tb
            // 
            grOf_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grOf_tb.Location = new Point(177, 83);
            grOf_tb.Name = "grOf_tb";
            grOf_tb.Size = new Size(147, 30);
            grOf_tb.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 22);
            label2.TabIndex = 15;
            label2.Text = "Distance from";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(177, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 30);
            textBox1.TabIndex = 16;
            // 
            // Downlaod_btn
            // 
            Downlaod_btn.BackColor = Color.SkyBlue;
            Downlaod_btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Downlaod_btn.ForeColor = Color.Black;
            Downlaod_btn.Location = new Point(579, 83);
            Downlaod_btn.Name = "Downlaod_btn";
            Downlaod_btn.Size = new Size(163, 43);
            Downlaod_btn.TabIndex = 18;
            Downlaod_btn.Text = "Download";
            Downlaod_btn.UseVisualStyleBackColor = false;
            Downlaod_btn.Click += Downlaod_btn_Click;
            // 
            // MineFieldRecordControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Downlaod_btn);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(grOf_tb);
            Controls.Add(woodenPeg);
            Controls.Add(label1);
            Name = "MineFieldRecordControl";
            Size = new Size(1076, 660);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label woodenPeg;
        private TextBox grOf_tb;
        private Label label2;
        private TextBox textBox1;
        private Button button3;
        private Button Downlaod_btn;
    }
}

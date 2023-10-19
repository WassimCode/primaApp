namespace AutoInterattivaForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //properties



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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(37, 57);
            button2.Name = "button2";
            button2.Size = new Size(291, 58);
            button2.TabIndex = 4;
            button2.Text = "Rifornisci";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(37, 388);
            button3.Name = "button3";
            button3.Size = new Size(112, 50);
            button3.TabIndex = 5;
            button3.Text = "Turn on";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 192);
            button4.Location = new Point(216, 388);
            button4.Name = "button4";
            button4.Size = new Size(112, 50);
            button4.TabIndex = 6;
            button4.Text = "Turn Off";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(37, 135);
            button5.Name = "button5";
            button5.Size = new Size(291, 58);
            button5.TabIndex = 7;
            button5.Text = "Speed Up";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(37, 218);
            button6.Name = "button6";
            button6.Size = new Size(291, 58);
            button6.TabIndex = 8;
            button6.Text = "Slow Down";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 255, 192);
            button9.Location = new Point(37, 301);
            button9.Name = "button9";
            button9.Size = new Size(291, 55);
            button9.TabIndex = 11;
            button9.Text = "Show Details";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(505, 409);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(283, 29);
            progressBar1.TabIndex = 12;
            // s
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria Math", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(711, 330);
            label1.Name = "label1";
            label1.Size = new Size(101, 129);
            label1.TabIndex = 13;
            label1.Text = "Fuel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.andrew_tate;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            MinimumSize = new Size(818, 497);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Commands Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button9;
        private ProgressBar progressBar1;
        private Label label1;
    }
}